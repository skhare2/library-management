using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NEALibrary
{
    public class Reservation
    {
        int ReservationId;
        int StudentId;
        int BookId;
        string Status;
        public Reservation() 
        {

        }


        public bool CheckReservationExists(int StudentId, int BookId) // The aim of this method is to prevent duplicate reservations
        {
            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM Reservation WHERE StudentId = @studentId AND BookId = @bookId AND Status = 'Pending'";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@studentId", StudentId);
                    cmd.Parameters.AddWithValue("@bookId", BookId);
                    con.Open();
                    int rows = Convert.ToInt32(cmd.ExecuteScalar()); // The is where the number of rows with the info we want is stored
                    return rows > 0;
                }
            }
        }
        public void AddReservation(int StudentId, int BookId)
        {
            try
            {
                using (SqlConnection con = DatabaseConnection.GetConnection())
                {



                    string query = "INSERT INTO Reservation (StudentId, BookId, Status, ReservationDate) VALUES (@studentId, @bookId, @status, @reservationDate)";


                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@studentId", StudentId);
                        cmd.Parameters.AddWithValue("@bookId", BookId);
                        cmd.Parameters.AddWithValue("@status", "Pending"); // Status can be 'Pending', 'Completed' However as we are inserting only pending is relevant.
                        cmd.Parameters.AddWithValue("@reservationDate", DateTime.Now);


                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Book reserved successfully!");
                            
                        }
                        else
                        {
                            MessageBox.Show("Error reserving the book. Please try again.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static bool IsBookReserved(int copyId)
        {
            bool isReserved = false;
            try
            {
                


                using (SqlConnection con = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT COUNT(*) FROM Reservation, BookCopy WHERE BookCopy.CopyId = @copyId AND BookCopy.BookId = Reservation.BookId";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@copyId", copyId);

                        con.Open();
                        isReserved = (int)cmd.ExecuteScalar() > 0;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            return isReserved;
        }

        public static void MarkReservationAsComplete(int copyId)
        {
            try
            {
                using (SqlConnection con = DatabaseConnection.GetConnection())
                {
                    string query = "UPDATE Reservation SET Status = 'Complete', CompletionDate = @completiondate WHERE BookId IN (SELECT BookId FROM BookCopy WHERE CopyId = @copyId) AND Reservation.Status = 'Pending' AND Reservation.CompletionDate IS NULL";
                    // To Do this I could have called another method but that is much longer. I researched how to make what is called a subquery and then discovered the IN keyword. I have referenced this 
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@copyId", copyId);
                        cmd.Parameters.AddWithValue("@completiondate", DateTime.Now);
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

        public static DataTable GetCompletedReservationsByStudentId(int StudentId)
        {
            DataTable dt = new DataTable();
            try
            {
                

                using (SqlConnection con = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT ReservationId, BookId, Status, ReservationDate, CompletionDate FROM Reservation WHERE StudentId = @studentId AND Status = 'Complete'";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@studentId", StudentId);
                        con.Open();

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
                dt.Columns.Add("ReservationEndDate", typeof(DateTime));

                // Calculate the ReservationEndDate for each row
                LibrarySetting librarySetting = new LibrarySetting();
                int DaysToAdd = Convert.ToInt32(librarySetting.GetSettingValue("ReservationExpire")); // The days is gotten from the library settings table
                foreach (DataRow row in dt.Rows)
                {
                    DateTime completionDate = Convert.ToDateTime(row["CompletionDate"]);
                    DateTime reservationEndDate = completionDate.AddDays(DaysToAdd);
                    row["ReservationEndDate"] = reservationEndDate;
                }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt; 
        }

        

        
        public static void RemoveReservation(int reservationId)
        {
            try
            {
                using (SqlConnection con = DatabaseConnection.GetConnection())
                {
                    string query = "DELETE FROM Reservation WHERE ReservationId = @reservationId";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@reservationId", reservationId);
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
        public static void RemoveAllExpiredReservations() // This is to remove expired reservation regardless of student
        {
            try
            {
                using (SqlConnection con = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT ReservationId, CompletionDate FROM Reservation WHERE Status = 'Complete'";




                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        con.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int reservationId = Convert.ToInt32(reader["ReservationId"]);



                                DateTime completionDate = Convert.ToDateTime(reader["CompletionDate"]);

                                LibrarySetting librarySetting = new LibrarySetting();
                                int daysToAdd = Convert.ToInt32(librarySetting.GetSettingValue("ReservationExpire"));
                                DateTime reservationEndDate = completionDate.AddDays(daysToAdd);






                                if (reservationEndDate < DateTime.Now)
                                {
                                    RemoveReservation(reservationId);
                                }
                            }
                        }
                    }
                }
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        

        private void IssueBookToStudent(int reservationId, int studentId, int copyId)
        {
            try
            {
                // Mark the reservation as completed
                using (SqlConnection con = DatabaseConnection.GetConnection())
                {
                    string updateReservationStatusQuery = "UPDATE Reservation SET Status = 'Complete', CompletionDate = @completionDate WHERE ReservationId = @reservationId";
                    using (SqlCommand updateReservationCmd = new SqlCommand(updateReservationStatusQuery, con))
                    {
                        updateReservationCmd.Parameters.AddWithValue("@reservationId", reservationId);
                        updateReservationCmd.Parameters.AddWithValue("@completionDate", DateTime.Now);
                        con.Open();
                        updateReservationCmd.ExecuteNonQuery();
                    }

                    
                    MessageBox.Show($"Book issued to student with ID: {studentId}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static int NumberOfReservationsOnBook(int bookId)
        {
            int reservationCount = 0; 
            try
            {
                using (SqlConnection con = DatabaseConnection.GetConnection())
                {
                    
                    string query = "SELECT COUNT(*) FROM Reservation WHERE BookId = @bookId";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@bookId", bookId); 
                        con.Open();
                        reservationCount = (int)cmd.ExecuteScalar(); 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
            return reservationCount; 
        }

        public static bool HasStudentMadeAReservation(int studentId)
        {
            bool hasReservation = false; 
            try
            {
                using (SqlConnection con = DatabaseConnection.GetConnection())
                {
                    
                    string query = "SELECT COUNT(*) FROM Reservation WHERE StudentId = @studentId";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@studentId", studentId); 
                        con.Open();
                        
                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        
                        hasReservation = count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
            return hasReservation; 
        }

        public static bool ReservationWithBookIdExists(int bookId)
        {
            try
            {
                using (SqlConnection con = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT COUNT(*) FROM Reservation WHERE BookId = @bookId";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@bookId", bookId);

                        con.Open();
                        int count = (int)cmd.ExecuteScalar(); 

                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static int GetStudentIdForBookId(int bookId)
        {
            try
            {
                using (SqlConnection con = DatabaseConnection.GetConnection())
                {
                   
                    string query = "SELECT StudentId FROM Reservation WHERE BookId = @bookid";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@bookid", bookId);

                        con.Open();
                        object result = cmd.ExecuteScalar(); 

                        if (result != null)
                        {
                            return Convert.ToInt32(result); 
                        }
                        else
                        {
                            return -1;
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

        public static int GetReservationIdForStudentAndBook(int studentId, int bookId)
        {
            try
            {
                using (SqlConnection con = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT ReservationId FROM Reservation WHERE StudentId = @studentId AND BookId = @bookId";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@studentId", studentId);
                        cmd.Parameters.AddWithValue("@bookId", bookId);

                        con.Open();
                        object result = cmd.ExecuteScalar(); 

                        if (result != null)
                        {
                            return Convert.ToInt32(result); 
                        }
                        else
                        {
                            return -1; 
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

        public static DataTable GetReservedBooksWithAvailabilityByStudentId(int studentId)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("BookId", typeof(int));
            dt.Columns.Add("BookTitle", typeof(string));
            dt.Columns.Add("AvailableCopies", typeof(int));
            dt.Columns.Add("PickupMessage", typeof(string)); // I am setting up all of the columns in the datatable

            try
            {
                using (SqlConnection con = DatabaseConnection.GetConnection())
                {
                    
                    string query = "SELECT Book.BookId, Book.Title FROM Reservation,Book WHERE Reservation.BookId = Book.BookId AND Reservation.StudentId = @studentId";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@studentId", studentId);
                        con.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int bookId = Convert.ToInt32(reader["BookId"]);
                                string Title = reader["Title"].ToString();

                                Book book = new Book();
                                int numberofcopies = book.NumberofAvailableCopies(bookId);
                                string pickUpMessage;
                                if(numberofcopies> 0)
                                {
                                    pickUpMessage = "Please pick up book from the library";
                                }
                                else
                                {
                                    pickUpMessage = "";
                                }


                                dt.Rows.Add(bookId, Title, numberofcopies, pickUpMessage);
                                
                                

                                
                                
                            }
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

        public static void RemoveCompletionDate(int BookId)
        {
            try
            {
                using (SqlConnection con = DatabaseConnection.GetConnection())
                {
                    string query = "UPDATE Reservation SET CompletionDate = NULL, Status = 'Pending' WHERE BookId = @bookid  AND Status = 'Complete'";
                    

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@bookid", BookId);
                        con.Open();
                        int rows = cmd.ExecuteNonQuery();
                        if (rows == 0)
                        {
                            MessageBox.Show("No record updated");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static int GetReservationId(int studentId, int bookId)
        {
            try
            {
                using (SqlConnection con = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT ReservationId FROM Reservation WHERE StudentId = @studentId AND BookId = @bookId";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@studentId", studentId);
                        cmd.Parameters.AddWithValue("@bookId", bookId);

                        con.Open();
                        var result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            return Convert.ToInt32(result); 
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
