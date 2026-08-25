namespace NEALibrary
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textBoxUsername = new TextBox();
            panel1 = new Panel();
            textBoxPassword = new TextBox();
            label4 = new Label();
            label5 = new Label();
            comboBoxUserType = new ComboBox();
            buttonLogin = new Button();
            panel2 = new Panel();
            buttonAddStudent = new Button();
            buttonForgot = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(204, 84);
            label1.Name = "label1";
            label1.Size = new Size(110, 46);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(50, 169);
            label2.Name = "label2";
            label2.Size = new Size(142, 38);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(213, 180);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(266, 27);
            textBoxUsername.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Blue;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(545, 55);
            panel1.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(213, 240);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(266, 27);
            textBoxPassword.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(50, 229);
            label4.Name = "label4";
            label4.Size = new Size(132, 38);
            label4.TabIndex = 4;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(94, 293);
            label5.Name = "label5";
            label5.Size = new Size(73, 38);
            label5.TabIndex = 6;
            label5.Text = "User";
            // 
            // comboBoxUserType
            // 
            comboBoxUserType.FormattingEnabled = true;
            comboBoxUserType.Items.AddRange(new object[] { "Student", "Librarian" });
            comboBoxUserType.Location = new Point(213, 303);
            comboBoxUserType.Name = "comboBoxUserType";
            comboBoxUserType.Size = new Size(266, 28);
            comboBoxUserType.TabIndex = 7;
            // 
            // buttonLogin
            // 
            buttonLogin.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLogin.Location = new Point(289, 372);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(113, 38);
            buttonLogin.TabIndex = 8;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(buttonAddStudent);
            panel2.Controls.Add(buttonForgot);
            panel2.Location = new Point(12, 459);
            panel2.Name = "panel2";
            panel2.Size = new Size(521, 92);
            panel2.TabIndex = 9;
            // 
            // buttonAddStudent
            // 
            buttonAddStudent.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAddStudent.Location = new Point(281, 24);
            buttonAddStudent.Name = "buttonAddStudent";
            buttonAddStudent.Size = new Size(185, 38);
            buttonAddStudent.TabIndex = 10;
            buttonAddStudent.Text = "Add Student";
            buttonAddStudent.UseVisualStyleBackColor = true;
            buttonAddStudent.Click += buttonAddStudent_Click;
            // 
            // buttonForgot
            // 
            buttonForgot.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonForgot.Location = new Point(81, 24);
            buttonForgot.Name = "buttonForgot";
            buttonForgot.Size = new Size(168, 38);
            buttonForgot.TabIndex = 10;
            buttonForgot.Text = "Forgot Password";
            buttonForgot.UseVisualStyleBackColor = true;
            buttonForgot.Click += buttonForgot_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 563);
            Controls.Add(panel2);
            Controls.Add(buttonLogin);
            Controls.Add(comboBoxUserType);
            Controls.Add(label5);
            Controls.Add(textBoxPassword);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(textBoxUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            Text = "Login";
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxUsername;
        private Panel panel1;
        private TextBox textBoxPassword;
        private Label label4;
        private Label label5;
        private ComboBox comboBoxUserType;
        private Button buttonLogin;
        private Panel panel2;
        private Button buttonAddStudent;
        private Button buttonForgot;
    }
}
