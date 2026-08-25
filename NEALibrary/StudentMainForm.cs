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
    public partial class StudentMainForm : Form
    {
        public StudentMainForm()
        {
            InitializeComponent();
            Invisible();
            
        }

        private void buttonBooks_Click(object sender, EventArgs e)
        {
            buttonViewBooks.Visible = !buttonViewBooks.Visible;
            buttonViewLoan.Visible = !buttonViewLoan.Visible;
        }

        private void Invisible()
        {
            buttonViewBooks.Visible = false;
            buttonViewLoan.Visible = false;
        }



        private void buttonViewBooks_Click_1(object sender, EventArgs e)
        {
            ViewBooksStudentForm studentForm = new ViewBooksStudentForm();
            studentForm.ShowDialog();
        }

        private void buttonReservation_Click(object sender, EventArgs e)
        {
            StudentReservationForm studentReservationForm = new StudentReservationForm();
            studentReservationForm.ShowDialog();

        }

        private void buttonWishList_Click(object sender, EventArgs e)
        {
            StudentWishlistForm swf = new StudentWishlistForm();
            swf.ShowDialog();
        }

        private void buttonViewLoan_Click(object sender, EventArgs e)
        {
            StudentViewLoanForm studentViewLoanForm = new StudentViewLoanForm();
            studentViewLoanForm.ShowDialog();
        }

        private void buttonViewCompletedReservation_Click(object sender, EventArgs e)
        {
            ViewCompletedReservationForm viewCompletedReservationForm = new ViewCompletedReservationForm();
            viewCompletedReservationForm.ShowDialog();
        }

        
    }
}
