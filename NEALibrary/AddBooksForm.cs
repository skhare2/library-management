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
    public partial class AddBooksForm : Form
    {
        private Book book = new Book();
        private WishList wishList = new WishList();
        public AddBooksForm()
        {
            InitializeComponent();
        }
        public AddBooksForm(string Title, string AuthorName) // If user adds a book from wishlist form then prefills some of the details
        {
            InitializeComponent();
            textBoxUpdateTitle.Text += Title;
            textBoxUpdateAuthorName.Text += AuthorName;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (IsEmpty())
            {
                return;
            }

            try
            {
                int existingbookid = book.GetBookIdIfBookExists(textBoxUpdateTitle.Text, textBoxUpdateAuthorName.Text);
                if (existingbookid > 0)
                {
                    AddCopiesToExistingBook(existingbookid); // If we are adding copies to an existing book we do not want to add another record but update the existing record
                }
                else
                {
                    AddBook(); // This for adding a book which does not have a record
                }
                
                if(wishList.IsBookInWishList(textBoxUpdateTitle.Text, textBoxUpdateAuthorName.Text)) // If the booki is present in the wishlist table then remove it
                {
                    wishList.RemoveBook(textBoxUpdateTitle.Text, textBoxUpdateAuthorName.Text);
                }
                EmptyTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void AddCopiesToExistingBook(int bookid)
        {
            try
            {
                int no_of_copies = book.GetNumberOfCopies(bookid);

                int new_no_of_copies = no_of_copies + Convert.ToInt32(textBoxUpdateNumberOfCopies.Text);
                book.ModifyNumberOfCopies(bookid, new_no_of_copies);

                List<int> copyids = book.AddCopies(bookid, Convert.ToInt32(textBoxUpdateNumberOfCopies.Text));

                if (copyids.Count > 0)
                {
                    StringBuilder message = new StringBuilder();
                    foreach (int copyid in copyids)
                    {
                        message.Append(Convert.ToString(copyid));
                        message.Append(' ');
                    }
                    MessageBox.Show($"New copies added with the following copy ids - {message} ");
                }

            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddBook()
        {
            try
            {
                book.AddBook(textBoxUpdateTitle.Text, Convert.ToInt32(textBoxUpdateNumberOfCopies.Text.ToString()), Math.Round(Convert.ToDouble(textBoxUpdatePrice.Text.ToString()), 2), textBoxUpdateAuthorName.Text, comboBoxUpdateGenre.Text, comboBoxUpdateFictionStatus.Text, comboBoxUpdateAgeGroup.Text);
                int bookid = book.GetDataBookId(textBoxUpdateTitle.Text, Convert.ToInt32(textBoxUpdateNumberOfCopies.Text.ToString()), Convert.ToDouble(textBoxUpdatePrice.Text.ToString()), textBoxUpdateAuthorName.Text, comboBoxUpdateGenre.Text, comboBoxUpdateFictionStatus.Text, comboBoxUpdateAgeGroup.Text);
                List<int> copyids = book.AddCopies(bookid, Convert.ToInt32(textBoxUpdateNumberOfCopies.Text.ToString()));

                if(copyids.Count > 0)
                {
                    StringBuilder message = new StringBuilder();
                    foreach(int copyid in copyids)
                    {
                        message.Append(Convert.ToString(copyid));
                        message.Append(' ');
                    }
                    MessageBox.Show($"Copies added with the following copy ids - {message} ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private bool CheckDoubleValid(string doubletocheck)
        {
            try
            {
                
                string CleanedInput = doubletocheck.Trim();
                if(double.TryParse(CleanedInput, out double price) && price >= 0)
                {
                    string[] divideprice = CleanedInput.Split('.');
                    return divideprice.Length == 1 || divideprice[1].Length <= 2;
                }
                return false;
            }
            catch 
            {
               
                return false;
            }

        }
        private bool CheckIntegerValid(string integertocheck)
        {
            return int.TryParse(integertocheck, out int result) && result >0;
            

        }
        private void EmptyTextBox()
        {
            textBoxUpdateTitle.Text = "";
            textBoxUpdateNumberOfCopies.Text = "";
            textBoxUpdatePrice.Text = "";
            textBoxUpdateAuthorName.Text = "";
            comboBoxUpdateGenre.Text = string.Empty;
            comboBoxUpdateFictionStatus.Text = string.Empty;
            comboBoxUpdateAgeGroup.Text = string.Empty;
        }
        private bool IsEmpty()
        {
            if (String.IsNullOrEmpty(textBoxUpdateTitle.Text))
            {
                MessageBox.Show("Enter Title");
                return true;
            }
            if (String.IsNullOrEmpty(textBoxUpdateNumberOfCopies.Text))
            {
                MessageBox.Show("Enter Number of Copies");
                return true;
            }
            if (!CheckIntegerValid(textBoxUpdateNumberOfCopies.Text))
            {
                MessageBox.Show("Invalid number of copies");
                return true;
            }
            if (String.IsNullOrEmpty(textBoxUpdatePrice.Text))
            {
                MessageBox.Show("Enter Price");
                return true;
            }
            if (!CheckDoubleValid(textBoxUpdatePrice.Text))
            {
                MessageBox.Show("Invalid Price");
                return true;
            }
            if (String.IsNullOrEmpty(textBoxUpdateAuthorName.Text))
            {
                MessageBox.Show("Enter Author Name");
                return true;
            }
            if (String.IsNullOrEmpty(comboBoxUpdateGenre.Text))
            {
                MessageBox.Show("Enter Genre");
                return true;
            }
            if (String.IsNullOrEmpty(comboBoxUpdateFictionStatus.Text))
            {
                MessageBox.Show("Enter if the book is Fiction/Non-fiction");
                return true;
            }
            if (String.IsNullOrEmpty(comboBoxUpdateAgeGroup.Text))
            {
                MessageBox.Show("Enter Age Group");
                return true;
            }
            return false;
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            textBoxUpdatePrice.Text += ".00";
        }
    }
}
