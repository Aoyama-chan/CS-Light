using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CS_Light
{
    class DB_View
    {
        SqlCommand command = new SqlCommand("", Reg_class.sqlConnection);
        public DataTable vdtProfiles_List = new DataTable("Profiles_List");
        public DataTable vdtInzh = new DataTable("Inzh");
        public DataTable vdtUbor = new DataTable("Ubor");
        public DataTable vdtVozsud = new DataTable("Vozsud");
        public DataTable vdtZhal = new DataTable("Zhal");
        string qrvProfiles_List = "select [Login_list],[Password_list], from [dbo].[Profiles_List]",
            qrvInzh = "select [Login_Inzh], [Surname_Inzh], [Name_Inzh], [Middle_name_Inzh] from [dbo].[Inzh]",
            qrvUbor = "select [Login_Ubor], [Surname_Ubor], [Name_Ubor], [Middle_name_Ubor] from [dbo].[Ubor]",
            qrvVozsud = "select [Name_Vs], [Vs_mod] from [dbo].[Vozsud]",
            qrvZhal = "select [Name_Zhal] from [dbo].[Zhal]";
        private void dtvFill(DataTable table, string query)
        {
            command.CommandText = query;
            command.Notification = null;
            try
            {
                Reg_class.sqlConnection.Open();
                table.Load(command.ExecuteReader());
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

        public void dtvProfiles_List()
        {
            SqlDependency dependency = new SqlDependency(command);
            SqlDependency.Start(Reg_class.sqlConnection.ConnectionString);
            dependency.OnChange += onchangeProfiles_List;
            dtvFill(vdtProfiles_List, qrvProfiles_List);
        }

        private void onchangeProfiles_List(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                dtvProfiles_List();
        }

        public void dtvInzh()
        {
            SqlDependency dependency = new SqlDependency(command);
            SqlDependency.Start(Reg_class.sqlConnection.ConnectionString);
            dependency.OnChange += onchangeInzh;
            dtvFill(vdtInzh, qrvInzh);
        }

        private void onchangeInzh(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                dtvInzh();
        }

        public void dtvUbor()
        {
            SqlDependency dependency = new SqlDependency(command);
            SqlDependency.Start(Reg_class.sqlConnection.ConnectionString);
            dependency.OnChange += onchangeUbor;
            dtvFill(vdtUbor, qrvUbor);
        }

        private void onchangeUbor(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                dtvUbor();
        }

        public void dtvVozsud()
        {
            SqlDependency dependency = new SqlDependency(command);
            SqlDependency.Start(Reg_class.sqlConnection.ConnectionString);
            dependency.OnChange += onchangeVozsud;
            dtvFill(vdtVozsud, qrvVozsud);
        }

        private void onchangeVozsud(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                dtvVozsud();
        }

        public void dtvZhal()
        {
            SqlDependency dependency = new SqlDependency(command);
            SqlDependency.Start(Reg_class.sqlConnection.ConnectionString);
            dependency.OnChange += onchangeZhal;
            dtvFill(vdtZhal, qrvZhal);
        }

        private void onchangeZhal(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                dtvZhal();
        }
    }
}
