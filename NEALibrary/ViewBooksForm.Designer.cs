namespace NEALibrary
{
    partial class ViewBooksForm
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
            textBoxTitle = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBoxAuthorName = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            buttonSubmit = new Button();
            panel2 = new Panel();
            label14 = new Label();
            comboBoxFictionStatus = new ComboBox();
            label4 = new Label();
            comboBoxAgeGroup = new ComboBox();
            comboBoxGenre = new ComboBox();
            label5 = new Label();
            dataGridViewBooks = new DataGridView();
            panel3 = new Panel();
            buttonUpdate = new Button();
            comboBoxUpdateAgeGroup = new ComboBox();
            label13 = new Label();
            comboBoxUpdateFictionStatus = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            comboBoxUpdateGenre = new ComboBox();
            textBoxUpdateAuthorName = new TextBox();
            label12 = new Label();
            label9 = new Label();
            label8 = new Label();
            textBoxUpdatePrice = new TextBox();
            textBoxUpdateNumberOfCopies = new TextBox();
            label7 = new Label();
            label6 = new Label();
            textBoxUpdateTitle = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(260, 55);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(266, 27);
            textBoxTitle.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(126, 43);
            label2.Name = "label2";
            label2.Size = new Size(70, 38);
            label2.TabIndex = 5;
            label2.Text = "Title";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 148);
            label1.Name = "label1";
            label1.Size = new Size(151, 38);
            label1.TabIndex = 7;
            label1.Text = "Age Group";
            // 
            // textBoxAuthorName
            // 
            textBoxAuthorName.Location = new Point(260, 105);
            textBoxAuthorName.Name = "textBoxAuthorName";
            textBoxAuthorName.Size = new Size(266, 27);
            textBoxAuthorName.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 93);
            label3.Name = "label3";
            label3.Size = new Size(184, 38);
            label3.TabIndex = 9;
            label3.Text = "Author Name";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Blue;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1281, 55);
            panel1.TabIndex = 18;
            // 
            // buttonSubmit
            // 
            buttonSubmit.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSubmit.Location = new Point(329, 321);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(113, 38);
            buttonSubmit.TabIndex = 19;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label14);
            panel2.Controls.Add(comboBoxFictionStatus);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(comboBoxAgeGroup);
            panel2.Controls.Add(comboBoxGenre);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textBoxAuthorName);
            panel2.Controls.Add(buttonSubmit);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBoxTitle);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(17, 165);
            panel2.Name = "panel2";
            panel2.Size = new Size(555, 398);
            panel2.TabIndex = 20;
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
            // comboBoxFictionStatus
            // 
            comboBoxFictionStatus.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxFictionStatus.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxFictionStatus.FormattingEnabled = true;
            comboBoxFictionStatus.Items.AddRange(new object[] { "Fiction", "Non-fiction", "None" });
            comboBoxFictionStatus.Location = new Point(260, 272);
            comboBoxFictionStatus.Name = "comboBoxFictionStatus";
            comboBoxFictionStatus.Size = new Size(266, 28);
            comboBoxFictionStatus.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(0, 261);
            label4.Name = "label4";
            label4.Size = new Size(251, 38);
            label4.TabIndex = 24;
            label4.Text = "Fiction/Non-fiction";
            // 
            // comboBoxAgeGroup
            // 
            comboBoxAgeGroup.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxAgeGroup.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxAgeGroup.FormattingEnabled = true;
            comboBoxAgeGroup.Items.AddRange(new object[] { "Newborn to Age 4", "Ages 2–5", "Ages 5–8", "Ages 4–8", "Ages 6–9", "Ages 8–12", "Ages 12–18", "Mature" });
            comboBoxAgeGroup.Location = new Point(260, 159);
            comboBoxAgeGroup.Name = "comboBoxAgeGroup";
            comboBoxAgeGroup.Size = new Size(266, 28);
            comboBoxAgeGroup.TabIndex = 23;
            // 
            // comboBoxGenre
            // 
            comboBoxGenre.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxGenre.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxGenre.FormattingEnabled = true;
            comboBoxGenre.Items.AddRange(new object[] { "Action and Adventure", "Classics", "Comic Book or Graphic Novel", "Detective and Mystery", "Fantasy", "Historical Fiction", "Horror", "Romance", "Science Fiction (Sci-Fi)", "Short Stories", "Suspense and Thrillers", "Biographies and Autobiographies", "Cookbooks", "Essays", "History", "Memoir", "Poetry", "Self-Help", "True Crime" });
            comboBoxGenre.Location = new Point(260, 215);
            comboBoxGenre.Name = "comboBoxGenre";
            comboBoxGenre.Size = new Size(266, 28);
            comboBoxGenre.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(45, 204);
            label5.Name = "label5";
            label5.Size = new Size(92, 38);
            label5.TabIndex = 21;
            label5.Text = "Genre";
            // 
            // dataGridViewBooks
            // 
            dataGridViewBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBooks.Location = new Point(582, 84);
            dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewBooks.RowHeadersWidth = 51;
            dataGridViewBooks.Size = new Size(654, 576);
            dataGridViewBooks.TabIndex = 21;
            dataGridViewBooks.CellClick += dataGridViewBooks_CellClick;
            dataGridViewBooks.CellContentClick += dataGridViewBooks_CellContentClick;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(buttonUpdate);
            panel3.Controls.Add(comboBoxUpdateAgeGroup);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(comboBoxUpdateFictionStatus);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(comboBoxUpdateGenre);
            panel3.Controls.Add(textBoxUpdateAuthorName);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(textBoxUpdatePrice);
            panel3.Controls.Add(textBoxUpdateNumberOfCopies);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(textBoxUpdateTitle);
            panel3.Location = new Point(26, 666);
            panel3.Name = "panel3";
            panel3.Size = new Size(1210, 290);
            panel3.TabIndex = 22;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonUpdate.Location = new Point(912, 233);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(113, 38);
            buttonUpdate.TabIndex = 26;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // comboBoxUpdateAgeGroup
            // 
            comboBoxUpdateAgeGroup.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxUpdateAgeGroup.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxUpdateAgeGroup.FormattingEnabled = true;
            comboBoxUpdateAgeGroup.Items.AddRange(new object[] { "Newborn to Age 4", "Ages 2–5", "Ages 5–8", "Ages 4–8", "Ages 6–9", "Ages 8–12", "Ages 12–18", "Mature" });
            comboBoxUpdateAgeGroup.Location = new Point(823, 183);
            comboBoxUpdateAgeGroup.Name = "comboBoxUpdateAgeGroup";
            comboBoxUpdateAgeGroup.Size = new Size(266, 28);
            comboBoxUpdateAgeGroup.TabIndex = 25;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(649, 173);
            label13.Name = "label13";
            label13.Size = new Size(151, 38);
            label13.TabIndex = 24;
            label13.Text = "Age Group";
            // 
            // comboBoxUpdateFictionStatus
            // 
            comboBoxUpdateFictionStatus.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxUpdateFictionStatus.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxUpdateFictionStatus.FormattingEnabled = true;
            comboBoxUpdateFictionStatus.Items.AddRange(new object[] { "Fiction", "Non-fiction", "None" });
            comboBoxUpdateFictionStatus.Location = new Point(823, 130);
            comboBoxUpdateFictionStatus.Name = "comboBoxUpdateFictionStatus";
            comboBoxUpdateFictionStatus.Size = new Size(266, 28);
            comboBoxUpdateFictionStatus.TabIndex = 29;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(549, 120);
            label11.Name = "label11";
            label11.Size = new Size(251, 38);
            label11.TabIndex = 28;
            label11.Text = "Fiction/Non-fiction";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(80, 213);
            label10.Name = "label10";
            label10.Size = new Size(184, 38);
            label10.TabIndex = 27;
            label10.Text = "Author Name";
            // 
            // comboBoxUpdateGenre
            // 
            comboBoxUpdateGenre.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxUpdateGenre.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxUpdateGenre.FormattingEnabled = true;
            comboBoxUpdateGenre.Items.AddRange(new object[] { "Action and Adventure", "Classics", "Comic Book or Graphic Novel", "Detective and Mystery", "Fantasy", "Historical Fiction", "Horror", "Romance", "Science Fiction (Sci-Fi)", "Short Stories", "Suspense and Thrillers", "Biographies and Autobiographies", "Cookbooks", "Essays", "History", "Memoir", "Poetry", "Self-Help", "True Crime" });
            comboBoxUpdateGenre.Location = new Point(823, 73);
            comboBoxUpdateGenre.Name = "comboBoxUpdateGenre";
            comboBoxUpdateGenre.Size = new Size(266, 28);
            comboBoxUpdateGenre.TabIndex = 27;
            // 
            // textBoxUpdateAuthorName
            // 
            textBoxUpdateAuthorName.Location = new Point(279, 224);
            textBoxUpdateAuthorName.Name = "textBoxUpdateAuthorName";
            textBoxUpdateAuthorName.Size = new Size(266, 27);
            textBoxUpdateAuthorName.TabIndex = 28;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(699, 63);
            label12.Name = "label12";
            label12.Size = new Size(92, 38);
            label12.TabIndex = 26;
            label12.Text = "Genre";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(186, 161);
            label9.Name = "label9";
            label9.Size = new Size(78, 38);
            label9.TabIndex = 25;
            label9.Text = "Price";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(30, 110);
            label8.Name = "label8";
            label8.Size = new Size(243, 38);
            label8.TabIndex = 25;
            label8.Text = "Number of Copies";
            // 
            // textBoxUpdatePrice
            // 
            textBoxUpdatePrice.Location = new Point(279, 172);
            textBoxUpdatePrice.Name = "textBoxUpdatePrice";
            textBoxUpdatePrice.Size = new Size(266, 27);
            textBoxUpdatePrice.TabIndex = 26;
            // 
            // textBoxUpdateNumberOfCopies
            // 
            textBoxUpdateNumberOfCopies.Location = new Point(279, 121);
            textBoxUpdateNumberOfCopies.Name = "textBoxUpdateNumberOfCopies";
            textBoxUpdateNumberOfCopies.ReadOnly = true;
            textBoxUpdateNumberOfCopies.Size = new Size(266, 27);
            textBoxUpdateNumberOfCopies.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(186, 59);
            label7.Name = "label7";
            label7.Size = new Size(70, 38);
            label7.TabIndex = 23;
            label7.Text = "Title";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(450, 19);
            label6.Name = "label6";
            label6.Size = new Size(174, 31);
            label6.TabIndex = 0;
            label6.Text = "Edit Book Data";
            // 
            // textBoxUpdateTitle
            // 
            textBoxUpdateTitle.Location = new Point(279, 70);
            textBoxUpdateTitle.Name = "textBoxUpdateTitle";
            textBoxUpdateTitle.Size = new Size(266, 27);
            textBoxUpdateTitle.TabIndex = 24;
            // 
            // ViewBooksForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1281, 958);
            Controls.Add(panel3);
            Controls.Add(dataGridViewBooks);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ViewBooksForm";
            Text = "ViewBooksForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxTitle;
        private Label label2;
        private Label label1;
        private TextBox textBoxAuthorName;
        private Label label3;
        private Panel panel1;
        private Button buttonSubmit;
        private Panel panel2;
        private DataGridView dataGridViewBooks;
        private ComboBox comboBoxGenre;
        private Label label5;
        private ComboBox comboBoxAgeGroup;
        private ComboBox comboBoxFictionStatus;
        private Label label4;
        private Panel panel3;
        private Label label6;
        private Button buttonUpdate;
        private ComboBox comboBoxUpdateAgeGroup;
        private Label label13;
        private ComboBox comboBoxUpdateFictionStatus;
        private Label label11;
        private Label label10;
        private ComboBox comboBoxUpdateGenre;
        private TextBox textBoxUpdateAuthorName;
        private Label label12;
        private Label label9;
        private Label label8;
        private TextBox textBoxUpdatePrice;
        private TextBox textBoxUpdateNumberOfCopies;
        private Label label7;
        private TextBox textBoxUpdateTitle;
        private Label label14;
    }
}