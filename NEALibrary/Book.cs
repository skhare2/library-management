using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Drawing;

namespace NEALibrary
{

    public class Book
    {
        
        private string Title;
        private int NumberOfCopies;
        private double Price;
        private string AuthorName;
        private string Genre;
        private string FictionStatus;
        private string AgeGroup;
        public Book()
        {
            
        }
        public DataTable GetAllBookData(string Title, string AuthorName, string AgeGroup, string Genre, string FictionStatus)
        {    // Creates a datatable with all of the book data for librarian
            DataTable dt = new DataTable();
            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                string query = "SELECT * FROM Book WHERE Title LIKE @title AND AuthorName LIKE @authorname AND AgeGroup LIKE @agegroup AND Genre LIKE @genre AND FictionStatus LIKE @fictionstatus";
                using (SqlCommand cmd = new SqlCommand(query,con))
                {
                    cmd.Parameters.AddWithValue("@title", "%" + Title + "%");
                    cmd.Parameters.AddWithValue("@authorname", "%" + AuthorName + "%");
                    cmd.Parameters.AddWithValue("@agegroup", "%" + AgeGroup + "%");
                    cmd.Parameters.AddWithValue("@genre", "%" + Genre + "%");
                    cmd.Parameters.AddWithValue("@fictionstatus", "%" + FictionStatus + "%");
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
                
            }
            

            
            
            
            
            
            return dt;

        }



        public DataTable GetAllStudentBookData(string Title, string AuthorName, string AgeGroup, string Genre, string FictionStatus)
        {  // Creates a data table of book data for students. Meaning some attributes are hidden such as price of books
            DataTable dt = new DataTable();
            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                string query = "SELECT Title, NumberOfCopies, AuthorName, Genre, FictionStatus, AgeGroup FROM Book WHERE Title LIKE @title AND AuthorName LIKE @authorname AND AgeGroup LIKE @agegroup AND Genre LIKE @genre AND FictionStatus LIKE @fictionstatus";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@title", "%" + Title + "%");
                    cmd.Parameters.AddWithValue("@authorname", "%" + AuthorName + "%");
                    cmd.Parameters.AddWithValue("@agegroup", "%" + AgeGroup + "%");
                    cmd.Parameters.AddWithValue("@genre", "%" + Genre + "%");
                    cmd.Parameters.AddWithValue("@fictionstatus", "%" + FictionStatus + "%");
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }

            }







