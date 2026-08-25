namespace NEALibrary
{
    partial class LibrarianMainForm
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
            buttonViewEditBooks = new Button();
            buttonBooks = new Button();
            buttonAddBooks = new Button();
            buttonIssueBooks = new Button();
            buttonLendBooks = new Button();
            buttonLibrarySetting = new Button();
            buttonLateFee = new Button();
            buttonWishlist = new Button();
            buttonLeaderboard = new Button();
            buttonLibrarianManagement = new Button();
            buttonRemoveCopy = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Blue;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1460, 55);
            panel1.TabIndex = 17;
            // 
            // buttonViewEditBooks
            // 
            buttonViewEditBooks.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonViewEditBooks.Location = new Point(278, 76);
            buttonViewEditBooks.Name = "buttonViewEditBooks";
            buttonViewEditBooks.Size = new Size(184, 111);
            buttonViewEditBooks.TabIndex = 22;
            buttonViewEditBooks.Text = "View / Edit Books";
            buttonViewEditBooks.UseVisualStyleBackColor = true;
            buttonViewEditBooks.Click += buttonViewEditBooks_Click;
            // 
            // buttonBooks
            // 
            buttonBooks.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBooks.Location = new Point(35, 76);
            buttonBooks.Name = "buttonBooks";
            buttonBooks.Size = new Size(184, 111);
            buttonBooks.TabIndex = 21;
            buttonBooks.Text = "Books";
            buttonBooks.UseVisualStyleBackColor = true;
            buttonBooks.Click += buttonBooks_Click_1;
            // 
            // buttonAddBooks
            // 
            buttonAddBooks.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAddBooks.Location = new Point(551, 76);
            buttonAddBooks.Name = "buttonAddBooks";
            buttonAddBooks.Size = new Size(184, 111);
            buttonAddBooks.TabIndex = 23;
            buttonAddBooks.Text = "Add Books";
            buttonAddBooks.UseVisualStyleBackColor = true;
            buttonAddBooks.Click += buttonAddBooks_Click;
            // 
            // buttonIssueBooks
            // 
            buttonIssueBooks.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonIssueBooks.Location = new Point(35, 236);
            buttonIssueBooks.Name = "buttonIssueBooks";
            buttonIssueBooks.Size = new Size(184, 111);
            buttonIssueBooks.TabIndex = 24;
            buttonIssueBooks.Text = "Issue Books";
            buttonIssueBooks.UseVisualStyleBackColor = true;
            buttonIssueBooks.Click += buttonIssueBooks_Click;
            // 
            // buttonLendBooks
            // 
            buttonLendBooks.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLendBooks.Location = new Point(278, 236);
            buttonLendBooks.Name = "buttonLendBooks";
            buttonLendBooks.Size = new Size(184, 111);
            buttonLendBooks.TabIndex = 25;
            buttonLendBooks.Text = "Return Books";
            buttonLendBooks.UseVisualStyleBackColor = true;
            buttonLendBooks.Click += buttonLendBooks_Click;
            // 
            // buttonLibrarySetting
            // 
            buttonLibrarySetting.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLibrarySetting.Location = new Point(35, 629);
            buttonLibrarySetting.Name = "buttonLibrarySetting";
            buttonLibrarySetting.Size = new Size(184, 111);
            buttonLibrarySetting.TabIndex = 26;
            buttonLibrarySetting.Text = "Library Setting";
            buttonLibrarySetting.UseVisualStyleBackColor = true;
            buttonLibrarySetting.Click += buttonLibrarySetting_Click;
            // 
            // buttonLateFee
            // 
            buttonLateFee.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLateFee.Location = new Point(278, 629);
            buttonLateFee.Name = "buttonLateFee";
            buttonLateFee.Size = new Size(184, 111);
            buttonLateFee.TabIndex = 27;
            buttonLateFee.Text = "Change late fees / due date timespan";
            buttonLateFee.UseVisualStyleBackColor = true;
            buttonLateFee.Click += buttonLateFee_Click;
            // 
            // buttonWishlist
            // 
            buttonWishlist.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonWishlist.Location = new Point(278, 467);
            buttonWishlist.Name = "buttonWishlist";
            buttonWishlist.Size = new Size(184, 111);
            buttonWishlist.TabIndex = 30;
            buttonWishlist.Text = "Wishlist Management";
            buttonWishlist.UseVisualStyleBackColor = true;
            buttonWishlist.Click += buttonWishlist_Click;
            // 
            // buttonLeaderboard
            // 
            buttonLeaderboard.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLeaderboard.Location = new Point(35, 467);
            buttonLeaderboard.Name = "buttonLeaderboard";
            buttonLeaderboard.Size = new Size(184, 111);
            buttonLeaderboard.TabIndex = 31;
            buttonLeaderboard.Text = "Student Leaderboard";
            buttonLeaderboard.UseVisualStyleBackColor = true;
            buttonLeaderboard.Click += buttonLeaderboard_Click_1;
            // 
            // buttonLibrarianManagement
            // 
            buttonLibrarianManagement.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLibrarianManagement.Location = new Point(551, 629);
            buttonLibrarianManagement.Name = "buttonLibrarianManagement";
            buttonLibrarianManagement.Size = new Size(184, 111);
            buttonLibrarianManagement.TabIndex = 32;
            buttonLibrarianManagement.Text = "Librarian management";
            buttonLibrarianManagement.UseVisualStyleBackColor = true;
            buttonLibrarianManagement.Click += buttonLibrarianManagement_Click;
            // 
            // buttonRemoveCopy
            // 
            buttonRemoveCopy.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRemoveCopy.Location = new Point(828, 76);
            buttonRemoveCopy.Name = "buttonRemoveCopy";
            buttonRemoveCopy.Size = new Size(184, 111);
            buttonRemoveCopy.TabIndex = 33;
            buttonRemoveCopy.Text = "Remove Copy";
            buttonRemoveCopy.UseVisualStyleBackColor = true;
            buttonRemoveCopy.Click += buttonRemoveCopy_Click;
            // 
            // LibrarianMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1460, 790);
            Controls.Add(buttonRemoveCopy);
            Controls.Add(buttonLibrarianManagement);
            Controls.Add(buttonLeaderboard);
            Controls.Add(buttonWishlist);
            Controls.Add(buttonLateFee);
            Controls.Add(buttonLibrarySetting);
            Controls.Add(buttonLendBooks);
            Controls.Add(buttonIssueBooks);
            Controls.Add(buttonAddBooks);
            Controls.Add(buttonViewEditBooks);
            Controls.Add(buttonBooks);
            Controls.Add(panel1);
            Name = "LibrarianMainForm";
            Text = "LibrarianMainForm";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonViewEditBooks;
        private Button buttonBooks;
        private Button buttonAddBooks;
        private Button buttonIssueBooks;
        private Button buttonLendBooks;
        private Button buttonLibrarySetting;
        private Button buttonLateFee;
        private Button buttonWishlist;
        private Button buttonLeaderboard;
        private Button buttonLibrarianManagement;
        private Button buttonRemoveCopy;
    }
}