using Microsoft.Data.SqlClient;
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
    public partial class AddStudentForm : Form
    {
        
        private SqlConnection con = DatabaseConnection.GetConnection();
        
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            if (CheckEmpty() || IsPasswordNotMatching())
            {
                return;
            }
            Student student = new Student(textBoxFirstName.Text, textBoxLastName.Text, Convert.ToDateTime(dateTimePickerDOB.Value.ToString()), textBoxUsername.Text, SHA256Hasher.CalculateHash(textBoxPassword.Text), textBoxEmail.Text);

            if (student.CheckStudent() || !student.ValidEmail() || !student.ValidUsername())
            {
                
                return;
            }
            try
            {
                
                this.Close();
                AddStudentCodeForm addStudentCodeForm = new AddStudentCodeForm(student);
                addStudentCodeForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            
        }
        
        
        private bool IsPasswordNotMatching()
        {
            if (textBoxPassword.Text != textBoxPasswordConfirm.Text)
            {
                MessageBox.Show("Passwords do not match!");
                return true;
            }
            return false;
        }
        private bool CheckEmpty()
        {
            if (string.IsNullOrWhiteSpace(textBoxFirstName.Text))
            {
                MessageBox.Show("Enter Firstname");
                return true;
            }
            if (string.IsNullOrWhiteSpace(textBoxLastName.Text))
            {
                MessageBox.Show("Enter Lastname");
                return true;
            }
            if (string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                MessageBox.Show("Enter Email");
                return true;
            }
            if (string.IsNullOrWhiteSpace(textBoxUsername.Text))
            {
                MessageBox.Show("Enter Username");
                return true;
            }
            if (string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("Enter Password");
                return true;
            }
            
            return false;
        }
    }
}
