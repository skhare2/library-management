using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEALibrary
{
    public partial class StudentReservationForm : Form
    {
        private Book book;
        private Reservation reservation;

        public StudentReservationForm()
        {
            InitializeComponent();
            book = new Book();
            reservation = new Reservation();
            LoadData();
            buttonReserve.Visible = false;
            buttonViewAvailability.Visible = false;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            LoadData();
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



        private void dataGridViewBooks_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowindex = e.RowIndex;
                if (rowindex >= 0)
                {
                    var rowdata = dataGridViewBooks.Rows[rowindex];

                    if (rowdata.Cells["Title"].Value != null &&
                        rowdata.Cells["NumberOfCopies"].Value != null &&
                        rowdata.Cells["AuthorName"].Value != null)
                    {
                        textBoxReserveTitle.Text = rowdata.Cells["Title"].Value.ToString();
                        textBoxReserveNumberOfCopies.Text = rowdata.Cells["NumberOfCopies"].Value.ToString();
                        textBoxReserveAuthorName.Text = rowdata.Cells["AuthorName"].Value.ToString();
                        textBoxReserveGenre.Text = rowdata.Cells["Genre"].Value.ToString();
                        textBoxReserveFictionStatus.Text = rowdata.Cells["FictionStatus"].Value.ToString();
                        textBoxReserveAgeGroup.Text = rowdata.Cells["AgeGroup"].Value.ToString();

                        // Check availability, update button visibility
                        int bookid = book.GetBookIdReservation(textBoxReserveTitle.Text, textBoxReserveAuthorName.Text, textBoxReserveGenre.Text);
                        int copies = book.NumberofAvailableCopies(bookid);

                        if(copies == 0)
                        {
                            MessageBox.Show("There are 0 copies available. You may reserve this book");
                            buttonReserve.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show($"There are {copies} copies available. You may not reserve this book as it is located at the library");
                            buttonReserve.Visible = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Selected row contains empty data.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool IsEmpty()  // Method not in use
        {
            if (String.IsNullOrEmpty(textBoxReserveTitle.Text) || String.IsNullOrEmpty(textBoxReserveNumberOfCopies.Text) || String.IsNullOrEmpty(textBoxReserveAuthorName.Text) || String.IsNullOrEmpty(textBoxReserveGenre.Text) || String.IsNullOrEmpty(textBoxReserveFictionStatus.Text) || String.IsNullOrEmpty(textBoxReserveAgeGroup.Text))
            {
                MessageBox.Show("One or more mandatory fields are empty");
                return true;
            }
            return false;
        }
        private void buttonViewAvailability_Click(object sender, EventArgs e) // Method not in use kept as it shows the logic I am using
        {
            if (IsEmpty())
            {
                return;
            }
            int bookid = book.GetBookIdReservation(textBoxReserveTitle.Text, textBoxReserveAuthorName.Text, comboBoxGenre.Text);
            //MessageBox.Show($"The bookid is {bookid}");
            int copies = book.NumberofAvailableCopies(bookid);
            if (copies > 0)
            {
                MessageBox.Show($"There are {copies} available. You may not reserve this book as it is located at the library");
                buttonReserve.Visible = false;
            }
            else
            {
                MessageBox.Show("There are 0 copies available. You may reserve this book");
                buttonReserve.Visible = true;
            }
        }

        private void buttonReserve_Click(object sender, EventArgs e)
        {
            if (IsEmpty())
            {
                return;
            }
            int StudentId = Program.user.GetUserId();

            if (Reservation.HasStudentMadeAReservation(Program.user.GetUserId()))
            {
                MessageBox.Show("You cannot make multiple reservations"); // Prevents user from more than one reservation
                return;
            }

            int BookId = book.GetBookIdReservation(textBoxReserveTitle.Text, textBoxReserveAuthorName.Text, textBoxReserveGenre.Text);

            if (BookId < 0)
            {
                MessageBox.Show("Book invalid"); // This is to avoid any errors if the book is not valid
                return;
            }
            if(reservation.CheckReservationExists(StudentId, BookId))
            {
                MessageBox.Show("You have already reserved this book"); // We do not want to let a user reserve the same book more than once
                return;
            }
            if (Reservation.ReservationWithBookIdExists(BookId))
            {
                MessageBox.Show("This book has already been reserved by someone else. Reservation unavailable"); //Cannot let the bookid get reserved again
                return;
            }

            reservation.AddReservation(StudentId, BookId);
            buttonReserve.Visible = false;
        }
    }
}
