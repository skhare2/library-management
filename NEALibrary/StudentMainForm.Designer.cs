namespace NEALibrary
{
    partial class StudentMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            buttonBooks = new Button();
            buttonViewBooks = new Button();
            buttonReservation = new Button();
            buttonWishList = new Button();
            buttonViewLoan = new Button();
            buttonViewCompletedReservation = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Blue;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1401, 55);
            panel1.TabIndex = 16;
            // 
            // buttonBooks
            // 
            buttonBooks.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBooks.Location = new Point(31, 90);
            buttonBooks.Name = "buttonBooks";
            buttonBooks.Size = new Size(184, 111);
            buttonBooks.TabIndex = 17;
            buttonBooks.Text = "Books";
            buttonBooks.UseVisualStyleBackColor = true;
            buttonBooks.Click += buttonBooks_Click;
            // 
            // buttonViewBooks
            // 
            buttonViewBooks.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonViewBooks.Location = new Point(304, 90);
            buttonViewBooks.Name = "buttonViewBooks";
            buttonViewBooks.Size = new Size(185, 111);
            buttonViewBooks.TabIndex = 0;
            buttonViewBooks.Text = "View Books";
            buttonViewBooks.Click += buttonViewBooks_Click_1;
            // 
            // buttonReservation
            // 
            buttonReservation.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonReservation.Location = new Point(31, 256);
            buttonReservation.Name = "buttonReservation";
            buttonReservation.Size = new Size(184, 111);
            buttonReservation.TabIndex = 18;
            buttonReservation.Text = "Make Reservation";
            buttonReservation.UseVisualStyleBackColor = true;
            buttonReservation.Click += buttonReservation_Click;
            // 
            // buttonWishList
            // 
            buttonWishList.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonWishList.Location = new Point(31, 407);
            buttonWishList.Name = "buttonWishList";
            buttonWishList.Size = new Size(184, 111);
            buttonWishList.TabIndex = 19;
            buttonWishList.Text = "Add Book to Library Wishlist";
            buttonWishList.UseVisualStyleBackColor = true;
            buttonWishList.Click += buttonWishList_Click;
            // 
            // buttonViewLoan
            // 
            buttonViewLoan.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonViewLoan.Location = new Point(584, 90);
            buttonViewLoan.Name = "buttonViewLoan";
            buttonViewLoan.Size = new Size(184, 111);
            buttonViewLoan.TabIndex = 20;
            buttonViewLoan.Text = "View Loans and fees";
            buttonViewLoan.UseVisualStyleBackColor = true;
            buttonViewLoan.Click += buttonViewLoan_Click;
            // 
            // buttonViewCompletedReservation
            // 
            buttonViewCompletedReservation.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonViewCompletedReservation.Location = new Point(304, 256);
            buttonViewCompletedReservation.Name = "buttonViewCompletedReservation";
            buttonViewCompletedReservation.Size = new Size(184, 111);
            buttonViewCompletedReservation.TabIndex = 21;
            buttonViewCompletedReservation.Text = "View Completed Reservations";
            buttonViewCompletedReservation.UseVisualStyleBackColor = true;
            buttonViewCompletedReservation.Click += buttonViewCompletedReservation_Click;
            // 
            // StudentMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1401, 769);
            Controls.Add(buttonViewCompletedReservation);
            Controls.Add(buttonViewLoan);
            Controls.Add(buttonWishList);
            Controls.Add(buttonReservation);
            Controls.Add(buttonViewBooks);
            Controls.Add(buttonBooks);
            Controls.Add(panel1);
            Name = "StudentMainForm";
            Text = "StudentMainForm";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonBooks;
        private Button buttonViewBooks;
        private Button buttonReservation;
        private Button buttonWishList;
        private Button buttonViewLoan;
        private Button buttonViewCompletedReservation;
    }
}