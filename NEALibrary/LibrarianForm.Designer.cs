namespace NEALibrary
{
    partial class LibrarianForm
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
            label2 = new Label();
            textBoxFirstName = new TextBox();
            dataGridViewLibrarian = new DataGridView();
            label14 = new Label();
            textBoxLastName = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxUsername = new TextBox();
            dateTimePickerDOB = new DateTimePicker();
            label5 = new Label();
            textBoxPassword = new TextBox();
            label6 = new Label();
            textBoxEmail = new TextBox();
            label7 = new Label();
            textBoxEditEmail = new TextBox();
            labelPassword = new Label();
            textBoxEditPassword = new TextBox();
            dateTimePickerEditDOB = new DateTimePicker();
            label9 = new Label();
            textBoxEditUsername = new TextBox();
            label10 = new Label();
            label11 = new Label();
            textBoxEditLastName = new TextBox();
            button1 = new Button();
            label12 = new Label();
            textBoxEditFirstName = new TextBox();
            label13 = new Label();
            buttonEdit = new Button();
            label15 = new Label();
            comboBoxEditAdmin = new ComboBox();
            comboBoxAdmin = new ComboBox();
            label16 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            buttonNewPassword = new Button();
            buttonChange = new Button();
            buttonRemove = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLibrarian).BeginInit();
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
            panel1.Size = new Size(1382, 55);
            panel1.TabIndex = 20;
            // 
            // buttonSubmit
            // 
            buttonSubmit.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSubmit.Location = new Point(290, 547);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(113, 38);
            buttonSubmit.TabIndex = 26;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 79);
            label2.Name = "label2";
            label2.Size = new Size(151, 38);
            label2.TabIndex = 24;
            label2.Text = "First Name";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(235, 90);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(266, 27);
            textBoxFirstName.TabIndex = 25;
            // 
            // dataGridViewLibrarian
            // 
            dataGridViewLibrarian.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLibrarian.Location = new Point(558, 61);
            dataGridViewLibrarian.Name = "dataGridViewLibrarian";
            dataGridViewLibrarian.ReadOnly = true;
            dataGridViewLibrarian.RowHeadersWidth = 51;
            dataGridViewLibrarian.Size = new Size(799, 588);
            dataGridViewLibrarian.TabIndex = 27;
            dataGridViewLibrarian.CellClick += dataGridViewLibrarian_CellClick;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(141, 15);
            label14.Name = "label14";
            label14.Size = new Size(182, 38);
            label14.TabIndex = 28;
            label14.Text = "Add Librarian";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(235, 160);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(266, 27);
            textBoxLastName.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 149);
            label1.Name = "label1";
            label1.Size = new Size(147, 38);
            label1.TabIndex = 30;
            label1.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 217);
            label3.Name = "label3";
            label3.Size = new Size(92, 38);
            label3.TabIndex = 32;
            label3.Text = "D.O.B.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(29, 279);
            label4.Name = "label4";
            label4.Size = new Size(142, 38);
            label4.TabIndex = 34;
            label4.Text = "Username";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(235, 290);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(266, 27);
            textBoxUsername.TabIndex = 33;
            // 
            // dateTimePickerDOB
            // 
            dateTimePickerDOB.Location = new Point(235, 228);
            dateTimePickerDOB.Name = "dateTimePickerDOB";
            dateTimePickerDOB.Size = new Size(266, 27);
            dateTimePickerDOB.TabIndex = 35;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(29, 345);
            label5.Name = "label5";
            label5.Size = new Size(132, 38);
            label5.TabIndex = 37;
            label5.Text = "Password";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(235, 356);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(266, 27);
            textBoxPassword.TabIndex = 36;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(52, 422);
            label6.Name = "label6";
            label6.Size = new Size(83, 38);
            label6.TabIndex = 39;
            label6.Text = "Email";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(235, 433);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(266, 27);
            textBoxEmail.TabIndex = 38;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(607, 105);
            label7.Name = "label7";
            label7.Size = new Size(83, 38);
            label7.TabIndex = 52;
            label7.Text = "Email";
            // 
            // textBoxEditEmail
            // 
            textBoxEditEmail.Location = new Point(790, 116);
            textBoxEditEmail.Name = "textBoxEditEmail";
            textBoxEditEmail.Size = new Size(266, 27);
            textBoxEditEmail.TabIndex = 51;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPassword.Location = new Point(392, 261);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(132, 38);
            labelPassword.TabIndex = 50;
            labelPassword.Text = "Password";
            // 
            // textBoxEditPassword
            // 
            textBoxEditPassword.Location = new Point(530, 272);
            textBoxEditPassword.Name = "textBoxEditPassword";
            textBoxEditPassword.PasswordChar = '*';
            textBoxEditPassword.Size = new Size(266, 27);
            textBoxEditPassword.TabIndex = 49;
            // 
            // dateTimePickerEditDOB
            // 
            dateTimePickerEditDOB.Location = new Point(231, 162);
            dateTimePickerEditDOB.Name = "dateTimePickerEditDOB";
            dateTimePickerEditDOB.Size = new Size(266, 27);
            dateTimePickerEditDOB.TabIndex = 48;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(584, 59);
            label9.Name = "label9";
            label9.Size = new Size(142, 38);
            label9.TabIndex = 47;
            label9.Text = "Username";
            // 
            // textBoxEditUsername
            // 
            textBoxEditUsername.Location = new Point(790, 70);
            textBoxEditUsername.Name = "textBoxEditUsername";
            textBoxEditUsername.Size = new Size(266, 27);
            textBoxEditUsername.TabIndex = 46;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(25, 151);
            label10.Name = "label10";
            label10.Size = new Size(92, 38);
            label10.TabIndex = 45;
            label10.Text = "D.O.B.";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(25, 105);
            label11.Name = "label11";
            label11.Size = new Size(147, 38);
            label11.TabIndex = 44;
            label11.Text = "Last Name";
            // 
            // textBoxEditLastName
            // 
            textBoxEditLastName.Location = new Point(231, 116);
            textBoxEditLastName.Name = "textBoxEditLastName";
            textBoxEditLastName.Size = new Size(266, 27);
            textBoxEditLastName.TabIndex = 43;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(808, 1055);
            button1.Name = "button1";
            button1.Size = new Size(113, 38);
            button1.TabIndex = 42;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(50, 59);
            label12.Name = "label12";
            label12.Size = new Size(151, 38);
            label12.TabIndex = 40;
            label12.Text = "First Name";
            // 
            // textBoxEditFirstName
            // 
            textBoxEditFirstName.Location = new Point(231, 70);
            textBoxEditFirstName.Name = "textBoxEditFirstName";
            textBoxEditFirstName.Size = new Size(266, 27);
            textBoxEditFirstName.TabIndex = 41;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(437, 15);
            label13.Name = "label13";
            label13.Size = new Size(306, 38);
            label13.TabIndex = 53;
            label13.Text = "Change Librarian Detail";
            // 
            // buttonEdit
            // 
            buttonEdit.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEdit.Location = new Point(303, 206);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(113, 38);
            buttonEdit.TabIndex = 54;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(601, 154);
            label15.Name = "label15";
            label15.Size = new Size(125, 38);
            label15.TabIndex = 55;
            label15.Text = "Is Admin";
            // 
            // comboBoxEditAdmin
            // 
            comboBoxEditAdmin.FormattingEnabled = true;
            comboBoxEditAdmin.Items.AddRange(new object[] { "True", "False" });
            comboBoxEditAdmin.Location = new Point(790, 164);
            comboBoxEditAdmin.Name = "comboBoxEditAdmin";
            comboBoxEditAdmin.Size = new Size(266, 28);
            comboBoxEditAdmin.TabIndex = 56;
            // 
            // comboBoxAdmin
            // 
            comboBoxAdmin.FormattingEnabled = true;
            comboBoxAdmin.Items.AddRange(new object[] { "True", "False" });
            comboBoxAdmin.Location = new Point(235, 503);
            comboBoxAdmin.Name = "comboBoxAdmin";
            comboBoxAdmin.Size = new Size(266, 28);
            comboBoxAdmin.TabIndex = 58;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(46, 493);
            label16.Name = "label16";
            label16.Size = new Size(125, 38);
            label16.TabIndex = 57;
            label16.Text = "Is Admin";
            // 
            // panel2
            // 
            panel2.Controls.Add(comboBoxAdmin);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(textBoxEmail);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textBoxPassword);
            panel2.Controls.Add(dateTimePickerDOB);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBoxUsername);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBoxLastName);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBoxFirstName);
            panel2.Controls.Add(buttonSubmit);
            panel2.Location = new Point(12, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(540, 588);
            panel2.TabIndex = 59;
            // 
            // panel3
            // 
            panel3.Controls.Add(buttonRemove);
            panel3.Controls.Add(buttonNewPassword);
            panel3.Controls.Add(buttonChange);
            panel3.Controls.Add(comboBoxEditAdmin);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(buttonEdit);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(textBoxEditEmail);
            panel3.Controls.Add(labelPassword);
            panel3.Controls.Add(textBoxEditPassword);
            panel3.Controls.Add(dateTimePickerEditDOB);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(textBoxEditUsername);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(textBoxEditLastName);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(textBoxEditFirstName);
            panel3.Location = new Point(15, 647);
            panel3.Name = "panel3";
            panel3.Size = new Size(1068, 333);
            panel3.TabIndex = 60;
            // 
            // buttonNewPassword
            // 
            buttonNewPassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonNewPassword.Location = new Point(813, 264);
            buttonNewPassword.Name = "buttonNewPassword";
            buttonNewPassword.Size = new Size(221, 38);
            buttonNewPassword.TabIndex = 58;
            buttonNewPassword.Text = "Submit new Password";
            buttonNewPassword.UseVisualStyleBackColor = true;
            buttonNewPassword.Click += buttonNewPassword_Click;
            // 
            // buttonChange
            // 
            buttonChange.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonChange.Location = new Point(509, 206);
            buttonChange.Name = "buttonChange";
            buttonChange.Size = new Size(181, 38);
            buttonChange.TabIndex = 57;
            buttonChange.Text = "Change Password";
            buttonChange.UseVisualStyleBackColor = true;
            buttonChange.Click += buttonChange_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonRemove.Location = new Point(740, 206);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(181, 38);
            buttonRemove.TabIndex = 59;
            buttonRemove.Text = "Remove user";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // LibrarianForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 992);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(button1);
            Controls.Add(dataGridViewLibrarian);
            Controls.Add(panel1);
            Name = "LibrarianForm";
            Text = "LibrarianForm";
            Load += LibrarianForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewLibrarian).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonSubmit;
        private Label label2;
        private TextBox textBoxFirstName;
        private DataGridView dataGridViewLibrarian;
        private Label label14;
        private TextBox textBoxLastName;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox textBoxUsername;
        private DateTimePicker dateTimePickerDOB;
        private Label label5;
        private TextBox textBoxPassword;
        private Label label6;
        private TextBox textBoxEmail;
        private Label label7;
        private TextBox textBoxEditEmail;
        private Label labelPassword;
        private TextBox textBoxEditPassword;
        private DateTimePicker dateTimePickerEditDOB;
        private Label label9;
        private TextBox textBoxEditUsername;
        private Label label10;
        private Label label11;
        private TextBox textBoxEditLastName;
        private Button button1;
        private Label label12;
        private TextBox textBoxEditFirstName;
        private Label label13;
        private Button buttonEdit;
        private Label label15;
        private ComboBox comboBoxEditAdmin;
        private ComboBox comboBoxAdmin;
        private Label label16;
        private Panel panel2;
        private Panel panel3;
        private Button buttonChange;
        private Button buttonNewPassword;
        private Button buttonRemove;
    }
}