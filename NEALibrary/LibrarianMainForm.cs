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
    public partial class LibrarianMainForm : Form
    {
        public LibrarianMainForm()
        {
            InitializeComponent();
            Invisible();
            ShouldbuttonLibrarianManagementExist();


        }
        private void Invisible()
        {

            buttonViewEditBooks.Visible = false;
            buttonAddBooks.Visible = false;
            buttonLateFee.Visible = false;
            buttonLibrarianManagement.Visible = false;
            buttonRemoveCopy.Visible = false;
        }



        private void buttonViewEditBooks_Click(object sender, EventArgs e)
        {
            ViewBooksForm frm = new ViewBooksForm();
            frm.ShowDialog();
        }

        private void buttonBooks_Click_1(object sender, EventArgs e)
        {
            buttonViewEditBooks.Visible = !buttonViewEditBooks.Visible;
            buttonAddBooks.Visible = !buttonAddBooks.Visible;
            buttonRemoveCopy.Visible = !buttonRemoveCopy.Visible;
        }

        private void buttonAddBooks_Click(object sender, EventArgs e)
        {
            AddBooksForm frm = new AddBooksForm();
            frm.ShowDialog();
        }

        private void buttonIssueBooks_Click(object sender, EventArgs e)
        {
            IssueBooksForm frm = new IssueBooksForm();
            frm.ShowDialog();
        }

        private void buttonLendBooks_Click(object sender, EventArgs e)
        {
            LendBooksForm lendBooksForm = new LendBooksForm();
            lendBooksForm.ShowDialog();
        }

        private void buttonLibrarySetting_Click(object sender, EventArgs e)
        {
            buttonLateFee.Visible = !buttonLateFee.Visible;
            buttonLibrarianManagement.Visible = !buttonLibrarianManagement.Visible;
        }

        private void buttonLateFee_Click(object sender, EventArgs e)
        {

            ChangeLateFeeForm changeLateFeeForm = new ChangeLateFeeForm();
            changeLateFeeForm.ShowDialog();

        }

        private void buttonAddLibrarian_Click(object sender, EventArgs e)
        {
            LibrarianForm librarianForm = new LibrarianForm();
            librarianForm.ShowDialog();
        }

        private void ShouldbuttonLibrarianManagementExist()
        {
            int librarianid = Program.user.GetUserId();
            if (!Librarian.GetIsAdmin(librarianid))
            {

                buttonLibrarianManagement.Enabled = false;
            }
        }

        

        private void buttonWishlist_Click(object sender, EventArgs e)
        {
            WishListForm wishListForm = new WishListForm();
            wishListForm.ShowDialog();
        }

        

        private void buttonLibrarianManagement_Click(object sender, EventArgs e)
        {
            LibrarianForm librarianForm = new LibrarianForm();
            librarianForm.ShowDialog();
        }

        private void buttonRemoveCopy_Click(object sender, EventArgs e)
        {
            RemoveCopy removeCopy = new RemoveCopy();
            removeCopy.ShowDialog();
        }

        private void buttonLeaderboard_Click_1(object sender, EventArgs e)
        {
            StudentLeaderboardForm studentLeaderboardForm = new StudentLeaderboardForm();
            studentLeaderboardForm.ShowDialog();
        }
    }
}
