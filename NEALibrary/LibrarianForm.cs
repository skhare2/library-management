using Microsoft.IdentityModel.Tokens;
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
    public partial class LibrarianForm : Form
    {
        private int rowindex = -1;

        public LibrarianForm()
        {
            InitializeComponent();

            LoadData();
            labelPassword.Visible = false;
            textBoxEditPassword.Visible = false;
            buttonNewPassword.Visible = false;
        }

        private void LibrarianForm_Load(object sender, EventArgs e)
        {

        }
        private void LoadData()
        {
            dataGridViewLibrarian.DataSource = Librarian.GetLibrarianData();
        }

        private void dataGridViewLibrarian_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                rowindex = e.RowIndex;
                var rowdata = dataGridViewLibrarian.Rows[rowindex];
                if (rowindex >= 0)
                {

                    textBoxEditFirstName.Text = rowdata.Cells["FirstName"].Value.ToString();
                    textBoxEditLastName.Text = rowdata.Cells["LastName"].Value.ToString();
                    dateTimePickerEditDOB.Value = Convert.ToDateTime(rowdata.Cells["DOB"].Value.ToString());
                    textBoxEditUsername.Text = rowdata.Cells["Username"].Value.ToString();
                    textBoxEditEmail.Text = rowdata.Cells["Email"].Value.ToString();
                    comboBoxEditAdmin.Text = rowdata.Cells["IsAdmin"].Value.ToString();


                }
            }
            catch
            {

                MessageBox.Show("Please select a valid row");
                ClearEditTextBox();

            }
        }
        private void ClearEditTextBox()
        {
            textBoxEditFirstName.Text = "";
            textBoxEditLastName.Text = "";
            dateTimePickerEditDOB.Text = "";
            textBoxEditUsername.Text = "";
            textBoxEditEmail.Text = "";
            comboBoxEditAdmin.Text = "";
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (AddIsEmpty())
            {
                return;
            }
            Librarian.AddLibrarian(textBoxFirstName.Text, textBoxLastName.Text, dateTimePickerDOB.Value, textBoxUsername.Text, textBoxPassword.Text, textBoxEmail.Text, comboBoxAdmin.Text);
            LoadData();
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            dateTimePickerDOB.Text = "";
            textBoxUsername.Text = "";
            textBoxEmail.Text = "";
            comboBoxAdmin.Text = "";
            textBoxPassword.Text = "";
        }

        private bool AddIsEmpty()
        {
            if (String.IsNullOrEmpty(textBoxFirstName.Text) || String.IsNullOrEmpty(textBoxLastName.Text) || String.IsNullOrEmpty(textBoxUsername.Text) || String.IsNullOrEmpty(textBoxPassword.Text) || String.IsNullOrEmpty(textBoxEmail.Text) || String.IsNullOrEmpty(comboBoxAdmin.Text))
            {
                MessageBox.Show("One or more mandatory columns are empty");
                return true;
            }
            return false;
        }

        private bool EditIsEmpty()
        {
            if (String.IsNullOrEmpty(textBoxEditFirstName.Text) || String.IsNullOrEmpty(textBoxEditLastName.Text) || String.IsNullOrEmpty(textBoxEditUsername.Text) || String.IsNullOrEmpty(textBoxEditEmail.Text) || String.IsNullOrEmpty(comboBoxEditAdmin.Text))
            {
                MessageBox.Show("One or more mandatory columns are empty");
                return true;
            }
            return false;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (EditIsEmpty())
                {
                    return;
                }

                Librarian.EditLibrarianDetails(textBoxEditFirstName.Text, textBoxEditLastName.Text, dateTimePickerEditDOB.Value, textBoxEditUsername.Text, textBoxEditEmail.Text, comboBoxEditAdmin.Text);
                ClearEditTextBox();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (EditIsEmpty())
            {
                return;
            }
            labelPassword.Visible = !labelPassword.Visible;
            textBoxEditPassword.Visible = !textBoxEditPassword.Visible;
            buttonNewPassword.Visible = !buttonNewPassword.Visible;

        }

        private void buttonNewPassword_Click(object sender, EventArgs e)
        {
            if (EditIsEmpty())
            {
                return;
            }
            if (String.IsNullOrEmpty(textBoxEditPassword.Text))
            {
                MessageBox.Show("Enter new password");
                return;
            }
            Librarian.UpdatePassword(textBoxEditUsername.Text, textBoxEditEmail.Text, textBoxEditPassword.Text);
            LoadData();
            ClearEditTextBox();
            textBoxEditPassword.Text = "";
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (EditIsEmpty())
            {
                return;
            }
            Librarian.RemoveLibrarian(textBoxEditUsername.Text, textBoxEditEmail.Text);
            LoadData();
            ClearEditTextBox();

        }
    }
}
