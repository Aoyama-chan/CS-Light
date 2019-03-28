using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CS_Light
{
    class DB_Tables
    {
        Reg_class registry = new Reg_class();
        public SqlCommand command = new SqlCommand();
        public event Action<DataTable> dtFillFull;
        public DataTable dtAccess_rights = new DataTable("Access_rights");
        public DataTable dtProfile = new DataTable("Profile");
        public DataTable dtInzh = new DataTable("Inzh");
        public DataTable dtUbor = new DataTable("Ubor");
        public DataTable dtZhal = new DataTable("Zhal");
        public DataTable dtVozsud = new DataTable("Vozsud");

        public string qrAccess_rights = "select [ID_Access_rights],[Access_rights_name],[Inzh],[Ubor], [Vozsud], [Zhal] from[dbo].[Access_rights] where[Access_rights_Logical_Delete] = 0",
            qrProfile = "select [Login_Profile],[Password_Profile], [System_access], [Access_rights_ID] from[dbo].[Profile] where[Profile_Logical_Delete] = 0 and[Login_Profile]<> ''",
            qrInzh = "select [ID_Inzh],[Login_Inzh], [Surname_Inzh], [Name_Inzh], [Middle_name_Inzh] from [dbo].[Inzh] where [Inzh_Logical_Delete] = 0",
            qrUbor = "select [ID_Ubor],[Login_Ubor], [Surname_Ubor], [Name_Ubor], [Middle_name_Ubor] from[dbo].[Ubor] where [Ubor_Logical_Delete] = 0",
            qrZhal = "select [ID_Zhal], [Name_Zhal] where [Zhal_Logical_Delete] = 0",
            qrVozsud = "select [ID_Vozsud],[Name_Vs], [Vs_mod]  where [Zhal_Logical_Delete] = 0";


        private void dtFill(DataTable table, string query)
        {
            try
            {
                command.Notification = null;
                command.CommandText = query;
                command.Connection = Reg_class.sqlConnection;
                Reg_class.sqlConnection.Open();
                table.Load(command.ExecuteReader());
                dtFillFull(table);

            }
            catch (Exception ex)
            {
                Reg_class.error_message += "\n"
                    + DateTime.Now.ToLongDateString() + ex.Message;
            }
            finally
            {
                Reg_class.sqlConnection.Close();
            }
        }

        public void dtAccess_rightsFill()
        {
            dtFill(dtAccess_rights, qrAccess_rights);
        }

        public void dtProfileFill()
        {
            dtFill(dtProfile, qrProfile);
        }

        public void dtInzhFill()
        {
            dtFill(dtInzh, qrInzh);
        }

        public void dtUborFill()
        {
            dtFill(dtUbor, qrUbor);
        }

        public void dtVozsudFill()
        {
            dtFill(dtVozsud, qrVozsud);
        }

        public void dtZhalFill()
        {
            dtFill(dtZhal, qrZhal);
        }
    }
}
