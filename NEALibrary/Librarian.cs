using Microsoft.Data.SqlClient;
using ScottPlot.Colormaps;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NEALibrary
{
    public class Librarian : User
    {
        
        private string FirstName;
        private string LastName;
        private DateTime DOB;
        private string Email;


        public Librarian(string firstname, string lastname, DateTime dateofbirth, string username, string password, string email) : base(username, password, "Librarian")
        {
            FirstName = firstname;
            LastName = lastname;
            DOB = dateofbirth;
            Email = email;
        }
        

        public static DataTable GetLibrarianData()
        {
            DataTable dt = new DataTable();
            try
            {
                
                using (SqlConnection con = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT FirstName, LastName, DOB, Username, Email, IsAdmin FROM Librarian";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }

                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;


        }

        public static void AddLibrarian(string firstName, string lastName, DateTime dob, string username, string password, string email, string isAdmin)
        {
            try
            {
                password = SHA256Hasher.CalculateHash(password);
                using (SqlConnection con = DatabaseConnection.GetConnection())
                {
                    string checkQuery = "SELECT COUNT(*) FROM Librarian WHERE Username = @username OR Email = @Email";
                    // First check if anyone with this username or password exists
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                    {
                        checkCmd.Parameters.AddWithValue("@username", username);
                        checkCmd.Parameters.AddWithValue("@Email", email);

                        con.Open();
                        int count = (int)checkCmd.ExecuteScalar();
                        con.Close();

                        if (count > 0)
                        {
                            MessageBox.Show("A librarian with this username or email exists. Please use a unique username and email.");
                            return; 
                        }
                    }

                    string query = "INSERT INTO Librarian (FirstName, LastName, DOB, Username, Password, Email, IsAdmin) VALUES (@firstName, @lastName, @dob, @username, @password, @email, @isAdmin)";
                    // This is the query to insert once it has been checked no user exists with the credentials 
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        
                        cmd.Parameters.AddWithValue("@firstName", firstName);
                        cmd.Parameters.AddWithValue("@lastName", lastName);
                        cmd.Parameters.AddWithValue("@dob", dob);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password); // Look here again
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@isAdmin", isAdmin);

                        
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Librarian added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public static void EditLibrarianDetails(string firstName, string lastName, DateTime dob, string username, string email, string isAdmin)
        {
            try
            {
                using (SqlConnection con = DatabaseConnection.GetConnection())
                {
                    
                    string query = "UPDATE Librarian SET FirstName = @firstName, LastName = @lastName, DOB = @dob, Username = @username, Email = @Email, IsAdmin = @isAdmin WHERE Username = @username OR Email = @Email";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        
                        cmd.Parameters.AddWithValue("@firstName", firstName);

                        cmd.Parameters.AddWithValue("@lastName", lastName);
                        cmd.Parameters.AddWithValue("@dob", dob);

                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@isAdmin", isAdmin);

                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Librarian details updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Librarian not found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public static void UpdatePassword(string Username, string Email, string newPassword)
        {
            if (!LibrarianExists(Username, Email))
            {
                MessageBox.Show("Librarian not found. Please check the Username or Email and try again.");
                return;
            }

            try
            {
                newPassword = SHA256Hasher.CalculateHash(newPassword);
                using (SqlConnection con = DatabaseConnection.GetConnection())
                {
                    string query = "UPDATE Librarian SET Password = @newPassword WHERE Username = @username OR Email = @Email";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@newPassword", newPassword);
                        cmd.Parameters.AddWithValue("@username", Username);
                        cmd.Parameters.AddWithValue("@Email", Email);

                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Password update failed. Librarian not found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static bool LibrarianExists(string Username, string Email)
        {
            bool exists = false;

            try
            {
                using (SqlConnection con = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT COUNT(*) FROM Librarian WHERE Username = @username OR Email = @Email";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@username", Username);
                        cmd.Parameters.AddWithValue("@Email", Email);

                        con.Open();
                        int count = (int)cmd.ExecuteScalar();
                        exists = count > 0;  // If count > 0 a user exists
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return exists;
        }
        public static void RemoveLibrarian(string Username, string Email)
        {
            try
            {



                using (SqlConnection con = DatabaseConnection.GetConnection())
                {
                    string query = "DELETE FROM Librarian WHERE Username = @username AND Email = @Email";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@username", Username);
                        cmd.Parameters.AddWithValue("@Email", Email);




                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {


                            MessageBox.Show("Librarian removed successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Librarian not found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static bool GetIsAdmin(int LibrarianId)
        {
            bool isAdmin = false; 
            try
            {
                using (SqlConnection con = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT IsAdmin FROM Librarian WHERE LibrarianId = @librarianId";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@librarianId", LibrarianId);
                        //MessageBox.Show($"The LibrarianId is {LibrarianId}");

                        con.Open();
                        var result = cmd.ExecuteScalar();
                        //MessageBox.Show($"Hi the result is {result}");


                        if (result != null && result != DBNull.Value) // In this case a null value could lead to errors so need to prevent this
                        {
                            //MessageBox.Show($"IS ADMIN RESULT - {result}"); // remove
                            isAdmin = Convert.ToBoolean(result); 
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return isAdmin; 
        }





    }
}
