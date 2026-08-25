using Microcharts.Forms;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScottPlot;
namespace NEALibrary
{
    public class Loan
    {
        
        private int LibrarianId;
        private int StudentId;
        private DateTime IssueDate;
        private Plot plt;
        public Loan(int librarianid, int studentid, DateTime issuedate) 
        {
            
            LibrarianId = librarianid;
            StudentId = studentid;
            IssueDate = issuedate;
        }

        public Loan(int studentid)
        {
            StudentId=studentid;
        }
        public Loan()
        {
            //LibrarianForm librarianForm = new LibrarianForm();
            //librarianForm.ShowDialog();
        }

        public void AddLoan()
        {
            try
            {
                using (SqlConnection con = DatabaseConnection.GetConnection())
                {
                    string query = "INSERT INTO Loan Values (@librarianid, @studentid, @issuedate)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@librarianid", LibrarianId);
                        cmd.Parameters.AddWithValue("@studentid", StudentId);
                        cmd.Parameters.AddWithValue("@issuedate", IssueDate);
                        

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

        public int GetLoanId()
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection con = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT LoanId FROM Loan WHERE LibrarianId = @librarianid AND StudentId = studentid AND IssueDate = @issuedate";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@librarianid", LibrarianId);
                        cmd.Parameters.AddWithValue("@studentid", StudentId);
                        cmd.Parameters.AddWithValue("@issuedate", IssueDate);
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd)) 
                        {
                            da.Fill(dt);
                            DataRow dr = dt.Rows[0];
                            return Convert.ToInt32(dr["LoanId"].ToString());
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

        public DataTable GetDisplayLoanDetails()
        {
            DataTable dt = new DataTable();
            try
            {
                //DataTable dt = new DataTable();
                using (SqlConnection con = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT CopyId, DueDate FROM BookLoaned,Loan WHERE Loan.StudentID = @studentid AND Loan.LoanId = BookLoaned.LoanId AND ReturnDate IS NULL";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@studentid", StudentId);
                        
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd)) 
                        {
                            da.Fill(dt);
                            
                            return dt;
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
        public double GetTotalLoanLateFees(double DailyLateFee) // Returns total late fees for all overdue books not just books being returned
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = DatabaseConnection.GetConnection())
                {
                    
                    string query = "SELECT CopyId, DueDate, ReturnDate FROM BookLoaned, Loan WHERE Loan.StudentID = @studentid AND Loan.LoanId = BookLoaned.LoanId AND BookLoaned.ReturnDate IS NULL";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@studentid", StudentId);

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

            double latefeessum = 0;

            foreach (DataRow row in dt.Rows)
            {
                int CopyId = Convert.ToInt32(row["CopyId"]);
                DateTime DueDate = Convert.ToDateTime(row["DueDate"]);
                DateTime? ReturnDate;
                if (row.IsNull("ReturnDate"))
                {
                    ReturnDate = null;
                }
                else
                {
                    ReturnDate = Convert.ToDateTime(row["ReturnDate"]);
                }
                BookLoaned bookloaned = new BookLoaned(CopyId, DueDate, ReturnDate); // Calculates late fee for individual book
                latefeessum += bookloaned.CalculateLateFee(DailyLateFee);
            }
                
            return latefeessum;
        }

        public double CalculateLateFeesForBooks(List<int> CopyIds, List<DateTime> DueDates, double DailyLateFee) // This is a method not for all books overdue but for certain selected ones
        {
            double latefeessum = 0;

            for (int i = 0; i < CopyIds.Count; i++)
            {
                BookLoaned bookLoaned = new BookLoaned(CopyIds[i], DueDates[i]);
                latefeessum += bookLoaned.CalculateLateFee(DailyLateFee);

            }
            return latefeessum;
        }

        public DataTable GetLeaderboarddata(DateTime InitialDate, DateTime FinalDate, int UpToPosition)
        {
            DataTable Leaderboard = new DataTable();
            try
            {
                

                using (SqlConnection con = DatabaseConnection.GetConnection())
                {
                    string query = @"SELECT Student.FirstName, Student.LastName, Loan.StudentId, COUNT(CopyId) AS TotalBooks 
                                    FROM Loan,BookLoaned,Student 
                                    WHERE Loan.LoanId = BookLoaned.LoanID
                                    AND Loan.StudentId = Student.StudentId
                                    AND (Loan.IssueDate BETWEEN @initialdate AND @finaldate
                                    OR BookLoaned.ReturnDate BETWEEN @initialdate AND @finaldate)
                                    GROUP BY Student.FirstName, Student.LastName, Loan.StudentId
                                    ORDER BY TotalBooks DESC
                                    OFFSET 0 ROWS
                                    FETCH NEXT @number ROWS ONLY";
                    // AS names the column in the datagridview
                    // If the book is loaned or returned in the given timeframe it counts
                    // Group by allows the total count of books to be calculated
                    // OFFSET and FETCH clause starts from row 0 to the given row
                    // I cannot be given credit for the OFFSET FETCH or the GROUP BY as I utilised the help of online sources which are referenced
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@initialdate", InitialDate);
                        cmd.Parameters.AddWithValue("@finaldate", FinalDate);
                        cmd.Parameters.AddWithValue("@number", UpToPosition);

                        using(SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(Leaderboard);
                        }
                    }
                }
                return Leaderboard;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return Leaderboard;
            }
            

        }

        


    }
}
