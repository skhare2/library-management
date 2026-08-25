namespace NEALibrary
{
    partial class StudentReservationForm
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
            dataGridViewBooks = new DataGridView();
            panel2 = new Panel();
            label14 = new Label();
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
            panel3 = new Panel();
            textBoxReserveAgeGroup = new TextBox();
            textBoxReserveFictionStatus = new TextBox();
            textBoxReserveGenre = new TextBox();
            buttonViewAvailability = new Button();
            buttonReserve = new Button();
            label13 = new Label();
            label11 = new Label();
            label10 = new Label();
            textBoxReserveAuthorName = new TextBox();
            label12 = new Label();
            label8 = new Label();
            textBoxReserveNumberOfCopies = new TextBox();
            label7 = new Label();
            label6 = new Label();
            textBoxReserveTitle = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Blue;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1314, 55);
            panel1.TabIndex = 17;
            // 
            // dataGridViewBooks
            // 
            dataGridViewBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBooks.Location = new Point(635, 61);
            dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewBooks.RowHeadersWidth = 51;
            dataGridViewBooks.Size = new Size(654, 607);
            dataGridViewBooks.TabIndex = 22;
            dataGridViewBooks.CellClick += dataGridViewBooks_CellClick_1;
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
            panel2.Location = new Point(25, 99);
            panel2.Name = "panel2";
            panel2.Size = new Size(555, 398);
            panel2.TabIndex = 23;
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
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(textBoxReserveAgeGroup);
            panel3.Controls.Add(textBoxReserveFictionStatus);
            panel3.Controls.Add(textBoxReserveGenre);
            panel3.Controls.Add(buttonViewAvailability);
            panel3.Controls.Add(buttonReserve);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(textBoxReserveAuthorName);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(textBoxReserveNumberOfCopies);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(textBoxReserveTitle);
            panel3.Location = new Point(70, 674);
            panel3.Name = "panel3";
            panel3.Size = new Size(1210, 278);
            panel3.TabIndex = 24;
            // 
            // textBoxReserveAgeGroup
            // 
            textBoxReserveAgeGroup.Location = new Point(823, 184);
            textBoxReserveAgeGroup.Name = "textBoxReserveAgeGroup";
            textBoxReserveAgeGroup.ReadOnly = true;
            textBoxReserveAgeGroup.Size = new Size(266, 27);
            textBoxReserveAgeGroup.TabIndex = 33;
            // 
            // textBoxReserveFictionStatus
            // 
            textBoxReserveFictionStatus.Location = new Point(823, 131);
            textBoxReserveFictionStatus.Name = "textBoxReserveFictionStatus";
            textBoxReserveFictionStatus.ReadOnly = true;
            textBoxReserveFictionStatus.Size = new Size(266, 27);
            textBoxReserveFictionStatus.TabIndex = 32;
            // 
            // textBoxReserveGenre
            // 
            textBoxReserveGenre.Location = new Point(823, 74);
            textBoxReserveGenre.Name = "textBoxReserveGenre";
            textBoxReserveGenre.ReadOnly = true;
            textBoxReserveGenre.Size = new Size(266, 27);
            textBoxReserveGenre.TabIndex = 31;
            // 
            // buttonViewAvailability
            // 
            buttonViewAvailability.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonViewAvailability.Location = new Point(699, 233);
            buttonViewAvailability.Name = "buttonViewAvailability";
            buttonViewAvailability.Size = new Size(196, 38);
            buttonViewAvailability.TabIndex = 30;
            buttonViewAvailability.Text = "View Availability";
            buttonViewAvailability.UseVisualStyleBackColor = true;
            buttonViewAvailability.Click += buttonViewAvailability_Click;
            // 
            // buttonReserve
            // 
            buttonReserve.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonReserve.Location = new Point(912, 233);
            buttonReserve.Name = "buttonReserve";
            buttonReserve.Size = new Size(113, 38);
            buttonReserve.TabIndex = 26;
            buttonReserve.Text = "Reserve";
            buttonReserve.UseVisualStyleBackColor = true;
            buttonReserve.Click += buttonReserve_Click;
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
            label10.Location = new Point(80, 173);
            label10.Name = "label10";
            label10.Size = new Size(184, 38);
            label10.TabIndex = 27;
            label10.Text = "Author Name";
            // 
            // textBoxReserveAuthorName
            // 
            textBoxReserveAuthorName.Location = new Point(279, 184);
            textBoxReserveAuthorName.Name = "textBoxReserveAuthorName";
            textBoxReserveAuthorName.ReadOnly = true;
            textBoxReserveAuthorName.Size = new Size(266, 27);
            textBoxReserveAuthorName.TabIndex = 28;
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(30, 119);
            label8.Name = "label8";
            label8.Size = new Size(243, 38);
            label8.TabIndex = 25;
            label8.Text = "Number of Copies";
            // 
            // textBoxReserveNumberOfCopies
            // 
            textBoxReserveNumberOfCopies.Location = new Point(279, 130);
            textBoxReserveNumberOfCopies.Name = "textBoxReserveNumberOfCopies";
            textBoxReserveNumberOfCopies.ReadOnly = true;
            textBoxReserveNumberOfCopies.Size = new Size(266, 27);
            textBoxReserveNumberOfCopies.TabIndex = 26;
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
            label6.Size = new Size(158, 31);
            label6.TabIndex = 0;
            label6.Text = "Reserve Book";
            // 
            // textBoxReserveTitle
            // 
            textBoxReserveTitle.Location = new Point(279, 70);
            textBoxReserveTitle.Name = "textBoxReserveTitle";
            textBoxReserveTitle.ReadOnly = true;
            textBoxReserveTitle.Size = new Size(266, 27);
            textBoxReserveTitle.TabIndex = 24;
            // 
            // StudentReservationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1314, 954);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(dataGridViewBooks);
            Controls.Add(panel1);
            Name = "StudentReservationForm";
            Text = "StudentReservationForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridViewBooks;
        private Panel panel2;
        private Label label14;
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
        private Panel panel3;
        private Button buttonReserve;
        private Label label13;
        private Label label11;
        private Label label10;
        private TextBox textBoxReserveAuthorName;
        private Label label12;
        private Label label8;
        private TextBox textBoxReserveNumberOfCopies;
        private Label label7;
        private Label label6;
        private TextBox textBoxReserveTitle;
        private Button buttonViewAvailability;
        private TextBox textBoxReserveAgeGroup;
        private TextBox textBoxReserveFictionStatus;
        private TextBox textBoxReserveGenre;
    }
}