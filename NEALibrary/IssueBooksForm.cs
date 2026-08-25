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
    public partial class IssueBooksForm : Form
    {

        private int StudentId;

        private List<int> CopyID;
        private Book book;
        private List<int> ReservedCopyId;
        private List<Tuple<int, int>> ReservedBookIdAndNumber; // First element is the bookid and the second element is how many copies have they selected

        public IssueBooksForm()
        {
            InitializeComponent();
            panelBookLoan.Visible = false;
            
            book = new Book();

            CopyID = new List<int>();
            ReservedCopyId = new List<int>();
            ReservedBookIdAndNumber = new List<Tuple<int, int>>();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (UserSubmissionEmpty())
                {
                    return;
                }
                if (CheckStudentExists())
                {
                    GetStudentId();

                    MessageBox.Show("Student Exists");
                    panelStudentDetail.Visible = false;
                    
                    panelBookLoan.Visible = true;
                    
                }
                else
                {
                    MessageBox.Show("Student does not exist");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private bool UserSubmissionEmpty()
        {
            if(String.IsNullOrEmpty(textBoxUsername.Text) || String.IsNullOrEmpty(textBoxFirstName.Text) || String.IsNullOrEmpty(textBoxLastName.Text))
            {
                MessageBox.Show("One or more mandatory field are empty");
                return true;
            }
            return false;
        }
        private bool CheckStudentExists()
        {
            return Student.CheckStudentExists(textBoxUsername.Text.ToString(), textBoxFirstName.Text.ToString(), textBoxLastName.Text.ToString());
        }
        private void GetStudentId()
        {
            StudentId = Student.GetStudentId(textBoxUsername.Text.ToString(), textBoxFirstName.Text.ToString(), textBoxLastName.Text.ToString());
        }

        private void buttonAddCopy_Click(object sender, EventArgs e)
        {
            try
            {

                int CopyId = Convert.ToInt32(textBoxCopyId.Text.ToString());
                if (!book.DoesBookCopyExist(CopyId)) // Check if the copy exists
                {
                    MessageBox.Show("Book/Copy does not exist");
                    ClearTextBox();
                    return;
                }
                
                
                
                if (IsBookInList(CopyId)) // Is copy in the list cause we cannot check the same one twice
                {
                    MessageBox.Show("Book added previously - cannot be added twice");
                    ClearTextBox();
                    return;
                }
                if (!(book.GetBookCopyStatus(CopyId) == "Available")) // Is the copy available for checkout
                {
                    MessageBox.Show("This book has been borrowed already - Cannot be lent", "Book cannot be lent");
                    ClearTextBox();
                    return;
                }
                
                int BookId = Book.GetBookIdByCopyId(CopyId);
                bool isReserved = Reservation.ReservationWithBookIdExists(BookId);
                
                int reservedStudentId = -1;
                if (isReserved) // Ensures a reserved book has enough copies left if a student tries to check out a book
                {
                    reservedStudentId = Reservation.GetStudentIdForBookId(BookId);

                    if(StudentId == reservedStudentId) // The student is the student who is reserving
                    {
                        if (!ReservedCopyId.Contains(CopyId))
                        {
                            ReservedCopyId.Add(CopyId); // Add it to this list so it can be removed from reservation table
                        }
                    }

                    else // If the student is not the reserving student then it checks if the number of copies currently selected is available copies - 1 so there is one copy always available for the reserving student
                    {
                        int availablecopies = book.NumberofAvailableCopies(BookId);
                        int selectedCopies = 0;
                        for (int i = 0; i < ReservedBookIdAndNumber.Count; i++) // Counts the number of currently selected copies and compares this to the number of available copies
                        {
                            if (ReservedBookIdAndNumber[i].Item1 == BookId)
                            {
                                selectedCopies += ReservedBookIdAndNumber[i].Item2;
                            }
                            
                        }
                        if (selectedCopies >= availablecopies - 1)
                        { // If the selected copies is the total number of available copies there is an error 
                            MessageBox.Show("This book is currently reserved and its fully quantity cannot be issued");
                            ClearTextBox();
                            return;
                        }
                    }

                    
                }
                
                  
                

                //if (Reservation.ReservationWithBookIdExists(BookId) && book.NumberofAvailableCopies(BookId) == 1)
                //{
                    //if (StudentId != Reservation.GetStudentIdForBookId(BookId))
                    //{
                        //MessageBox.Show("This book is currently reserved and cannot be issued.");
                        //ClearTextBox();
                        //return;
                    //}

                    //ReservedBookIdAndNumber.Add(BookId,Nu)
                //}

                //if (Reservation.ReservationWithBookIdExists(Book.GetBookIdByCopyId(CopyId)) && StudentId == Reservation.GetStudentIdForBookId(Book.GetBookIdByCopyId(CopyId)))
                //{
                    //ReservedCopyId.Add(Tuple.Create(Book.));
                    
                //}

                CopyID.Add(CopyId);

                bool foundBookIdInList = false;
                for (int i = 0; i < ReservedBookIdAndNumber.Count; i++) // We are checking if the bookid is in the list of tuples so if it is we can increment the number by 1
                {
                    if(ReservedBookIdAndNumber[i].Item1 == BookId)
                    {
                        int currentCount = ReservedBookIdAndNumber[i].Item2;
                        ReservedBookIdAndNumber[i] = Tuple.Create(BookId, currentCount+1);
                        foundBookIdInList = true;
                        break;
                    }
                }
                if(!foundBookIdInList)
                {
                    ReservedBookIdAndNumber.Add(Tuple.Create(BookId, 1)); // Otherwise there is only one copy
                }

                textBoxBookNames.AppendText(Environment.NewLine);
                textBoxBookNames.AppendText(book.GetCopyBookTitle(CopyId));
                ClearTextBox();
            }
            catch
            {
                MessageBox.Show("Invalid BookId or CopyId");
            }
        }
        private bool IsBookReserved(int copyId)
        {
            return Reservation.IsBookReserved(copyId);
        }
        private bool IsBookInList(int CopyId)
        {
            return (CopyID.Contains(CopyId));
        }

        private void ClearTextBox()
        {

            textBoxCopyId.Clear();
        }

        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            if(CopyID.Count == 0 || textBoxCopyId.Text != "")
            {
                MessageBox.Show("Please Add Copies to proceed");
                return;
            }
            this.Visible = false;
            IssueBooksCheckoutForm form = new IssueBooksCheckoutForm(StudentId, CopyID, ReservedCopyId);
            form.ShowDialog();
            
            
        }

        private void buttonCheckoutFinal_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        
    }
}
