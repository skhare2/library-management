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
    public partial class WishListForm : Form
    {
        private WishList wishlist;
        public WishListForm()
        {
            InitializeComponent();
            wishlist = new WishList();
            LoadData();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            LoadData();  // The SQL query in the load data function can be used for empty or full textboxes
        }

        private void LoadData()  // Calls a method in the wishlist class for the datatabale and makes that the source of the datagrid view
        {



            try
            {
                DataTable dt = wishlist.GetAllWishListData(textBoxStudentId.Text, textBoxTitle.Text, textBoxISBN13.Text, textBoxNoOfRequests.Text, textBoxAuthorName.Text);
                dataGridViewBooks.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }






        }

        private void dataGridViewBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        { // Once a row is clicked it displays it in the textboxes below
            try
            {
                int rowindex = e.RowIndex;
                var rowdata = dataGridViewBooks.Rows[rowindex];
                if (rowindex >= 0)
                {

                    textBoxWishListStudentId.Text = rowdata.Cells["StudentId"].Value.ToString();
                    textBoxWishListTitle.Text = rowdata.Cells["Title"].Value.ToString();
                    textBoxWishListISBN13.Text = rowdata.Cells["ISBN13"].Value.ToString();
                    textBoxWishListNoOfRequests.Text = rowdata.Cells["No_Of_Requests"].Value.ToString();
                    textBoxWishListAuthorName.Text = rowdata.Cells["AuthorName"].Value.ToString();


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAddBook_Click(object sender, EventArgs e) // Takes user to the addbooks form where some of the details are prefilled
        {
            if (!IsEmpty())
            {
                this.Visible = false;
                AddBooksForm addBooksForm = new AddBooksForm(textBoxWishListTitle.Text, textBoxWishListAuthorName.Text);
                addBooksForm.ShowDialog();
            }
            else
            {

                return;
            }

        }

        private void buttonRemove_Click(object sender, EventArgs e) // Calls remove method in wishlist class to remove book from wishlist table
        {
            try
            {
                if (IsEmpty())
                {
                    return;
                }
                wishlist.RemoveBook(textBoxWishListTitle.Text, textBoxWishListAuthorName.Text);
                LoadData();
                EmptyWishListTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private bool IsEmpty() // Checks if textboxes for selecting a book are empty
        {
            if (String.IsNullOrEmpty(textBoxWishListISBN13.Text) || String.IsNullOrEmpty(textBoxWishListTitle.Text) || String.IsNullOrEmpty(textBoxWishListAuthorName.Text) || String.IsNullOrEmpty(textBoxWishListStudentId.Text) || String.IsNullOrEmpty(textBoxWishListNoOfRequests.Text))
            {
                MessageBox.Show("One or more mandatory field not filled");
                return true;
            }
            return false;
        }
        private void EmptyWishListTextBox()
        {
            textBoxWishListStudentId.Text = null;
            textBoxWishListTitle.Text = null;
            textBoxWishListISBN13.Text = null;
            textBoxWishListNoOfRequests.Text = null;
            textBoxWishListAuthorName.Text = null;
        }

        private void WishListForm_Load(object sender, EventArgs e)
        {

        }
    }
}
