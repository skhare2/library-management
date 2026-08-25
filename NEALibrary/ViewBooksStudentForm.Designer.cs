namespace NEALibrary
{
    partial class ViewBooksStudentForm
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
            panel2 = new Panel();
            comboBoxFictionStatus = new ComboBox();
            label4 = new Label();
            comboBoxAgeGroup = new ComboBox();
            comboBoxGenre = new ComboBox();
            label5 = new Label();
            textBoxAuthorName = new TextBox();
            buttonSubmit = new Button();
            label2 = new Label();
            textBoxTitle = new TextBox();
            label1 = new Label();
            label3 = new Label();
            dataGridViewBooks = new DataGridView();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
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
            panel2.Location = new Point(12, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(555, 387);
            panel2.TabIndex = 21;
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
            // textBoxAuthorName
            // 
            textBoxAuthorName.Location = new Point(260, 105);
            textBoxAuthorName.Name = "textBoxAuthorName";
            textBoxAuthorName.Size = new Size(266, 27);
            textBoxAuthorName.TabIndex = 10;
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
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(260, 55);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(266, 27);
            textBoxTitle.TabIndex = 6;
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
            // dataGridViewBooks
            // 
            dataGridViewBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBooks.Location = new Point(609, 30);
            dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewBooks.RowHeadersWidth = 51;
            dataGridViewBooks.Size = new Size(767, 570);
            dataGridViewBooks.TabIndex = 22;
            // 
            // ViewBooksStudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1388, 612);
            Controls.Add(dataGridViewBooks);
            Controls.Add(panel2);
            Name = "ViewBooksStudentForm";
            Text = "ViewBooksStudentForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private ComboBox comboBoxFictionStatus;
        private Label label4;
        private ComboBox comboBoxAgeGroup;
        private ComboBox comboBoxGenre;
        private Label label5;
        private TextBox textBoxAuthorName;
        private Button buttonSubmit;
        private Label label2;
        private TextBox textBoxTitle;
        private Label label1;
        private Label label3;
        private DataGridView dataGridViewBooks;
    }
}