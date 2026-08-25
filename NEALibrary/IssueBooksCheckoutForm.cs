using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEALibrary
{
    public partial class IssueBooksCheckoutForm : Form
    {
        private int StudentId;

        private List<int> CopyID;
        private List<int> ReservedCopyId;
        
        public IssueBooksCheckoutForm(int studentid, List<int> copyid, List<int> reservedcopyid)
        {
            StudentId = studentid;
            CopyID = copyid;
            ReservedCopyId = reservedcopyid;
            InitializeComponent();
            dateTimePickerIssueDate.Value = DateTime.Now;
            LibrarySetting setting = new LibrarySetting(); // Instead of hardcoding a value the librarian can flexibly change duedatetimespan value in the library setting
            dateTimePickerDueDate.Value = DateTime.Now.AddDays(Convert.ToDouble(setting.GetSettingValue("DueDateTimeSpan")));
        }

        private void panelCheckout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonCheckoutFinal_Click(object sender, EventArgs e)
        {
            try
            {
                var IssueDate = dateTimePickerIssueDate.Value.Date;
                var DueDate = dateTimePickerDueDate.Value.Date;

                if (DueDate < IssueDate)
                {
                    MessageBox.Show("Invalid date - The due date cannot be before the issue date");
                    return;
                }
                var CurrentTime = DateTime.Now.TimeOfDay;
                DateTime CombinedTime = IssueDate.Add(CurrentTime);
                Loan loan = new Loan(Program.user.GetUserId(), StudentId, CombinedTime);
                loan.AddLoan();
                int LoanId = loan.GetLoanId();
                BookLoaned bookLoaned = new BookLoaned(LoanId, CopyID, dateTimePickerDueDate.Value);
                bookLoaned.AddBooksLoaned();
                MessageBox.Show("Loan added");
                if(ReservedCopyId.Count > 0 )
                {
                    int reservationid = Reservation.GetReservationIdForStudentAndBook(StudentId, Book.GetBookIdByCopyId(CopyID[0]));
                    Reservation.RemoveReservation(reservationid);
                }
                
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
