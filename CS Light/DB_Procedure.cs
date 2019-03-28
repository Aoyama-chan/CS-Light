using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CS_Light
{
    class DB_Procedure
    {
        private SqlCommand cmd = new SqlCommand("Empty", Reg_class.sqlConnection);
        private void spConfiguration(string spName)
        {
            cmd.CommandText = spName;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
        }

        public void spInzh_Insert(string Login_Inzh, string Surname_Inzh, string Name_Inzh, string Middle_name_Inzh)
        {
            spConfiguration("Inzh_Insert");
            try
            {
                cmd.Parameters.AddWithValue("@Login_Inzh", Login_Inzh);
                cmd.Parameters.AddWithValue("@Surname_Inzh", Surname_Inzh);
                cmd.Parameters.AddWithValue("@Name_Inzh", Name_Inzh);
                cmd.Parameters.AddWithValue("@Middle_name_Inzh", Middle_name_Inzh);
                Reg_class.sqlConnection.Open();
                cmd.ExecuteNonQuery();
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

        public void spInzh_Update(Int32 ID_Inzh, string Login_Inzh, string Surname_Inzh, string Name_Inzh, string Middle_name_Inzh)
        {
            spConfiguration("Inzh_Update");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Inzh", ID_Inzh);
                cmd.Parameters.AddWithValue("@Login_Inzh", Login_Inzh);
                cmd.Parameters.AddWithValue("@Surname_Inzh", Surname_Inzh);
                cmd.Parameters.AddWithValue("@Name_Inzh", Name_Inzh);
                cmd.Parameters.AddWithValue("@Middle_name_Inzh", Middle_name_Inzh);
                Reg_class.sqlConnection.Open();
                cmd.ExecuteNonQuery();
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

        public void spInzh_Delete(Int32 ID_Inzh)
        {
            spConfiguration("Inzh_Delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Inzh", ID_Inzh);
                Reg_class.sqlConnection.Open();
                cmd.ExecuteNonQuery();
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

        public void spDiscipline_Logical_Delete(Int32 ID_Inzh)
        {
            spConfiguration("Inzh_Logical_Delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Inzh", ID_Inzh);
                Reg_class.sqlConnection.Open();
                cmd.ExecuteNonQuery();
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

        public void spUbor_Insert(string Login_Ubor, string Surname_Ubor, string Name_Ubor, string Middle_name_Ubor)
        {
            spConfiguration("Ubor_Insert");
            try
            {
                cmd.Parameters.AddWithValue("@Login_Ubor", Login_Ubor);
                cmd.Parameters.AddWithValue("@Surname_Ubor", Surname_Ubor);
                cmd.Parameters.AddWithValue("@Name_Ubor", Name_Ubor);
                cmd.Parameters.AddWithValue("@Middle_name_Ubor", Middle_name_Ubor);
                Reg_class.sqlConnection.Open();
                cmd.ExecuteNonQuery();
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

        public void spUbor_Update(Int32 ID_Ubor, string Login_Ubor, string Surname_Ubor, string Name_Ubor, string Middle_name_Ubor)
        {
            spConfiguration("Ubor_Update");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Ubor", ID_Ubor);
                cmd.Parameters.AddWithValue("@Login_Ubor", Login_Ubor);
                cmd.Parameters.AddWithValue("@Surname_Ubor", Surname_Ubor);
                cmd.Parameters.AddWithValue("@Name_Ubor", Name_Ubor);
                cmd.Parameters.AddWithValue("@Middle_name_Ubor", Middle_name_Ubor);
                Reg_class.sqlConnection.Open();
                cmd.ExecuteNonQuery();
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

        public void spUbor_Delete(Int32 ID_Ubor)
        {
            spConfiguration("Ubor_Delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Ubor", ID_Ubor);
                Reg_class.sqlConnection.Open();
                cmd.ExecuteNonQuery();
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

        public void spUbor_Logical_Delete(Int32 ID_Ubor)
        {
            spConfiguration("Ubor_Logical_Delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Ubor", ID_Ubor);
                Reg_class.sqlConnection.Open();
                cmd.ExecuteNonQuery();
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

        public void spVozsud_Insert(string Name_Vs, string Vs_mod)
        {
            spConfiguration("Vozsud_Insert");
            try
            {
                cmd.Parameters.AddWithValue("@Name_Vs", Name_Vs);
                cmd.Parameters.AddWithValue("@Vs_mod", Vs_mod);
                Reg_class.sqlConnection.Open();
                cmd.ExecuteNonQuery();
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

        public void spVozsud_Update(Int32 ID_Vs, string Name_Vs, string Vs_mod)
        {
            spConfiguration("Vozsud_Update");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Vs", ID_Vs);
                cmd.Parameters.AddWithValue("@Name_Vs", Name_Vs);
                cmd.Parameters.AddWithValue("@Vs_mod", Vs_mod);
                Reg_class.sqlConnection.Open();
                cmd.ExecuteNonQuery();
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

        public void spVozsud_Delete(Int32 ID_Vs)
        {
            spConfiguration("Vozsud_Delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Vs", ID_Vs);
                Reg_class.sqlConnection.Open();
                cmd.ExecuteNonQuery();
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

        public void spVozsud_Logical_Delete(Int32 ID_Vs)
        {
            spConfiguration("Vozsud_Logical_Delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Vs", ID_Vs);
                Reg_class.sqlConnection.Open();
                cmd.ExecuteNonQuery();
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

        public void spZhal_Insert(string Name_Zhal)
        {
            spConfiguration("Zhal_Insert");
            try
            {
                cmd.Parameters.AddWithValue("@Name_Zhal", Name_Zhal);
                Reg_class.sqlConnection.Open();
                cmd.ExecuteNonQuery();
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

        public void spZhal_Update(Int32 ID_Zhal, string Name_Zhal)
        {
            spConfiguration("Zhal_Update");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Zhal", ID_Zhal);
                cmd.Parameters.AddWithValue("@Name_Zhal", Name_Zhal);
                Reg_class.sqlConnection.Open();
                cmd.ExecuteNonQuery();
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

        public void spZhal_Delete(Int32 ID_Zhal)
        {
            spConfiguration("Zhal_Delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Zhal", ID_Zhal);
                Reg_class.sqlConnection.Open();
                cmd.ExecuteNonQuery();
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

        public void spZhal_Logical_Delete(Int32 ID_Zhal)
        {
            spConfiguration("Zhal_Logical_Delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Zhal", ID_Zhal);
                Reg_class.sqlConnection.Open();
                cmd.ExecuteNonQuery();
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

        public void spAccess_rights_Insert(string Access_rights_name, Int32 Inzh,
        Int32 Ubor, Int32 Vozsud, Int32 Zhal)
        {
            spConfiguration("Access_rights_Insert");
            try
            {
                cmd.Parameters.AddWithValue("@Access_rights_name", Access_rights_name);
                cmd.Parameters.AddWithValue("@Inzh", Inzh);
                cmd.Parameters.AddWithValue("@Ubor", Ubor);
                cmd.Parameters.AddWithValue("@Vozsud", Vozsud);
                cmd.Parameters.AddWithValue("@Zhal", Zhal);
                Reg_class.sqlConnection.Open();
                cmd.ExecuteNonQuery();
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

        public void spAccess_rights_Update(Int32 ID_Access_rights, string Access_rights_name, Int32 Inzh,
        Int32 Ubor, Int32 Vozsud, Int32 Zhal)
        {
            spConfiguration("Access_rights_Update");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Access_rights", ID_Access_rights);
                cmd.Parameters.AddWithValue("@Access_rights_name", Access_rights_name);
                cmd.Parameters.AddWithValue("@Inzh", Inzh);
                cmd.Parameters.AddWithValue("@Ubor", Ubor);
                cmd.Parameters.AddWithValue("@Vozsud", Vozsud);
                cmd.Parameters.AddWithValue("@Zhal", Zhal);
                Reg_class.sqlConnection.Open();
                cmd.ExecuteNonQuery();
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

        public void spAccess_rights_Delete(Int32 ID_Access_rights)
        {
            spConfiguration("Access_rights_Delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Access_rights", ID_Access_rights);
                Reg_class.sqlConnection.Open();
                cmd.ExecuteNonQuery();
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

        public void spAccess_rights_Logical_Delete(Int32 ID_Access_rights)
        {
            spConfiguration("Access_rights_Logical_Delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Access_rights", ID_Access_rights);
                Reg_class.sqlConnection.Open();
                cmd.ExecuteNonQuery();
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

        public void spProfile_New_User(string Login_Profile, string Password_Profile, Int32 System_access, Int32 Access_rights_ID)
        {
            spConfiguration("Profile_New_User");
            try
            {
                cmd.Parameters.AddWithValue("@Login_Profile", Login_Profile);
                cmd.Parameters.AddWithValue("@Password_Profile", Password_Profile);
                cmd.Parameters.AddWithValue("@System_access", System_access);
                cmd.Parameters.AddWithValue("@Access_rights_ID", Access_rights_ID);
                Reg_class.sqlConnection.Open();
                cmd.ExecuteNonQuery();
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

        public void spProfile_Update_User(Int32 ID_Profile, string Login_Profile, string Password_Profile, Int32 System_access, Int32 Access_rights_ID)
        {
            spConfiguration("Profile_Update_User");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Profile", ID_Profile);
                cmd.Parameters.AddWithValue("@Login_Profile", Login_Profile);
                cmd.Parameters.AddWithValue("@Password_Profile", Password_Profile);
                cmd.Parameters.AddWithValue("@System_access", System_access);
                cmd.Parameters.AddWithValue("@Access_rights_ID", Access_rights_ID);
                Reg_class.sqlConnection.Open();
                cmd.ExecuteNonQuery();
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

        public void spProfile_Delete_User(Int32 ID_Profile)
        {
            spConfiguration("Profile_Delete_User");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Profile", ID_Profile);
                Reg_class.sqlConnection.Open();
                cmd.ExecuteNonQuery();
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

        public void spProfile_Logical_Delete(Int32 ID_Profile)
        {
            spConfiguration("Profile_Logical_Delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Profile", ID_Profile);
                Reg_class.sqlConnection.Open();
                cmd.ExecuteNonQuery();
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

        public void spProfile_Block_User(Int32 ID_Profile)
        {
            spConfiguration("Profile_Block_User");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Profile", ID_Profile);
                Reg_class.sqlConnection.Open();
                cmd.ExecuteNonQuery();
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

        public void spProfile_Unblok_User(Int32 ID_Profile)
        {
            spConfiguration("Profile_Unblok_User");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Profile", ID_Profile);
                Reg_class.sqlConnection.Open();
                cmd.ExecuteNonQuery();
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
