using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEALibrary
{
    public class WishList
    {
        private int StudentId;
        private string Title;
        private ISBN Isbn;
        private int No_Of_Requests;
        private string AuthorName;
        public WishList() 
        {
            Isbn = new ISBN();
        }
        public WishList(int studentid, string title, long isbncode, int no_Of_Requests, string authorname)
        {
            StudentId = studentid;
            Title = title;
            Isbn = new ISBN(isbncode);
            No_Of_Requests = no_Of_Requests;
            AuthorName = authorname;

        }

        public bool ValidISBN()
        {
            return Isbn.CheckDigit();
        }
        public void SetStudentId(int studentid)
        {
            StudentId = studentid;
        }
        public void SetTitle(string title)
        {
            Title = title;
        }
        public void SetIsbn(long IsbnCode)
        {
            ISBN isbn = new ISBN(IsbnCode);
            Isbn = isbn;
        }
        public bool ISBNValidLength()
        {
            return Isbn.GetISBNValid();
        }
        
        public void AddWish(int StudentId, string Title, string AuthorName)
        {
            try
            {
                using (SqlConnection con = DatabaseConnection.GetConnection())
                {
                    // Firstly we need to check if the book has alread by put in the wishlist
                    string ISBNQuery = "SELECT No_Of_Requests FROM WishList WHERE ISBN13 = @isbn13";
                    using (SqlCommand IsbnCmd = new SqlCommand(ISBNQuery, con))
                    {
                        IsbnCmd.Parameters.AddWithValue("@isbn13", Isbn.GetISBNCode());
                        con.Open();
                        var result = IsbnCmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value) // This means the book has been wishlisted before
                        {
                            int Number_Of_Requests = Convert.ToInt32(result);
                            string UpdateRequestsQuery = "UPDATE WishList SET No_Of_Requests = @no_of_requests WHERE ISBN13 = @isbn13";
                            using (SqlCommand UpdateCmd = new SqlCommand (UpdateRequestsQuery, con))
                            {
                                UpdateCmd.Parameters.AddWithValue("@isbn13", Isbn.GetISBNCode());
                                UpdateCmd.Parameters.AddWithValue("@no_of_requests", Number_Of_Requests + 1);
                                UpdateCmd.ExecuteNonQuery();
                            }
                            MessageBox.Show("Book Added to Wishlist");
                        }
                        else  // If the book does not exist in the wishlist
                        {
                            string query = "INSERT INTO WishList (StudentId, Title, ISBN13, AuthorName, No_Of_Requests) Values (@studentid, @title, @isbn13, @authorname, @no_of_requests)";
                            using (SqlCommand cmd = new SqlCommand(query, con))
                            {
                                cmd.Parameters.AddWithValue("@title", Title);
                                cmd.Parameters.AddWithValue("@studentid", StudentId);
                                cmd.Parameters.AddWithValue("@isbn13", Isbn.GetISBNCode());
                                cmd.Parameters.AddWithValue("@no_of_requests", 1);

                                cmd.Parameters.AddWithValue("@authorname", AuthorName);


                                
                                cmd.ExecuteNonQuery();
                            }
                            MessageBox.Show("Book Added to Wishlist");
                        }
                        con.Close();

                    }
                    
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public DataTable GetAllWishListData(string StudentId, string Title, string ISBN13, string No_Of_Requests, string AuthorName)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                string query = "SELECT * FROM WishList WHERE StudentId LIKE @studentid AND Title LIKE @title AND ISBN13 LIKE @isbn13 AND No_Of_Requests LIKE @no_of_requests AND AuthorName LIKE @authorname ORDER BY No_Of_Requests DESC";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@title", "%" + Title + "%");
                    cmd.Parameters.AddWithValue("@studentid", "%" + StudentId + "%");
                    cmd.Parameters.AddWithValue("@isbn13", "%" + ISBN13 + "%");
                    cmd.Parameters.AddWithValue("@no_of_requests", "%" + No_Of_Requests + "%");

                    cmd.Parameters.AddWithValue("@authorname", "%" + AuthorName + "%");
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }

            }







            return dt;

        }

        public void RemoveBook (string Title, string AuthorName)
        {
            try
            {
                using (SqlConnection con = DatabaseConnection.GetConnection())
                {
                    string query = "DELETE FROM WishList WHERE Title = @title AND AuthorName = @authorname";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@title", Title);
                        cmd.Parameters.AddWithValue("@authorname", AuthorName);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        

                    }
                    
                }
                MessageBox.Show("Book removed from wishlist");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        public bool IsBookInWishList(string Title, string AuthorName)
        {
            try
            {
                using (SqlConnection con = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT * FROM WishList WHERE Title = @title AND AuthorName = @authorname";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@title", Title);
                        cmd.Parameters.AddWithValue("@authorname", AuthorName);
                        DataTable dt = new DataTable();
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                        con.Close();
                        if (dt.Rows.Count > 0)
                        {
                            return true;
                        }
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


    }
}
