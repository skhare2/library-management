namespace NEALibrary
{
    partial class WishListForm
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
            dataGridViewBooks = new DataGridView();
            panel2 = new Panel();
            textBoxNoOfRequests = new TextBox();
            textBoxISBN13 = new TextBox();
            textBoxTitle = new TextBox();
            label14 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxAuthorName = new TextBox();
            buttonSubmit = new Button();
            label2 = new Label();
            textBoxStudentId = new TextBox();
            label1 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            buttonRemove = new Button();
            textBoxWishListNoOfRequests = new TextBox();
            textBoxWishListISBN13 = new TextBox();
            textBoxWishListTitle = new TextBox();
            label7 = new Label();
            label8 = new Label();
            textBoxWishListAuthorName = new TextBox();
            label9 = new Label();
            textBoxWishListStudentId = new TextBox();
            label10 = new Label();
            label11 = new Label();
            buttonAddBook = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewBooks
            // 
            dataGridViewBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBooks.Location = new Point(573, 12);
            dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewBooks.RowHeadersWidth = 51;
            dataGridViewBooks.Size = new Size(556, 552);
            dataGridViewBooks.TabIndex = 23;
            dataGridViewBooks.CellClick += dataGridViewBooks_CellClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBoxNoOfRequests);
            panel2.Controls.Add(textBoxISBN13);
            panel2.Controls.Add(textBoxTitle);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textBoxAuthorName);
            panel2.Controls.Add(buttonSubmit);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBoxStudentId);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(12, 57);
            panel2.Name = "panel2";
            panel2.Size = new Size(555, 398);
            panel2.TabIndex = 24;
            // 
            // textBoxNoOfRequests
            // 
            textBoxNoOfRequests.Location = new Point(260, 222);
            textBoxNoOfRequests.Name = "textBoxNoOfRequests";
            textBoxNoOfRequests.Size = new Size(266, 27);
            textBoxNoOfRequests.TabIndex = 29;
            // 
            // textBoxISBN13
            // 
            textBoxISBN13.Location = new Point(260, 159);
            textBoxISBN13.Name = "textBoxISBN13";
            textBoxISBN13.Size = new Size(266, 27);
            textBoxISBN13.TabIndex = 28;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(260, 105);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(266, 27);
            textBoxTitle.TabIndex = 27;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(178, 5);
            label14.Name = "label14";
            label14.Size = new Size(235, 38);
            label14.TabIndex = 26;
            label14.Text = "Search Book Data";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 211);
            label4.Name = "label4";
            label4.Size = new Size(217, 38);
            label4.TabIndex = 24;
            label4.Text = "No. Of Requests";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(107, 148);
            label5.Name = "label5";
            label5.Size = new Size(117, 38);
            label5.TabIndex = 21;
            label5.Text = "ISBN-13";
            // 
            // textBoxAuthorName
            // 
            textBoxAuthorName.Location = new Point(260, 288);
            textBoxAuthorName.Name = "textBoxAuthorName";
            textBoxAuthorName.Size = new Size(266, 27);
            textBoxAuthorName.TabIndex = 10;
            // 
            // buttonSubmit
            // 
            buttonSubmit.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSubmit.Location = new Point(339, 348);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(113, 38);
            buttonSubmit.TabIndex = 19;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(75, 43);
            label2.Name = "label2";
            label2.Size = new Size(135, 38);
            label2.TabIndex = 5;
            label2.Text = "StudentId";
            // 
            // textBoxStudentId
            // 
            textBoxStudentId.Location = new Point(260, 55);
            textBoxStudentId.Name = "textBoxStudentId";
            textBoxStudentId.Size = new Size(266, 27);
            textBoxStudentId.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(140, 94);
            label1.Name = "label1";
            label1.Size = new Size(70, 38);
            label1.TabIndex = 7;
            label1.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(45, 277);
            label3.Name = "label3";
            label3.Size = new Size(184, 38);
            label3.TabIndex = 9;
            label3.Text = "Author Name";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(buttonRemove);
            panel3.Controls.Add(textBoxWishListNoOfRequests);
            panel3.Controls.Add(textBoxWishListISBN13);
            panel3.Controls.Add(textBoxWishListTitle);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(textBoxWishListAuthorName);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(textBoxWishListStudentId);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(buttonAddBook);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(71, 586);
            panel3.Name = "panel3";
            panel3.Size = new Size(1210, 290);
            panel3.TabIndex = 26;
            // 
            // buttonRemove
            // 
            buttonRemove.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonRemove.Location = new Point(612, 224);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(196, 38);
            buttonRemove.TabIndex = 41;
            buttonRemove.Text = "Remove Book";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // textBoxWishListNoOfRequests
            // 
            textBoxWishListNoOfRequests.Location = new Point(791, 63);
            textBoxWishListNoOfRequests.Name = "textBoxWishListNoOfRequests";
            textBoxWishListNoOfRequests.ReadOnly = true;
            textBoxWishListNoOfRequests.Size = new Size(266, 27);
            textBoxWishListNoOfRequests.TabIndex = 40;
            // 
            // textBoxWishListISBN13
            // 
            textBoxWishListISBN13.Location = new Point(200, 159);
            textBoxWishListISBN13.Name = "textBoxWishListISBN13";
            textBoxWishListISBN13.ReadOnly = true;
            textBoxWishListISBN13.Size = new Size(266, 27);
            textBoxWishListISBN13.TabIndex = 39;
            // 
            // textBoxWishListTitle
            // 
            textBoxWishListTitle.Location = new Point(200, 111);
            textBoxWishListTitle.Name = "textBoxWishListTitle";
            textBoxWishListTitle.ReadOnly = true;
            textBoxWishListTitle.Size = new Size(266, 27);
            textBoxWishListTitle.TabIndex = 38;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(543, 52);
            label7.Name = "label7";
            label7.Size = new Size(217, 38);
            label7.TabIndex = 37;
            label7.Text = "No. Of Requests";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(47, 148);
            label8.Name = "label8";
            label8.Size = new Size(117, 38);
            label8.TabIndex = 36;
            label8.Text = "ISBN-13";
            // 
            // textBoxWishListAuthorName
            // 
            textBoxWishListAuthorName.Location = new Point(791, 138);
            textBoxWishListAuthorName.Name = "textBoxWishListAuthorName";
            textBoxWishListAuthorName.ReadOnly = true;
            textBoxWishListAuthorName.Size = new Size(266, 27);
            textBoxWishListAuthorName.TabIndex = 35;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(15, 53);
            label9.Name = "label9";
            label9.Size = new Size(135, 38);
            label9.TabIndex = 31;
            label9.Text = "StudentId";
            // 
            // textBoxWishListStudentId
            // 
            textBoxWishListStudentId.Location = new Point(200, 65);
            textBoxWishListStudentId.Name = "textBoxWishListStudentId";
            textBoxWishListStudentId.ReadOnly = true;
            textBoxWishListStudentId.Size = new Size(266, 27);
            textBoxWishListStudentId.TabIndex = 32;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(80, 100);
            label10.Name = "label10";
            label10.Size = new Size(70, 38);
            label10.TabIndex = 33;
            label10.Text = "Title";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(576, 127);
            label11.Name = "label11";
            label11.Size = new Size(184, 38);
            label11.TabIndex = 34;
            label11.Text = "Author Name";
            // 
            // buttonAddBook
            // 
            buttonAddBook.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAddBook.Location = new Point(837, 224);
            buttonAddBook.Name = "buttonAddBook";
            buttonAddBook.Size = new Size(196, 38);
            buttonAddBook.TabIndex = 30;
            buttonAddBook.Text = "Add Book";
            buttonAddBook.UseVisualStyleBackColor = true;
            buttonAddBook.Click += buttonAddBook_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(467, 15);
            label6.Name = "label6";
            label6.Size = new Size(120, 31);
            label6.TabIndex = 0;
            label6.Text = "Add Book";
            // 
            // WishListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1409, 897);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(dataGridViewBooks);
            Name = "WishListForm";
            Text = "WishListForm";
            Load += WishListForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewBooks;
        private Panel panel2;
        private Label label14;
        private Label label4;
        private Label label5;
        private TextBox textBoxAuthorName;
        private Button buttonSubmit;
        private Label label2;
        private TextBox textBoxStudentId;
        private Label label1;
        private Label label3;
        private Panel panel3;
        private Button buttonAddBook;
        private Label label6;
        private TextBox textBoxNoOfRequests;
        private TextBox textBoxISBN13;
        private TextBox textBoxTitle;
        private TextBox textBoxWishListNoOfRequests;
        private TextBox textBoxWishListISBN13;
        private TextBox textBoxWishListTitle;
        private Label label7;
        private Label label8;
        private TextBox textBoxWishListAuthorName;
        private Label label9;
        private TextBox textBoxWishListStudentId;
        private Label label10;
        private Label label11;
        private Button buttonRemove;
    }
}