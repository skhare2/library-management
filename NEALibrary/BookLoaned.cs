using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NEALibrary
{
    public class BookLoaned
    {
        
        private int LoanId;
        private List<int> CopyId; // Operations on multiple books
        private int? SingleCopyId; // Operation with a specific instance
        private DateTime DueDate;
        private DateTime? ReturnDate; // Can be DateTime or null

        public BookLoaned(int loanid, List<int> copyid, DateTime duedate)
        {
            LoanId = loanid;
            CopyId = copyid;
            DueDate = duedate;
            ReturnDate = null;
        }
        public BookLoaned(int copyId, DateTime dueDate, DateTime? returnDate = null) // Constructor for late fee calcuation
        {
            SingleCopyId = copyId; 
            DueDate = dueDate;
            ReturnDate = returnDate; // Set to null by the constructor
        }
        public void AddBooksLoaned()
        {
            for (int i = 0; i < CopyId.Count; i++)
            {
                try
                {
                    using (SqlConnection con = DatabaseConnection.GetConnection())
                    {
                        string query = "INSERT INTO BookLoaned (LoanId, CopyId, DueDate) Values (@loanid, @copyid, @duedate)";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@loanid", LoanId);
                            cmd.Parameters.AddWithValue("@copyid", CopyId[i]);
                            cmd.Parameters.AddWithValue("@duedate", DueDate);
                            

                            con.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }


                    using (SqlConnection con = DatabaseConnection.GetConnection())
                    {
                        string query = "UPDATE BookCopy SET Status = @status WHERE CopyId = @copyid";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@status", "Lent");
                            cmd.Parameters.AddWithValue("@copyid", CopyId[i]);
                            
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
        }
        
        public static void RemoveLoan(int CopyId, DateTime DueDate)
        {
            try
            {
                using (SqlConnection con = DatabaseConnection.GetConnection())
                {
                    string query = "UPDATE BookLoaned SET ReturnDate = @returndate WHERE CopyId = @copyid AND DueDate = @duedate AND ReturnDate IS NULL";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@returndate", DateTime.Now);
                        cmd.Parameters.AddWithValue("@copyid", CopyId);
                        cmd.Parameters.AddWithValue("@duedate", DueDate);


                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                using (SqlConnection con = DatabaseConnection.GetConnection())
                {
                    string query = "UPDATE BookCopy SET Status = @status WHERE CopyId = @copyid";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@status", "Available");
                        cmd.Parameters.AddWithValue("@copyid", CopyId);

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

        public double CalculateLateFee(double DailyLateFee) // Late Fee for each book, used by GetTotalLoanLateFees method in loan class
        {
            if(ReturnDate == null && DueDate < DateTime.Now)
            {
                int days = (DateTime.Now - DueDate).Days;

                return days * DailyLateFee;
            }
            return 0;
        }


    }
}
