using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CS_Light
{
    class DB_Fun_Eng
    {
        DataTable dtEngineer = new DataTable("Engineer");
        public event Action<DataTable> fillEngineer;
        SqlCommand command = new SqlCommand("", Reg_class.sqlConnection);
        public string Login, Surname, Name, Middle_name;

        public void dtEngineerCreate()
        {
            DataTable table = new DataTable();
            command.CommandText = "select * from [dbo].[Inzh]('" + Login + "','"
                + Surname + "','" + Name + "','" + Middle_name + "')";
            try
            {
                Reg_class.sqlConnection.Open();
                table.Load(command.ExecuteReader());
                dtEngineer.Columns.Add();
                dtEngineer.Rows.Add();
                foreach (DataRow dateRow in table.Rows)
                {
                    dtEngineer.Columns.Add(dateRow[0].ToString());
                }
                table.Clear();
                command.CommandText = "select * from [dbo].[Inzh]";
                table.Load(command.ExecuteReader());
                foreach (DataRow studentRow in table.Rows)
                {
                    dtEngineer.Rows.Add(studentRow[0].ToString());
                }
                table.Clear();
                for (int i = 0; i < dtEngineer.Columns.Count; i++)
                    for (int j = 0; j < dtEngineer.Rows.Count; j++)
                    {
                        command.CommandText = "select [dbo].[Inzh]('"
                            + dtEngineer.Rows[i + 1][0].ToString() + "','"
                            + dtEngineer.Rows[0][j + 1].ToString() + "')";
                        dtEngineer.Rows[i + 1][j + 1] = command.ExecuteScalar().ToString();
                    }
                fillEngineer(dtEngineer);
            }
            catch (SqlException ex)
            {
                Reg_class.error_message += DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Reg_class.sqlConnection.Close();
            }
        }
    }
}
