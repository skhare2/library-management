namespace NEALibrary
{
    partial class AddBooksForm
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
            buttonSubmit = new Button();
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
            textBoxUpdateTitle = new TextBox();
            panel2 = new Panel();
            buttonDecimal = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonDecimal);
            panel1.Controls.Add(buttonSubmit);
            panel1.Controls.Add(comboBoxUpdateAgeGroup);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(comboBoxUpdateFictionStatus);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(comboBoxUpdateGenre);
            panel1.Controls.Add(textBoxUpdateAuthorName);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(textBoxUpdatePrice);
            panel1.Controls.Add(textBoxUpdateNumberOfCopies);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textBoxUpdateTitle);
            panel1.Location = new Point(12, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(1117, 331);
            panel1.TabIndex = 0;
            // 
            // buttonSubmit
            // 
            buttonSubmit.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSubmit.Location = new Point(937, 224);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(113, 38);
            buttonSubmit.TabIndex = 36;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // comboBoxUpdateAgeGroup
            // 
            comboBoxUpdateAgeGroup.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxUpdateAgeGroup.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxUpdateAgeGroup.FormattingEnabled = true;
            comboBoxUpdateAgeGroup.Items.AddRange(new object[] { "Newborn to Age 4", "Ages 2–5", "Ages 5–8", "Ages 4–8", "Ages 6–9", "Ages 8–12", "Ages 12–18", "Mature" });
            comboBoxUpdateAgeGroup.Location = new Point(848, 174);
            comboBoxUpdateAgeGroup.Name = "comboBoxUpdateAgeGroup";
            comboBoxUpdateAgeGroup.Size = new Size(266, 28);
            comboBoxUpdateAgeGroup.TabIndex = 33;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(675, 163);
            label13.Name = "label13";
            label13.Size = new Size(151, 38);
            label13.TabIndex = 31;
            label13.Text = "Age Group";
            // 
            // comboBoxUpdateFictionStatus
            // 
            comboBoxUpdateFictionStatus.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxUpdateFictionStatus.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxUpdateFictionStatus.FormattingEnabled = true;
            comboBoxUpdateFictionStatus.Items.AddRange(new object[] { "Fiction", "Non-fiction", "None" });
            comboBoxUpdateFictionStatus.Location = new Point(848, 121);
            comboBoxUpdateFictionStatus.Name = "comboBoxUpdateFictionStatus";
            comboBoxUpdateFictionStatus.Size = new Size(266, 28);
            comboBoxUpdateFictionStatus.TabIndex = 44;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(575, 110);
            label11.Name = "label11";
            label11.Size = new Size(251, 38);
            label11.TabIndex = 42;
            label11.Text = "Fiction/Non-fiction";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(54, 235);
            label10.Name = "label10";
            label10.Size = new Size(184, 38);
            label10.TabIndex = 40;
            label10.Text = "Author Name";
            // 
            // comboBoxUpdateGenre
            // 
            comboBoxUpdateGenre.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxUpdateGenre.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxUpdateGenre.FormattingEnabled = true;
            comboBoxUpdateGenre.Items.AddRange(new object[] { "Action and Adventure", "Classics", "Comic Book or Graphic Novel", "Detective and Mystery", "Fantasy", "Historical Fiction", "Horror", "Romance", "Science Fiction (Sci-Fi)", "Short Stories", "Suspense and Thrillers", "Biographies and Autobiographies", "Cookbooks", "Essays", "History", "Memoir", "Poetry", "Self-Help", "True Crime" });
            comboBoxUpdateGenre.Location = new Point(848, 64);
            comboBoxUpdateGenre.Name = "comboBoxUpdateGenre";
            comboBoxUpdateGenre.Size = new Size(266, 28);
            comboBoxUpdateGenre.TabIndex = 41;
            // 
            // textBoxUpdateAuthorName
            // 
            textBoxUpdateAuthorName.Location = new Point(253, 246);
            textBoxUpdateAuthorName.Name = "textBoxUpdateAuthorName";
            textBoxUpdateAuthorName.Size = new Size(266, 27);
            textBoxUpdateAuthorName.TabIndex = 43;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(725, 53);
            label12.Name = "label12";
            label12.Size = new Size(92, 38);
            label12.TabIndex = 37;
            label12.Text = "Genre";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(32, 135);
            label9.Name = "label9";
            label9.Size = new Size(198, 38);
            label9.TabIndex = 34;
            label9.Text = "Price (decimal)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(4, 84);
            label8.Name = "label8";
            label8.Size = new Size(243, 38);
            label8.TabIndex = 35;
            label8.Text = "Number of Copies";
            // 
            // textBoxUpdatePrice
            // 
            textBoxUpdatePrice.Location = new Point(253, 146);
            textBoxUpdatePrice.Name = "textBoxUpdatePrice";
            textBoxUpdatePrice.Size = new Size(266, 27);
            textBoxUpdatePrice.TabIndex = 38;
            // 
            // textBoxUpdateNumberOfCopies
            // 
            textBoxUpdateNumberOfCopies.Location = new Point(253, 95);
            textBoxUpdateNumberOfCopies.Name = "textBoxUpdateNumberOfCopies";
            textBoxUpdateNumberOfCopies.Size = new Size(266, 27);
            textBoxUpdateNumberOfCopies.TabIndex = 39;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(160, 33);
            label7.Name = "label7";
            label7.Size = new Size(70, 38);
            label7.TabIndex = 30;
            label7.Text = "Title";
            // 
            // textBoxUpdateTitle
            // 
            textBoxUpdateTitle.Location = new Point(253, 44);
            textBoxUpdateTitle.Name = "textBoxUpdateTitle";
            textBoxUpdateTitle.Size = new Size(266, 27);
            textBoxUpdateTitle.TabIndex = 32;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Blue;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1197, 55);
            panel2.TabIndex = 18;
            // 
            // buttonDecimal
            // 
            buttonDecimal.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDecimal.Location = new Point(342, 179);
            buttonDecimal.Name = "buttonDecimal";
            buttonDecimal.Size = new Size(74, 38);
            buttonDecimal.TabIndex = 45;
            buttonDecimal.Text = ".00";
            buttonDecimal.UseVisualStyleBackColor = true;
            buttonDecimal.Click += buttonDecimal_Click;
            // 
            // AddBooksForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 420);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AddBooksForm";
            Text = "AddBooksForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonSubmit;
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
        private Panel panel2;
        private Button buttonDecimal;
    }
}