            return dt;

        }

        public int NumberofAvailableCopies(int BookId)
        {  // Finds the number of copies that are not on loan
            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                string query = $"SELECT * FROM BookCopy WHERE BookId = @bookid AND Status = @status";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@bookid", BookId);
                    cmd.Parameters.AddWithValue("@status", "Available");
                    
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


        public int GetBookIdReservation(string Title, string AuthorName, string Genre)
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection con = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT BookId FROM Book WHERE Title = @title AND AuthorName = @authorname AND Genre = genre";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@title", Title);
                        cmd.Parameters.AddWithValue("@authorname", AuthorName);
                        cmd.Parameters.AddWithValue("@genre", Genre);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);

                            
                            if (dt.Rows.Count > 0)
                            {
                                DataRow dr = dt.Rows[0];  
                                return Convert.ToInt32(dr["BookId"]);
                            }
                            else
                            {
                                MessageBox.Show("No matching book found.");
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"SQL Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            return 0;
        }



        public int GetDataBookId(string Title, int NumberOfCopies, double Price, string AuthorName, string Genre, string FictionStatus, string AgeGroup)
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection con = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT BookId FROM Book WHERE Title = @title AND NumberOfCopies = @nofcopies AND Price = @price AND AuthorName = @authorname AND Genre = @genre AND FictionStatus = @fictionstatus AND AgeGroup = @agegroup";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@title", Title);
                        cmd.Parameters.AddWithValue("@nofcopies", NumberOfCopies);
                        cmd.Parameters.AddWithValue("@price", Price);
                        cmd.Parameters.AddWithValue("@authorname", AuthorName);
                        cmd.Parameters.AddWithValue("@genre", Genre);
                        cmd.Parameters.AddWithValue("@fictionstatus", FictionStatus);
                        cmd.Parameters.AddWithValue("@agegroup", AgeGroup);
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd)) // used to read data
                        {
                            da.Fill(dt);
                            DataRow dr = dt.Rows[0];
                            return Convert.ToInt32(dr["BookId"].ToString());
                        }
                    }

                }
                
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return -1;

        }

        public void EditBookDetail(string Title, int NumberOfCopies, double Price, string AuthorName, string Genre, string FictionStatus, string AgeGroup, int BookId)
        {
            try
            {
                using (SqlConnection con = DatabaseConnection.GetConnection())
                {
                    string query = "UPDATE Book SET Title = @title, NumberOfCopies = @nofcopies, Price = @price, AuthorName = @authorname, Genre = @genre, FictionStatus = @fictionstatus, AgeGroup = @agegroup WHERE BookId = @bookid";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@title", Title);
                        cmd.Parameters.AddWithValue("@nofcopies", NumberOfCopies);
                        cmd.Parameters.AddWithValue("@price", Price);
                        cmd.Parameters.AddWithValue("@authorname", AuthorName);
                        cmd.Parameters.AddWithValue("@genre", Genre);
                        cmd.Parameters.AddWithValue("@fictionstatus", FictionStatus);
                        cmd.Parameters.AddWithValue("@agegroup", AgeGroup);
                        cmd.Parameters.AddWithValue("@bookid", BookId);
                        con.Open();
                        cmd.ExecuteNonQuery(); // Used for commands to change data

                    }
                }
                MessageBox.Show("Book details changed successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

        public void AddBook(string Title, int NumberOfCopies, double Price, string AuthorName, string Genre, string FictionStatus, string AgeGroup)
        {
            try
            {
                using (SqlConnection con = DatabaseConnection.GetConnection())
                {
                    string query = "INSERT INTO Book Values (@title, @numberofcopies, @price, @authorname, @genre, @fictionstatus, @agegroup)";
                    using(SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@title", Title);
                        cmd.Parameters.AddWithValue("@numberofcopies", NumberOfCopies);
                        cmd.Parameters.AddWithValue("@price", Price);
                        cmd.Parameters.AddWithValue("@authorname", AuthorName);
                        cmd.Parameters.AddWithValue("@genre", Genre);
                        cmd.Parameters.AddWithValue("@fictionstatus", FictionStatus);
                        cmd.Parameters.AddWithValue("@agegroup", AgeGroup);
                        
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Book Added");
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<int> AddCopies(int BookId, int NumberOfCopies) // Returning a list of the new copyids
        {
            List<int> copyids = new List<int>();
            try
            {
                using (SqlConnection con = DatabaseConnection.GetConnection())
                {
                    string query = @"
                        DECLARE @i int = 0;
                        DECLARE @copyId int;
                        CREATE TABLE #TempCopyIds (CopyId int);
                        WHILE @i < @numberofcopies 
                        BEGIN 
                            SET @i = @i + 1;
                            INSERT INTO BookCopy(Status, BookId) 
                            VALUES('Available', @bookid);

                            SET @copyId = SCOPE_IDENTITY();
                            INSERT INTO #TempCopyIds (CopyId) VALUES (@copyId);
                            
                        END
                        SELECT CopyId FROM #TempCopyIds;
                        DROP TABLE #TempCopyIds"; // The while loop, scope identity, and temporary table are referenced in the NEA document. The only part I can be given credit for is the insert query
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        
                        cmd.Parameters.AddWithValue("@numberofcopies", NumberOfCopies);
                        cmd.Parameters.AddWithValue("@bookid", BookId);


                        con.Open();
                        
                        using(SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                
                                copyids.Add(Convert.ToInt32(dr[0])); // Add copyid to the list
                            }
                        }
                    }
                }
                MessageBox.Show("Copies Added");
                return copyids;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return copyids;
            }
        }
        public int DoesBookExist(string Title, string AuthorName)
        {
            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                string query = $"SELECT * FROM Book WHERE Title = @title AND AuthorName = @authorname";

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
                    return dt.Rows.Count; // Returns the number of matching rows
                }
            }
        }

        public int GetBookIdIfBookExists(string Title, string AuthorName) //
        {
            

            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                string query = $"SELECT * FROM Book WHERE Title = @title AND AuthorName = @authorname";

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
                        DataRow dr = dt.Rows[0];
                        return Convert.ToInt32(dr["BookId"]);
                    }
                    return -1;
                }
            }
            
        }

        public bool DoesBookCopyExist(int CopyID)
        {
            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                string query = $"SELECT * FROM BookCopy WHERE CopyID = @copyid";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    
                    cmd.Parameters.AddWithValue("@copyid", CopyID);


                    DataTable dt = new DataTable();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    con.Close();
                    return dt.Rows.Count > 0;
                }
            }

        }

        public string GetBookCopyStatus(int CopyID)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                string query = "SELECT Status FROM BookCopy WHERE CopyID = @copyid";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    
                    cmd.Parameters.AddWithValue("@copyid", CopyID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd)) 
                    {
                        da.Fill(dt);
                        DataRow dr = dt.Rows[0];
                        return dr["Status"].ToString();
                    }
                }

            }
        }
        public string GetCopyBookTitle(int CopyID)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                string query = "SELECT Title FROM Book, BookCopy WHERE BookCopy.CopyId = @copyid AND Book.BookId = BookCopy.BookId";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {

                    cmd.Parameters.AddWithValue("@copyid", CopyID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                        DataRow dr = dt.Rows[0];
                        return dr["Title"].ToString();
                    }
                }

            }
        }

        public int GetNumberOfCopies(int bookId) // Method finds the number of copies so we can update it correctly
        {
            try
            {
                using(SqlConnection con = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT NumberOfCopies FROM BOOK WHERE BookId = @bookid";
                    using(SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@bookid", bookId);
                        con.Open();
                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1; // Error occured
            }
        }

        public void ModifyNumberOfCopies(int bookId, int NumberOfCopies) // The value stored in the number of copies attribute will be the nuw number of copies
        {
            try
            {
                using (SqlConnection con = DatabaseConnection.GetConnection())
                {
                    string query = "UPDATE Book SET NumberOfCopies = @numberofcopies WHERE BookId = @bookid";
                    using (SqlCommand cmd = new SqlCommand (query, con))
                    {
                        cmd.Parameters.AddWithValue("@numberofcopies", NumberOfCopies);
                        cmd.Parameters.AddWithValue("@bookid", bookId);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static int GetBookIdByCopyId(int copyId)
        {
            try
            {
                using (SqlConnection con = DatabaseConnection.GetConnection())
                {
                    
                    string query = "SELECT BookId FROM BookCopy WHERE CopyId = @copyid";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@copyid", copyId);

                        con.Open();
                        object result = cmd.ExecuteScalar(); 

                        if (result != null)
                        {
                            return Convert.ToInt32(result);
                        }
                        else
                        {
                            MessageBox.Show("No matching book copy found.");
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
        public void DeleteBookCopy(int copyId)
        {
            try
            {
                using (SqlConnection con = DatabaseConnection.GetConnection())
                {

                    string query = "DELETE FROM BookCopy WHERE CopyId = @copyid";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@copyid", copyId);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DecrementNumberOfCopies(int bookId)
        {
            int currentNumberOfCopies = GetNumberOfCopies(bookId);
            if (currentNumberOfCopies > 0)
            {
                ModifyNumberOfCopies(bookId, currentNumberOfCopies - 1);
            }
        }
        public void RemoveBook(int bookId)
        {
            try
            {
                using (SqlConnection con = DatabaseConnection.GetConnection())
                {
                    
                    string query = "DELETE FROM Book WHERE BookId = @bookid";




                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@bookid", bookId);

                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery(); 

                        
                       
                    }
                }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void RemoveCopy(int copyId) // Cascadeset up
        {
            try
            {
                using (SqlConnection con = DatabaseConnection.GetConnection())
                {
                    con.Open(); 
                    string query = "DELETE FROM BookCopy WHERE CopyId = @copyId";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@copyId", copyId);
                        cmd.ExecuteNonQuery(); 

                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        






    }

}
