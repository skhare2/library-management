namespace NEALibrary
{
    partial class AddStudentForm
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
            label1 = new Label();
            label3 = new Label();
            textBoxUsername = new TextBox();
            label5 = new Label();
            textBoxPassword = new TextBox();
            panel1 = new Panel();
            textBoxFirstName = new TextBox();
            label2 = new Label();
            textBoxLastName = new TextBox();
            label4 = new Label();
            label6 = new Label();
            textBoxEmail = new TextBox();
            label7 = new Label();
            dateTimePickerDOB = new DateTimePicker();
            textBoxPasswordConfirm = new TextBox();
            label8 = new Label();
            buttonAddStudent = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(268, 76);
            label1.Name = "label1";
            label1.Size = new Size(466, 46);
            label1.TabIndex = 10;
            label1.Text = "Enter details of new student";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(565, 187);
            label3.Name = "label3";
            label3.Size = new Size(142, 38);
            label3.TabIndex = 6;
            label3.Text = "Username";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(724, 198);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(266, 27);
            textBoxUsername.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(575, 247);
            label5.Name = "label5";
            label5.Size = new Size(132, 38);
            label5.TabIndex = 8;
            label5.Text = "Password";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(724, 258);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(266, 27);
            textBoxPassword.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Blue;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1002, 55);
            panel1.TabIndex = 11;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(196, 192);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(266, 27);
            textBoxFirstName.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 181);
            label2.Name = "label2";
            label2.Size = new Size(138, 38);
            label2.TabIndex = 12;
            label2.Text = "Firstname";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(196, 252);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(266, 27);
            textBoxLastName.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(33, 241);
            label4.Name = "label4";
            label4.Size = new Size(134, 38);
            label4.TabIndex = 14;
            label4.Text = "Lastname";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(-3, 307);
            label6.Name = "label6";
            label6.Size = new Size(174, 38);
            label6.TabIndex = 16;
            label6.Text = "Date of Birth";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(196, 375);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(266, 27);
            textBoxEmail.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(82, 364);
            label7.Name = "label7";
            label7.Size = new Size(83, 38);
            label7.TabIndex = 18;
            label7.Text = "Email";
            // 
            // dateTimePickerDOB
            // 
            dateTimePickerDOB.Location = new Point(196, 319);
            dateTimePickerDOB.Name = "dateTimePickerDOB";
            dateTimePickerDOB.Size = new Size(266, 27);
            dateTimePickerDOB.TabIndex = 19;
            // 
            // textBoxPasswordConfirm
            // 
            textBoxPasswordConfirm.Location = new Point(724, 327);
            textBoxPasswordConfirm.Name = "textBoxPasswordConfirm";
            textBoxPasswordConfirm.PasswordChar = '*';
            textBoxPasswordConfirm.Size = new Size(266, 27);
            textBoxPasswordConfirm.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(479, 316);
            label8.Name = "label8";
            label8.Size = new Size(239, 38);
            label8.TabIndex = 20;
            label8.Text = "Confirm Password";
            // 
            // buttonAddStudent
            // 
            buttonAddStudent.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAddStudent.Location = new Point(395, 457);
            buttonAddStudent.Name = "buttonAddStudent";
            buttonAddStudent.Size = new Size(185, 38);
            buttonAddStudent.TabIndex = 22;
            buttonAddStudent.Text = "Next";
            buttonAddStudent.UseVisualStyleBackColor = true;
            buttonAddStudent.Click += buttonAddStudent_Click;
            // 
            // AddStudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 572);
            Controls.Add(buttonAddStudent);
            Controls.Add(textBoxPasswordConfirm);
            Controls.Add(label8);
            Controls.Add(dateTimePickerDOB);
            Controls.Add(label7);
            Controls.Add(textBoxEmail);
            Controls.Add(label6);
            Controls.Add(textBoxLastName);
            Controls.Add(label4);
            Controls.Add(textBoxFirstName);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(textBoxPassword);
            Controls.Add(label5);
            Controls.Add(textBoxUsername);
            Controls.Add(label3);
            Name = "AddStudentForm";
            Text = "AddStudentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label3;
        private TextBox textBoxUsername;
        private Label label5;
        private TextBox textBoxPassword;
        private Panel panel1;
        private TextBox textBoxFirstName;
        private Label label2;
        private TextBox textBoxLastName;
        private Label label4;
        private Label label6;
        private TextBox textBoxEmail;
        private Label label7;
        private DateTimePicker dateTimePickerDOB;
        private TextBox textBoxPasswordConfirm;
        private Label label8;
        private Button buttonAddStudent;
    }
}