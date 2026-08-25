namespace NEALibrary
{
    partial class ForgotPasswordForm
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
            textBoxUsername = new TextBox();
            label2 = new Label();
            buttonSubmit = new Button();
            label1 = new Label();
            textBoxCode = new TextBox();
            labelCode = new Label();
            panel2 = new Panel();
            labelAttempts = new Label();
            labelChange = new Label();
            buttonCode = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Blue;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(858, 55);
            panel1.TabIndex = 4;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(241, 196);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(266, 27);
            textBoxUsername.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(69, 185);
            label2.Name = "label2";
            label2.Size = new Size(142, 38);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // buttonSubmit
            // 
            buttonSubmit.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSubmit.Location = new Point(329, 254);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(113, 38);
            buttonSubmit.TabIndex = 9;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(294, 73);
            label1.Name = "label1";
            label1.Size = new Size(288, 46);
            label1.TabIndex = 10;
            label1.Text = "Forgot Password";
            // 
            // textBoxCode
            // 
            textBoxCode.Location = new Point(266, 24);
            textBoxCode.Name = "textBoxCode";
            textBoxCode.Size = new Size(266, 27);
            textBoxCode.TabIndex = 12;
            // 
            // labelCode
            // 
            labelCode.AutoSize = true;
            labelCode.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCode.Location = new Point(82, 13);
            labelCode.Name = "labelCode";
            labelCode.Size = new Size(81, 38);
            labelCode.TabIndex = 11;
            labelCode.Text = "Code";
            // 
            // panel2
            // 
            panel2.Controls.Add(labelAttempts);
            panel2.Controls.Add(labelChange);
            panel2.Controls.Add(buttonCode);
            panel2.Controls.Add(labelCode);
            panel2.Controls.Add(textBoxCode);
            panel2.Location = new Point(12, 348);
            panel2.Name = "panel2";
            panel2.Size = new Size(767, 125);
            panel2.TabIndex = 13;
            // 
            // labelAttempts
            // 
            labelAttempts.AutoSize = true;
            labelAttempts.Location = new Point(553, 27);
            labelAttempts.Name = "labelAttempts";
            labelAttempts.Size = new Size(70, 20);
            labelAttempts.TabIndex = 16;
            labelAttempts.Text = "Attempts";
            // 
            // labelChange
            // 
            labelChange.AutoSize = true;
            labelChange.Location = new Point(575, 27);
            labelChange.Name = "labelChange";
            labelChange.Size = new Size(0, 20);
            labelChange.TabIndex = 15;
            // 
            // buttonCode
            // 
            buttonCode.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCode.Location = new Point(351, 70);
            buttonCode.Name = "buttonCode";
            buttonCode.Size = new Size(113, 38);
            buttonCode.TabIndex = 14;
            buttonCode.Text = "Submit";
            buttonCode.UseVisualStyleBackColor = true;
            buttonCode.Click += buttonCode_Click;
            // 
            // ForgotPasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 498);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(buttonSubmit);
            Controls.Add(textBoxUsername);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "ForgotPasswordForm";
            Text = "ForgotPasswordForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textBoxUsername;
        private Label label2;
        private Button buttonSubmit;
        private Label label1;
        private TextBox textBoxCode;
        private Label labelCode;
        private Panel panel2;
        private Button buttonCode;
        private Label labelChange;
        private Label labelAttempts;
    }
}