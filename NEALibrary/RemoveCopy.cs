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
    public partial class RemoveCopy : Form
    {
        private Book book;
        private List<int> CopyIDs;
        private List<int> ReservedCopyId;
        public RemoveCopy()
        {
            InitializeComponent();
            book = new Book();
            CopyIDs = new List<int>();
            ReservedCopyId = new List<int>();
        }

        private void buttonAddCopyId_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxCopyId.Text == "")
                {
                    MessageBox.Show("Please enter the copyId");
                    return;
                }
                int CopyId = Convert.ToInt32(textBoxCopyId.Text.ToString());

                if (IsBookInList(CopyId)) // Is copy in the list cause we cannot remove the same one twice
                {
                    MessageBox.Show("This book is currently reserved and cannot be issued");
                    ClearTextBox();
                    return;
                }

                if (!book.DoesBookCopyExist(CopyId)) // Check if the copy exists
                {
                    MessageBox.Show("Book/Copy does not exist");
                    ClearTextBox();
                    return;
                }
                if (!(book.GetBookCopyStatus(CopyId) == "Available")) // Is the copy available for removal
                {
                    MessageBox.Show("This book is lent - cannot remove a copy that is not available");
                    ClearTextBox();
                    return;
                }
                if (Reservation.IsBookReserved(CopyId))
                {
                    if (!ReservedCopyId.Contains(CopyId))
                    {
                        ReservedCopyId.Add(CopyId);
                    }
                }
                CopyIDs.Add(CopyId);
                textBoxBookNames.AppendText(Environment.NewLine);
                textBoxBookNames.AppendText(book.GetCopyBookTitle(CopyId));
                ClearTextBox();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearTextBox()
        {

            textBoxCopyId.Clear();
        }
        private bool IsBookInList(int CopyId)
        {
            return (CopyIDs.Contains(CopyId));
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (CopyIDs.Count == 0)
                {
                    MessageBox.Show("Please select some CopyIds");
                    return;
                }

                if (MessageBox.Show($"Do you want to continue and remove the selected books -  click Yes to continue or No to remain", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }

                

                if (ReservedCopyId.Count > 0)
                {

                    for (int i = 0; i < ReservedCopyId.Count; i++)
                    {
                        int BookId = Book.GetBookIdByCopyId(ReservedCopyId[i]);
                        
                        if (book.NumberofAvailableCopies(BookId) <= 1) // If this only copy available remove the completion date
                        {

                            Reservation.RemoveCompletionDate(BookId);
                            
                        }
                    }
                    
                }
                

                foreach (int CopyId in CopyIDs)
                {
                    int BookId = Book.GetBookIdByCopyId(CopyId);
                    book.DeleteBookCopy(CopyId);
                    book.DecrementNumberOfCopies(BookId);

                    if (book.NumberofAvailableCopies(BookId) == 0) // If the number of available copies is 0 remove the book
                    {
                        //book.RemoveBook(BookId);
                        book.RemoveCopy(CopyId);

                    }
                }
                this.Visible = false;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        
    }
}
