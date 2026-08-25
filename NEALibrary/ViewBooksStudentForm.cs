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
    public partial class ViewBooksStudentForm : Form
    {
        private Book book;
        public ViewBooksStudentForm()
        {
            InitializeComponent();
            book = new Book();
            LoadData();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            LoadData();
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
        private void LoadData()
        {

            

            try
            {
                DataTable dt = book.GetAllStudentBookData(textBoxTitle.Text, textBoxAuthorName.Text, comboBoxAgeGroup.Text, comboBoxGenre.Text, comboBoxFictionStatus.Text);
                dataGridViewBooks.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }






        }
    }
}
