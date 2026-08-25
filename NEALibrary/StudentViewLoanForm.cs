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
    public partial class StudentViewLoanForm : Form
    {
        private Book book;
        private DataTable dtTitle;
        private LibrarySetting librarysetting;
        public StudentViewLoanForm()
        {
            book = new Book();
            librarysetting = new LibrarySetting();
            InitializeComponent();
            dtTitle = new DataTable();
            DisplayLoanDetails();
            DisplayLateFees();
        }

        private void dataGridViewLoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DisplayLateFees() 
        {
            try
            {
                double latefeeperday = Convert.ToDouble(librarysetting.GetSettingValue("DailyLateFee"));
                Loan loan = new Loan(Program.user.GetUserId());
                textBoxLateFee.Text = Math.Round(loan.GetTotalLoanLateFees(latefeeperday),2).ToString();
                

                 
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

            
        }
        private void DisplayLoanDetails()
        {
            try
            {
                Loan loan = new Loan(Program.user.GetUserId());
                DataTable dt = loan.GetDisplayLoanDetails();
                List<int> CopyIdList = new List<int>();
                List<string> TitleList = new List<string>();
                foreach (DataRow row in dt.Rows)
                {
                    int copyid = Convert.ToInt32(row["CopyId"].ToString());
                    CopyIdList.Add(copyid);
                    TitleList.Add(book.GetCopyBookTitle(copyid));

                }
                dtTitle.Columns.Clear();
                dtTitle.Rows.Clear();

                dtTitle.Columns.Add("Title", typeof(string));

                foreach (DataColumn Loancolumn in dt.Columns)
                {
                    dtTitle.Columns.Add(Loancolumn.ColumnName, Loancolumn.DataType);
                }
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow newrow = dtTitle.NewRow();
                    newrow["Title"] = TitleList[i];
                    foreach (DataColumn column in dt.Columns)
                    {
                        newrow[column.ColumnName] = dt.Rows[i][column];
                    }
                    dtTitle.Rows.Add(newrow);
                }
                dataGridViewLoan.DataSource = dtTitle;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void StudentViewLoanForm_Load(object sender, EventArgs e)
        {

        }
    }
}
