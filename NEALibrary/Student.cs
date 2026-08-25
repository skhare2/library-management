using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace NEALibrary
{
    public class Student : User
    {
        private string FirstName;
        private string LastName;
        private DateTime DOB;
        private string Email;
        LibrarySetting librarySetting;

        public Student(string firstname, string lastname, DateTime dateofbirth, string username, string password, string email)
            : base(username, password, "Student")
        {
            FirstName = firstname;
            LastName = lastname;
            DOB = dateofbirth;
            Email = email;
            librarySetting = new LibrarySetting();
        }

        public string GetEmail()
        {
            return Email;
        }

        public void AddStudent()
        {
            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Student Values (@firstname, @lastname, @dob, @username, @password, @email)";
                cmd.Parameters.AddWithValue("@firstname", FirstName);
                cmd.Parameters.AddWithValue("@lastname", LastName);
                cmd.Parameters.AddWithValue("@dob", DOB);
                cmd.Parameters.AddWithValue("@username", Username);
                cmd.Parameters.AddWithValue("@password", Password);
                cmd.Parameters.AddWithValue("@email", Email);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            MessageBox.Show("Student Added!");
        }

        public bool CheckStudent()
        {
            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Student WHERE Username = @username OR Email = @email";
                cmd.Parameters.AddWithValue("@username", Username);
                cmd.Parameters.AddWithValue("@email", Email);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Student exists");
                    return true;
                }

                return false;
            }
        }

        public bool ValidEmail()
        {
            string? emaildomain = librarySetting.GetSettingValue("SchoolDomain");
            //MessageBox.Show($"The email domain is {emaildomain}");
            if(emaildomain == null)
            {
                return true;
            }
            if (!Email.Contains(emaildomain))
            {
                MessageBox.Show("Email of invalid domain");
                return false;
            }
            return true;
        }

        public bool ValidUsername()
        {
            int fixedlength = Convert.ToInt32(librarySetting.GetSettingValue("StudentUsernameLength"));
            
            if(fixedlength == -1 && Username.Length > 0)
            {
                return true;
            }
            if (Username.Length == fixedlength)
            {
                return true;
            }
            MessageBox.Show("Invalid username");
            return false;
        }

        public void ChangePassword(string newpassword)
        {
            newpassword = SHA256Hasher.CalculateHash(newpassword);
            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE Student Set Password = @password WHERE Username = @username";
                cmd.Parameters.AddWithValue("@username", Username);
                cmd.Parameters.AddWithValue("@password", newpassword);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            MessageBox.Show("Password Changed!");
        }

        public static bool CheckStudentExists(string Username, string FirstName, string LastName)
        {
            try
            {
                using (SqlConnection con = DatabaseConnection.GetConnection())
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM Student WHERE Username = @username AND FirstName = @firstname AND LastName = @lastname";
                    cmd.Parameters.AddWithValue("@username", Username);
                    cmd.Parameters.AddWithValue("@firstname", FirstName);
                    cmd.Parameters.AddWithValue("@lastname", LastName);

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    con.Close();

                    return dt.Rows.Count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        public static int GetStudentId(string Username, string FirstName, string LastName)
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection con = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT StudentId FROM Student WHERE Username = @username AND FirstName = @firstname AND LastName = @lastname";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@username", Username);
                        cmd.Parameters.AddWithValue("@firstname", FirstName);
                        cmd.Parameters.AddWithValue("@lastname", LastName);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            DataRow dr = dt.Rows[0];
                            return Convert.ToInt32(dr["StudentId"]);
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
 