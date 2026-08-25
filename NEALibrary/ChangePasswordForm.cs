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
    public partial class ChangePasswordForm : Form
    {
        private String Username;
        public ChangePasswordForm(string username)
        {
            InitializeComponent();
            Username = username;
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            if (!PasswordSame() || IsEmpty())
            {
                return;
            }
            try
            {
                Student student = new Student("", "", DateTime.Now, Username, "", "");
                student.ChangePassword(textBoxPassword.Text);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool PasswordSame()
        {
            if (textBoxPassword.Text != textBoxPasswordConfirm.Text)
            {
                MessageBox.Show("Passwords do not match");
            }
            return textBoxPassword.Text == textBoxPasswordConfirm.Text;
        }
        private bool IsEmpty()
        {
            if (String.IsNullOrEmpty(textBoxPassword.Text) || String.IsNullOrEmpty(textBoxPasswordConfirm.Text))
            {
                MessageBox.Show("Please enter a password");
            }
            return String.IsNullOrEmpty(textBoxPassword.Text) || String.IsNullOrEmpty(textBoxPasswordConfirm.Text);
        }
    }
}
