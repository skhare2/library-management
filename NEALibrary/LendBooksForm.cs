using Microsoft.IdentityModel.Tokens;
using ScottPlot.Finance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEALibrary
{
    public partial class LendBooksForm : Form
    {
        private int StudentId;
        private Book book;

        private StaticStack<int> CopyIds;
        private StaticStack<DateTime> DueDates;

        private DataTable dtTitle;
        private int rowindex = -1;
        public LendBooksForm()
        {
            InitializeComponent();
            panelStudentLoan.Enabled = false;
            panelStudentLoan.Visible = false;
            book = new Book();
            dtTitle = new DataTable();

            CopyIds = new StaticStack<int>(100);
            DueDates = new StaticStack<DateTime>(100);
            IsButtonRemoveVisible();


        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckEmpty())
                {
                    return;
                }
                if (CheckStudentExists())
                {
                    GetStudentId();


                    MessageBox.Show("Student Exists");
                    panelStudentDetail.Enabled = false;
                    panelStudentDetail.Visible = false;

                    panelStudentLoan.Enabled = true;
                    panelStudentLoan.Visible = true;
                    DisplayLoanDetails();
                }
                else
                {
                    MessageBox.Show("Student does not exist");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool CheckEmpty()
        {
            if (String.IsNullOrEmpty(textBoxUsername.Text.ToString()))
            {
                MessageBox.Show("Username empty");
                return true;
            }
            if (String.IsNullOrEmpty(textBoxFirstName.Text.ToString()) || String.IsNullOrEmpty(textBoxLastName.Text.ToString()))
            {
                MessageBox.Show("Firstname/Lastname empty");
                return true;
            }
            return false;
        }
        private bool CheckStudentExists()
        {
            return Student.CheckStudentExists(textBoxUsername.Text.ToString(), textBoxFirstName.Text.ToString(), textBoxLastName.Text.ToString());
        }
        private void GetStudentId()
        {
            StudentId = Student.GetStudentId(textBoxUsername.Text.ToString(), textBoxFirstName.Text.ToString(), textBoxLastName.Text.ToString());
        }
        private void DisplayLoanDetails()
        {
            try
            {
                Loan loan = new Loan(StudentId);
                DataTable dt = loan.GetDisplayLoanDetails();
                List<int> CopyIdList = new List<int>();
                List<string> TitleList = new List<string>();
                List<bool> ReservationStatusList = new List<bool>();
                foreach (DataRow row in dt.Rows)
                {
                    int copyid = Convert.ToInt32(row["CopyId"].ToString());
                    CopyIdList.Add(copyid);
                    TitleList.Add(book.GetCopyBookTitle(copyid));

                    bool IsReserved = Reservation.IsBookReserved(copyid);
                    ReservationStatusList.Add(IsReserved);

                }
                dtTitle.Columns.Clear();
                dtTitle.Rows.Clear();

                dtTitle.Columns.Add("Title", typeof(string));
                dtTitle.Columns.Add("Reserved", typeof(bool));

                foreach (DataColumn Loancolumn in dt.Columns)
                {
                    dtTitle.Columns.Add(Loancolumn.ColumnName, Loancolumn.DataType);
                }
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow newrow = dtTitle.NewRow();
                    newrow["Title"] = TitleList[i];
                    newrow["Reserved"] = ReservationStatusList[i];
                    foreach (DataColumn column in dt.Columns)
                    {
                        newrow[column.ColumnName] = dt.Rows[i][column];
                    }
                    dtTitle.Rows.Add(newrow);
                }
                dataGridViewLoan.DataSource = dtTitle;

                // Hihglighting reserved rows
                foreach (DataGridViewRow row in dataGridViewLoan.Rows)
                {
                    bool IsReserved = Convert.ToBoolean(row.Cells["Reserved"].Value);
                    if (IsReserved)
                    {
                        row.DefaultCellStyle.BackColor = Color.LightYellow;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridViewLoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                rowindex = e.RowIndex;
                var rowdata = dataGridViewLoan.Rows[rowindex];
                if (rowindex >= 0)
                {

                    textBoxTitle.Text = rowdata.Cells["Title"].Value.ToString();
                    textBoxCopyId.Text = rowdata.Cells["CopyId"].Value.ToString();
                    textBoxDueDate.Text = Convert.ToDateTime(rowdata.Cells["DueDate"].Value.ToString()).Date.ToString("dd/MM/yyyy");


                }
            }
            catch
            {

                MessageBox.Show("Please select a valid row");
            }
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedrowToReturn = dataGridViewLoan.Rows[rowindex];
                if (selectedrowToReturn.DefaultCellStyle.BackColor == Color.Red)
                {
                    MessageBox.Show("Book already returned");
                    return;
                }
                if (String.IsNullOrEmpty(textBoxCopyId.Text) || rowindex == -1)
                {
                    MessageBox.Show("No book selected");
                    return;
                }
                DataRow rowToReturn = dtTitle.Rows[rowindex];


                CopyIds.Push(Convert.ToInt32(dataGridViewLoan.Rows[rowindex].Cells["CopyId"].Value.ToString()));
                DueDates.Push(Convert.ToDateTime(dataGridViewLoan.Rows[rowindex].Cells["DueDate"].Value.ToString()));
                //dtTitle.Rows.Remove(rowToReturn);

                selectedrowToReturn.DefaultCellStyle.BackColor = Color.Red;

                textBoxCopyId.Text = "";
                textBoxTitle.Text = "";
                textBoxDueDate.Text = "";


                IsButtonRemoveVisible();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void IsButtonRemoveVisible()
        {
            if (CopyIds.GetSize() > 0 && DueDates.GetSize() > 0)
            {
                buttonRemoveReturn.Enabled = true;
            }
            else
            {
                buttonRemoveReturn.Enabled = false;
            }
        }

        private void buttonRemoveReturn_Click(object sender, EventArgs e)
        {
            try
            {

                if (CopyIds.GetSize() > 0 && DueDates.GetSize() > 0)
                {
                    int CopyId = CopyIds.Pop();
                    DateTime DueDate = DueDates.Pop();

                    foreach (DataGridViewRow row in dataGridViewLoan.Rows)
                    {
                        int rowCopyId = Convert.ToInt32(row.Cells["CopyId"].Value);
                        DateTime rowDueDate = Convert.ToDateTime(row.Cells["DueDate"].Value);
                        if (rowCopyId == CopyId && rowDueDate == DueDate)
                        {
                            bool isReserved = Reservation.IsBookReserved(rowCopyId);
                            if (isReserved)
                            {
                                row.DefaultCellStyle.BackColor = Color.LightYellow; // If the book is reserved the colour must be yellow again
                            }
                            else
                            {
                                row.DefaultCellStyle.BackColor = Color.White; // Otherwise white is the colour for books without any reservations
                            }

                        }
                    }

                }
                IsButtonRemoveVisible();




            }


            catch (Exception ex)
            {
                if (ex.Message.Contains("Index was out of range"))
                {
                    MessageBox.Show("Please select a valid row");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }

            }

        }

        private void buttonSubmitCheckIN_Click(object sender, EventArgs e)
        {
            try
            {
                if (CopyIds.IsEmpty())
                {
                    MessageBox.Show("No book copies selected");
                    return;
                }

                LibrarySetting setting = new LibrarySetting();
                double DailyLateFee = Convert.ToDouble(setting.GetSettingValue("DailyLateFee"));
                Loan loan = new Loan(StudentId);
                double latefee = loan.CalculateLateFeesForBooks(CopyIds.GetList(), DueDates.GetList(), DailyLateFee);
                if (MessageBox.Show($"The late fees for the returned books are {Math.Round(latefee, 2)}. Please accept the payment and click Yes to continue or No to remain", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                { // If yes is clicked

                    DoCheckIn();


                    MessageBox.Show("Return Complete");
                    this.Close();
                }
                else
                {
                    return; // If the user clicks No, the program does not return the books
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DoCheckIn()
        {
            List<int> copyIds = CopyIds.GetList();

            for (int i = 0; i < copyIds.Count; i++)
            {
                int copyId = copyIds[i];
                //MessageBox.Show($"The copyid is {copyId}");
                BookLoaned.RemoveLoan(CopyIds.Pop(), DueDates.Pop());

                if (Reservation.IsBookReserved(copyId)) // This to mark reservation as complete and add a date
                {
                    Reservation.MarkReservationAsComplete(copyId); // Will mark a reservation as comple if the completiondate is null
                }
            }



        }
        private void UpdateReservationStatusToComplete(List<int> CopyIdsNew)
        {
            foreach (int copyId in CopyIdsNew)
            {
                Reservation.MarkReservationAsComplete(copyId); // Reservation status to "Complete" for each book
            }
        }

        private void panelStudentLoan_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
