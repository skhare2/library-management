namespace NEALibrary
{
    partial class ChangePasswordForm
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
            textBoxPasswordConfirm = new TextBox();
            label8 = new Label();
            textBoxPassword = new TextBox();
            label5 = new Label();
            label1 = new Label();
            buttonChangePassword = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Blue;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 55);
            panel1.TabIndex = 12;
            // 
            // textBoxPasswordConfirm
            // 
            textBoxPasswordConfirm.Location = new Point(359, 249);
            textBoxPasswordConfirm.Name = "textBoxPasswordConfirm";
            textBoxPasswordConfirm.PasswordChar = '*';
            textBoxPasswordConfirm.Size = new Size(266, 27);
            textBoxPasswordConfirm.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(114, 238);
            label8.Name = "label8";
            label8.Size = new Size(239, 38);
            label8.TabIndex = 24;
            label8.Text = "Confirm Password";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(359, 180);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(266, 27);
            textBoxPassword.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(210, 169);
            label5.Name = "label5";
            label5.Size = new Size(132, 38);
            label5.TabIndex = 22;
            label5.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(210, 70);
            label1.Name = "label1";
            label1.Size = new Size(340, 46);
            label1.TabIndex = 26;
            label1.Text = "Enter new password";
            // 
            // buttonChangePassword
            // 
            buttonChangePassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonChangePassword.Location = new Point(405, 312);
            buttonChangePassword.Name = "buttonChangePassword";
            buttonChangePassword.Size = new Size(185, 38);
            buttonChangePassword.TabIndex = 27;
            buttonChangePassword.Text = "Change Password";
            buttonChangePassword.UseVisualStyleBackColor = true;
            buttonChangePassword.Click += buttonChangePassword_Click;
            // 
            // ChangePasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonChangePassword);
            Controls.Add(label1);
            Controls.Add(textBoxPasswordConfirm);
            Controls.Add(label8);
            Controls.Add(textBoxPassword);
            Controls.Add(label5);
            Controls.Add(panel1);
            Name = "ChangePasswordForm";
            Text = "ChangePasswordForm";
            Load += ChangePasswordForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textBoxPasswordConfirm;
        private Label label8;
        private TextBox textBoxPassword;
        private Label label5;
        private Label label1;
        private Button buttonChangePassword;
    }
}