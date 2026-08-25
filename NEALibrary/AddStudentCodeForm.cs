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

namespace NEALibrary
{

    public partial class AddStudentCodeForm : Form
    {
        private int Code;
        private int AttemptsLeft = 3;
        private Student Student;
        public AddStudentCodeForm(Student student)
        {
            InitializeComponent();
            
            Student = student;
            labelAttempts.Text = "";
            NumberofAttempts();
            SendMail(Student.GetEmail(), "Your code");

        }

        private void AddStudentCodeForm_Load(object sender, EventArgs e)
        {

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

        private void buttonCode_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBoxCode.Text.ToString()) == Code)
                {
                    MessageBox.Show("Correct code entered");
                    
                    Student.AddStudent();
                    
                    this.Close();
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
