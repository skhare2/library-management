using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace NEALibrary
{
    public partial class LoginForm : Form
    {
        private SqlConnection con = DatabaseConnection.GetConnection();
        private int records = 0;
        private int LoginAttempts = 0;

        public LoginForm()
        {
            InitializeComponent();
            StartUpProceses(); // Does any processes that are fundamental before starting application like removing expired completion dates in the reservation table
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                bool empty = CheckEmpty();
                if (empty)
                {
                    return;
                }


                Login();

                if (records == 0)
                {
                    MessageBox.Show("Username or password incorrect");
                }
                else
                {
                    MessageBox.Show("Successful Login");
                    

                    if (comboBoxUserType.Text == "Student")
                    {

                        DataTable dt = Program.user.GetUserDataTable();
                        var record = dt.Rows[0];
                        Student student = new Student(record["FirstName"].ToString(), record["LastName"].ToString(), Convert.ToDateTime(record["DOB"].ToString()), record["Username"].ToString(), record["Password"].ToString(), record["Email"].ToString());
                        Program.user = student;
                        this.Visible = false;
                        StudentMainForm form = new StudentMainForm();
                        form.ShowDialog();
                        
                    }
                    else
                    {
                        DataTable dt = Program.user.GetUserDataTable();
                        var record = dt.Rows[0];
                        Librarian librarian = new Librarian(record["FirstName"].ToString(), record["LastName"].ToString(), Convert.ToDateTime(record["DOB"].ToString()), record["Username"].ToString(), record["Password"].ToString(), record["Email"].ToString());
                        Program.user = librarian;
                        this.Visible = false;
                        LibrarianMainForm form = new LibrarianMainForm();
                        form.ShowDialog();
                        
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            


        }

        private bool CheckEmpty()
        {
            if (string.IsNullOrEmpty(textBoxUsername.Text))
            {
                MessageBox.Show("Enter username");
                return true;
            }
            if (string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Enter password");
                return true;
            }
            if (string.IsNullOrEmpty(comboBoxUserType.Text))
            {
                MessageBox.Show("Please select a user type");
                return true;
            }
            return false;
        }

        private void Login()
        {
            LoginAttempts += 1;
            if (LoginAttempts > 5)
            {
                MessageBox.Show("Too many Login attempts");
                Application.Exit();
            }
            Program.user = new User(textBoxUsername.Text, textBoxPassword.Text, comboBoxUserType.Text);
            records = Program.user.Login_Record_Count();
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudentForm = new AddStudentForm();
            addStudentForm.ShowDialog();
        }

        private void buttonForgot_Click(object sender, EventArgs e)
        {
            ForgotPasswordForm forgotPasswordForm = new ForgotPasswordForm();
            forgotPasswordForm.ShowDialog();
        }

        private void RemoveAllExpiredReservations()
        {
            Reservation.RemoveAllExpiredReservations();
        }
        private void StartUpProceses()
        {
            RemoveAllExpiredReservations();
        }
    }
}
