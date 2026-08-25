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
    public partial class StudentWishlistForm : Form
    {
        private Book book;
        private WishList wishlist;
        
        public StudentWishlistForm()
        {
            InitializeComponent();
            book = new Book();
            wishlist = new WishList();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (DoesBookExist())
                {
                    MessageBox.Show("The book is owned by the library - cannot request a book the library owns");
                    return;
                }
                if (IsEmpty())
                {
                    return;
                }
                string isbn_without_dashes = textBoxISBN.Text.Replace("-", "").Replace(" ", "");
                try
                {
                    wishlist.SetIsbn(Convert.ToInt64(isbn_without_dashes));
                }
                
                catch (FormatException)
                {
                    MessageBox.Show("ISBN of invalid format - ISBN should only contain numeric charachters and/or dashes");
                    return;
                }
                if (!wishlist.ISBNValidLength())
                {
                    MessageBox.Show("Invalid ISBN. ISBN should be 13 digits.");
                    return;
                }
                if (!wishlist.ValidISBN())
                {
                    MessageBox.Show("Invalid ISBN check digit. Please try again");
                    return;
                }
                wishlist.AddWish(Program.user.GetUserId(), textBoxTitle.Text.ToString(), textBoxAuthorName.Text.ToString());
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            

        }
        private bool IsEmpty()
        {
            if(String.IsNullOrEmpty(textBoxTitle.Text) || String.IsNullOrEmpty(textBoxAuthorName.Text) || String.IsNullOrEmpty(textBoxISBN.Text))
            {
                MessageBox.Show("One or more mandatory fields are empty");
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool DoesBookExist()
        {

            int records = book.DoesBookExist(textBoxTitle.Text, textBoxAuthorName.Text);
            if (records > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
