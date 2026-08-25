using System;
using System.Data;
using System.Windows.Forms;

namespace NEALibrary
{
    public partial class ChangeLateFeeForm : Form
    {
        private LibrarySetting librarysetting;
        private string? DailyLateFee;
        private string? DueDateTimeSpan;
        private string? ReservationExpire;
        private string? StudentUsernameLength;
        private string? SchoolDomain;

        public ChangeLateFeeForm()
        {
            InitializeComponent();
            librarysetting = new LibrarySetting();
            LoadSetting();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            ModifySetting();
            LoadSetting();
        }

        private void LoadSetting()
        {
            try
            {
                string? fee = librarysetting.GetSettingValue("DailyLateFee");
                textBoxLateFee.Text = fee;
                DailyLateFee = fee;

                string? dueDateTimeSpan = librarysetting.GetSettingValue("DueDateTimeSpan");
                textBoxDueDate.Text = dueDateTimeSpan;
                DueDateTimeSpan = dueDateTimeSpan;

                string? reservationExpire = librarysetting.GetSettingValue("ReservationExpire");
                textBoxReservationExpire.Text = reservationExpire;
                ReservationExpire = reservationExpire;

                string? studentusernamelength = librarysetting.GetSettingValue("StudentUsernameLength");
                textBoxStudentUsernameLength.Text = studentusernamelength;
                StudentUsernameLength = studentusernamelength;

                string? schooldomain = librarysetting.GetSettingValue("SchoolDomain");
                textBoxSchoolDomain.Text = schooldomain;
                SchoolDomain = schooldomain;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ModifySetting()
        {
            try
            {
                bool isModified = false;

                if (DailyLateFee == textBoxLateFee.Text &&
                    DueDateTimeSpan == textBoxDueDate.Text &&
                    ReservationExpire == textBoxReservationExpire.Text &&
                    StudentUsernameLength == textBoxStudentUsernameLength.Text &&
                    SchoolDomain == textBoxSchoolDomain.Text)
                {
                    MessageBox.Show("The values are the same as before. Please edit them to change their values.");
                    return;
                }

                
                if (DailyLateFee != textBoxLateFee.Text)
                {
                    if ((!double.TryParse(textBoxLateFee.Text, out double lateFee)) || String.IsNullOrEmpty(textBoxLateFee.Text))
                    {
                        MessageBox.Show("Daily Late Fee must be a valid number.");
                        return;
                    }
                    librarysetting.ModifySettingValue("DailyLateFee", textBoxLateFee.Text);
                    isModified = true;
                }

                
                if (DueDateTimeSpan != textBoxDueDate.Text)
                {
                    if ((!int.TryParse(textBoxDueDate.Text, out int dueDateSpan)) || String.IsNullOrEmpty(textBoxDueDate.Text))
                    {
                        MessageBox.Show("Due Date Time Span must be a valid integer.");
                        return;
                    }
                    librarysetting.ModifySettingValue("DueDateTimeSpan", textBoxDueDate.Text);
                    isModified = true;
                }

                
                if (ReservationExpire != textBoxReservationExpire.Text)
                {
                    if ((!int.TryParse(textBoxReservationExpire.Text, out int reservationExpire)) || String.IsNullOrEmpty(textBoxReservationExpire.Text))
                    {
                        MessageBox.Show("Reservation Expire must be a valid integer.");
                        return;
                    }
                    librarysetting.ModifySettingValue("ReservationExpire", textBoxReservationExpire.Text);
                    isModified = true;
                }

                
                if (StudentUsernameLength != textBoxStudentUsernameLength.Text)
                {
                    if ((!int.TryParse(textBoxStudentUsernameLength.Text, out int usernameLength)) || String.IsNullOrEmpty(textBoxStudentUsernameLength.Text))
                    {
                        MessageBox.Show("Student Username Length must be a valid integer.");
                        return;
                    }
                    int UsernameLength = Convert.ToInt32(textBoxStudentUsernameLength.Text);
                    if(UsernameLength == 0 || UsernameLength < -1)
                    {
                        MessageBox.Show("Student Username Length must be a valid integer.");
                        return;
                    }
                    librarysetting.ModifySettingValue("StudentUsernameLength", textBoxStudentUsernameLength.Text);
                    isModified = true;
                }

                
                if (SchoolDomain != textBoxSchoolDomain.Text)
                {
                    string schoolDomain = textBoxSchoolDomain.Text.Trim();
                    if (String.IsNullOrEmpty(schoolDomain))
                    {
                        librarysetting.ModifySettingValue("SchoolDomain", string.Empty);
                        isModified = true;
                    }
                    
                    //if(schoolDomain.Length == 0)
                    //{
                        //librarysetting.ModifySettingValue("SchoolDomain", schoolDomain);
                        //isModified = true;
                    //}
                    else if (!IsValidDomain(schoolDomain))
                    {
                        MessageBox.Show("School Domain must be in format @domainname");
                        return;
                    }
                    else
                    {
                        librarysetting.ModifySettingValue("SchoolDomain", schoolDomain);
                        isModified = true;
                    }
                    
                }

                if (isModified)
                {
                    MessageBox.Show("Settings updated successfully.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        private bool IsValidDomain(string domain)
        {
            if (string.IsNullOrEmpty(domain))
            {
                return true;
            }
            bool startswith = domain.StartsWith("@");
            bool Length = domain.Length > 1;
            bool isNotEmptyAfter = !String.IsNullOrEmpty(domain.Substring(1)); // Substring from second character to end
            return (startswith && Length && isNotEmptyAfter);
            
        }

    }
}
