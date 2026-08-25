using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace NEALibrary
{
    public class User
    {
        protected string Username;
        protected string Password;
        protected string Usertype;

        public User(string username, string password, string usertype)
        {
            Username = username;
            Password = SHA256Hasher.CalculateHash(password); // This is where I hash the password now anytime in the class it only refers to this hashed password
            Usertype = usertype;
        }

        public string GetUserType()
        {
            return Usertype;
        }

        public int Login_Record_Count()
        {
            using (SqlConnection con = DatabaseConnection.GetConnection()) // Use centralized connection
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();

                string query = $"SELECT * FROM {Usertype} WHERE username = @username AND password COLLATE SQL_Latin1_General_CP1_CS_AS = @password";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@usertype", Usertype);
                    cmd.Parameters.AddWithValue("@username", Username);
                    cmd.Parameters.AddWithValue("@password", Password);

                    DataTable dt = new DataTable();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    con.Close();
                    return dt.Rows.Count;
                }
            }
        }

        public DataTable GetUserDataTable()
        {
            using (SqlConnection con = DatabaseConnection.GetConnection()) // Use centralized connection
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();

                string query = $"SELECT * FROM {Usertype} WHERE username = @username AND password COLLATE SQL_Latin1_General_CP1_CS_AS = @password";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@usertype", Usertype);
                    cmd.Parameters.AddWithValue("@username", Username);
                    cmd.Parameters.AddWithValue("@password", Password);

                    DataTable dt = new DataTable();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    con.Close();
                    return dt;
                }
            }
        }

        public int GetUserId()
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection con = DatabaseConnection.GetConnection()) // Use centralized connection
                {
                    //string query = $"SELECT {GetUserType() + "Id"} FROM {GetUserType()} WHERE Username = @username AND Password = @password";
                    //MessageBox.Show($"Password is {Password}");
                    string query = $"SELECT {GetUserType() + "Id"} FROM {GetUserType()} WHERE Username = @username";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@username", Username);
                        //cmd.Parameters.AddWithValue("@password", Password);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                            if (dt.Rows.Count > 0)
                            {
                                DataRow dr = dt.Rows[0];
                                return Convert.ToInt32(dr[GetUserType() + "Id"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return -1;
        }
    }
}
