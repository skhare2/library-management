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
    public partial class ViewBooksForm : Form
    {
        private Book book;
        int BookId;

        public ViewBooksForm()
        {
            InitializeComponent();
            book = new Book();
            LoadData();



        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {



            try
            {
                DataTable dt = book.GetAllBookData(textBoxTitle.Text, textBoxAuthorName.Text, comboBoxAgeGroup.Text, comboBoxGenre.Text, comboBoxFictionStatus.Text);
                dataGridViewBooks.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }






        }
        private void MakeWhite()
        {
            if (String.IsNullOrEmpty(textBoxTitle.Text))
            {
                textBoxTitle.Text = "";
            }
            if (String.IsNullOrEmpty(textBoxAuthorName.Text))
            {
                textBoxTitle.Text = "";
            }
            if (String.IsNullOrEmpty(comboBoxAgeGroup.Text))
            {
                textBoxTitle.Text = "";
            }
            if (String.IsNullOrEmpty(comboBoxGenre.Text))
            {
                textBoxTitle.Text = "";
            }
            if (String.IsNullOrEmpty(comboBoxFictionStatus.Text))
            {
                textBoxTitle.Text = "";
            }
        }

        private void dataGridViewBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowindex = e.RowIndex;
                var rowdata = dataGridViewBooks.Rows[rowindex];
                if (rowindex >= 0)
                {

                    textBoxUpdateTitle.Text = rowdata.Cells["Title"].Value.ToString();
                    textBoxUpdateNumberOfCopies.Text = rowdata.Cells["NumberOfCopies"].Value.ToString();
                    textBoxUpdatePrice.Text = rowdata.Cells["Price"].Value.ToString();
                    textBoxUpdateAuthorName.Text = rowdata.Cells["AuthorName"].Value.ToString();
                    comboBoxUpdateGenre.Text = rowdata.Cells["Genre"].Value.ToString();
                    comboBoxUpdateFictionStatus.Text = rowdata.Cells["FictionStatus"].Value.ToString();
                    comboBoxUpdateAgeGroup.Text = rowdata.Cells["AgeGroup"].Value.ToString();
                    BookId = book.GetDataBookId(textBoxUpdateTitle.Text, Convert.ToInt32(textBoxUpdateNumberOfCopies.Text), Convert.ToDouble(textBoxUpdatePrice.Text), textBoxUpdateAuthorName.Text, comboBoxUpdateGenre.Text, comboBoxUpdateFictionStatus.Text, comboBoxUpdateAgeGroup.Text);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsUpdateEmpty())
                {
                    return;
                }
                double price = Convert.ToDouble(textBoxUpdatePrice.Text);
                if (price < 0 || IsPriceDecimalPlacesInvalid(price))
                {
                    MessageBox.Show("Invalid price: Price must be 0 for donations or the price to 2 decimal places");
                    return;
                }
                
                book.EditBookDetail(textBoxUpdateTitle.Text, Convert.ToInt32(textBoxUpdateNumberOfCopies.Text), Convert.ToDouble(textBoxUpdatePrice.Text), textBoxUpdateAuthorName.Text, comboBoxUpdateGenre.Text, comboBoxUpdateFictionStatus.Text, comboBoxUpdateAgeGroup.Text, BookId);
                LoadData();
                ClearTextBoxUpdate();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private bool IsUpdateEmpty()
        {
            if (String.IsNullOrEmpty(textBoxUpdateTitle.Text) || String.IsNullOrEmpty(textBoxUpdateNumberOfCopies.Text) || String.IsNullOrEmpty(textBoxUpdatePrice.Text) || String.IsNullOrEmpty(textBoxUpdateAuthorName.Text) || String.IsNullOrEmpty(comboBoxUpdateGenre.Text) || String.IsNullOrEmpty(comboBoxUpdateFictionStatus.Text) || String.IsNullOrEmpty(comboBoxUpdateAgeGroup.Text))
            {
                MessageBox.Show("One or more mandatory field blank");
                return true;
            }
            return false;
        }
            
        private void ClearTextBoxUpdate()
        {
            textBoxUpdateTitle.Text = "";
            textBoxUpdateNumberOfCopies.Text = "";
            textBoxUpdatePrice.Text = "";
            textBoxUpdateAuthorName.Text = "";
            comboBoxUpdateGenre.Text = "";
            comboBoxUpdateFictionStatus.Text = "";
            comboBoxUpdateAgeGroup.Text = "";
        }
        
        private bool IsPriceDecimalPlacesInvalid(double price)
        {
            
            return Double.Round(price, 2) != price; // Any number with or more than 3dp is not allowed

        }

    }
}
