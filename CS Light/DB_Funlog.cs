using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CS_Light
{
    class DB_Funlog
    {
        SqlCommand command = new SqlCommand("", Reg_class.sqlConnection);
        public static string Access_Rights = "000000", System_Access = "00", Login = "";

        public void fcProfile_Authorization(string login, string password)
        {
            command.CommandText = "select [dbo].[Profile_Authorization]('" + login + "','" + password + "')";
            try
            {
                Reg_class.sqlConnection.Open();
                System_Access = command.ExecuteScalar().ToString();
                command.CommandText = "select [dbo].[Access_rights_Value]("
                    + Convert.ToString(System_Access[0]) + ")";
                Access_Rights = command.ExecuteScalar().ToString();
                Login = login;
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
