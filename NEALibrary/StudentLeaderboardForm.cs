using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Microcharts.Forms;

namespace NEALibrary
{
    public partial class StudentLeaderboardForm : Form
    {
        private Loan loan;
        public StudentLeaderboardForm()
        {
            InitializeComponent();
            loan = new Loan();
            dateTimePickerInitial.Value = DateTime.Now.AddMonths(-1); // Default one month before
            dateTimePickerFinal.Value = DateTime.Now; // Default todays date
            textBoxUpToPosition.Text = "10"; // Default value
            GetLeaderboardDataTable();
        }

        private void StudentLeaderboardForm_Load(object sender, EventArgs e)
        {

        }

        private void GetLeaderboardDataTable()
        {
            try
            {
                if (IsEmpty())
                {
                    return;
                }
                DataTable leaderboard = loan.GetLeaderboarddata(dateTimePickerInitial.Value, dateTimePickerFinal.Value, Convert.ToInt32(textBoxUpToPosition.Text));
                dataGridViewLeaderboard.DataSource = leaderboard;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private bool IsEmpty()
        {
            if (textBoxUpToPosition == null)
            {
                MessageBox.Show("One or more mandatory fields are empty");
                return true;
            }
            return false;
        }

        private void buttonCheckoutFinal_Click(object sender, EventArgs e)
        {
            try
            {
                if (InvalidPosition(textBoxUpToPosition.Text))
                {
                    return;
                }
                if(System.String.IsNullOrEmpty(textBoxUpToPosition.Text)) 
                {
                    MessageBox.Show("Please enter a position number");
                    return; 
                }
                dataGridViewLeaderboard.DataSource = loan.GetLeaderboarddata(dateTimePickerInitial.Value, dateTimePickerFinal.Value, Convert.ToInt32(textBoxUpToPosition.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

        private bool InvalidPosition(string position)
        {
            try
            {
                int number;
                if (int.TryParse(position, out number) && number >= 0)
                {
                    return false;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Invalid position number");
            return true;

        }
    }
}
