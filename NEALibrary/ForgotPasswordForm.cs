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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NEALibrary
{
    public partial class ForgotPasswordForm : Form
    {
        int Code;
        int AttemptsLeft = 3;
        private SqlConnection con = DatabaseConnection.GetConnection();

        public ForgotPasswordForm()
        {
            InitializeComponent();
            labelCode.Visible = false;
            buttonCode.Visible = false;
            textBoxCode.Visible = false;
            labelAttempts.Visible = false;
            labelAttempts.Text = "";
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (CheckEmpty() || !DoesUserExist())
            {
                return;
            }
            
            string email = GetEmail();
            SendMail(email, "Your code");
            labelCode.Visible = true;
            buttonCode.Visible = true;
            textBoxCode.Visible = true;
            labelAttempts.Visible = true;
            buttonSubmit.Enabled = false;
            textBoxUsername.Enabled = false;
            NumberofAttempts();

        }
        private void NumberofAttempts()
        {
            
            labelAttempts.Text = $"You have {AttemptsLeft} Attempts";
        }

        private void SendMail(string email, string subject)
        {
            Code = Mail.CodeGenerator();
            Mail mail = new Mail($"Your code is {Code}", email, subject);
            mail.SendMail();

        }

        
        private bool CheckEmpty()
        {
            if (String.IsNullOrEmpty(textBoxUsername.Text))
            {
                MessageBox.Show("Enter username");
            }
            return String.IsNullOrEmpty(textBoxUsername.Text);

        }
        private string GetEmail()
        {
            string email = null;
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Email FROM Student WHERE Username = @username";
            cmd.Parameters.AddWithValue("@username", textBoxUsername.Text);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    email = reader["Email"].ToString();
                }
            }
            return email;





        }
        private bool DoesUserExist()
        {
            int records = 0;
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Student WHERE Username = @username";





            cmd.Parameters.AddWithValue("@username", textBoxUsername.Text);


            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            records = dt.Rows.Count;


            con.Close();

            if (records != 1)
            {
                MessageBox.Show("Student does not exist");
            }

            return records == 1;
        }

        private void buttonCode_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBoxCode.Text.ToString()) == Code)
                {
                    MessageBox.Show("Correct code entered");
                    this.Close();
                    ChangePasswordForm changePasswordForm = new ChangePasswordForm(textBoxUsername.Text);
                    changePasswordForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Incorrect code entered");
                    AttemptsLeft -= 1;
                    if (AttemptsLeft == 0)
                    {
                        Application.Exit();
                    }
                    else
                    {
                        NumberofAttempts();
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                AttemptsLeft -= 1;
                if (AttemptsLeft == 0)
                {
                    Application.Exit();
                }
                NumberofAttempts();

            }

            
        }
    }
}
