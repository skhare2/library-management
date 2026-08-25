namespace NEALibrary
{
    partial class IssueBooksForm
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
            panelStudentDetail = new Panel();
            textBoxLastName = new TextBox();
            label4 = new Label();
            textBoxFirstName = new TextBox();
            label2 = new Label();
            buttonSubmit = new Button();
            label1 = new Label();
            textBoxUsername = new TextBox();
            label3 = new Label();
            panelBookLoan = new Panel();
            textBoxBookNames = new TextBox();
            buttonCheckout = new Button();
            buttonAddCopy = new Button();
            textBoxCopyId = new TextBox();
            label7 = new Label();
            label6 = new Label();
            panelStudentDetail.SuspendLayout();
            panelBookLoan.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Blue;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1431, 55);
            panel2.TabIndex = 19;
            // 
            // panelStudentDetail
            // 
            panelStudentDetail.Controls.Add(textBoxLastName);
            panelStudentDetail.Controls.Add(label4);
            panelStudentDetail.Controls.Add(textBoxFirstName);
            panelStudentDetail.Controls.Add(label2);
            panelStudentDetail.Controls.Add(buttonSubmit);
            panelStudentDetail.Controls.Add(label1);
            panelStudentDetail.Controls.Add(textBoxUsername);
            panelStudentDetail.Controls.Add(label3);
            panelStudentDetail.Location = new Point(36, 74);
            panelStudentDetail.Name = "panelStudentDetail";
            panelStudentDetail.Size = new Size(564, 318);
            panelStudentDetail.TabIndex = 20;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(217, 219);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(266, 27);
            textBoxLastName.TabIndex = 41;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(54, 208);
            label4.Name = "label4";
            label4.Size = new Size(134, 38);
            label4.TabIndex = 40;
            label4.Text = "Lastname";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(217, 159);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(266, 27);
            textBoxFirstName.TabIndex = 39;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(54, 148);
            label2.Name = "label2";
            label2.Size = new Size(138, 38);
            label2.TabIndex = 38;
            label2.Text = "Firstname";
            // 
            // buttonSubmit
            // 
            buttonSubmit.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSubmit.Location = new Point(296, 260);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(113, 38);
            buttonSubmit.TabIndex = 37;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(123, 23);
            label1.Name = "label1";
            label1.Size = new Size(356, 46);
            label1.TabIndex = 10;
            label1.Text = "Enter Student Details";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(213, 104);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(270, 27);
            textBoxUsername.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(54, 93);
            label3.Name = "label3";
            label3.Size = new Size(142, 38);
            label3.TabIndex = 8;
            label3.Text = "Username";
            // 
            // panelBookLoan
            // 
            panelBookLoan.Controls.Add(textBoxBookNames);
            panelBookLoan.Controls.Add(buttonCheckout);
            panelBookLoan.Controls.Add(buttonAddCopy);
            panelBookLoan.Controls.Add(textBoxCopyId);
            panelBookLoan.Controls.Add(label7);
            panelBookLoan.Controls.Add(label6);
            panelBookLoan.Location = new Point(26, 74);
            panelBookLoan.Name = "panelBookLoan";
            panelBookLoan.Size = new Size(1383, 461);
            panelBookLoan.TabIndex = 21;
            // 
            // textBoxBookNames
            // 
            textBoxBookNames.Location = new Point(897, 13);
            textBoxBookNames.Multiline = true;
            textBoxBookNames.Name = "textBoxBookNames";
            textBoxBookNames.ReadOnly = true;
            textBoxBookNames.ScrollBars = ScrollBars.Both;
            textBoxBookNames.Size = new Size(454, 408);
            textBoxBookNames.TabIndex = 17;
            // 
            // buttonCheckout
            // 
            buttonCheckout.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCheckout.Location = new Point(147, 303);
            buttonCheckout.Name = "buttonCheckout";
            buttonCheckout.Size = new Size(333, 38);
            buttonCheckout.TabIndex = 16;
            buttonCheckout.Text = "Checkout";
            buttonCheckout.UseVisualStyleBackColor = true;
            buttonCheckout.Click += buttonCheckout_Click;
            // 
            // buttonAddCopy
            // 
            buttonAddCopy.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAddCopy.Location = new Point(595, 98);
            buttonAddCopy.Name = "buttonAddCopy";
            buttonAddCopy.Size = new Size(189, 38);
            buttonAddCopy.TabIndex = 15;
            buttonAddCopy.Text = "Add Copy";
            buttonAddCopy.UseVisualStyleBackColor = true;
            buttonAddCopy.Click += buttonAddCopy_Click;
            // 
            // textBoxCopyId
            // 
            textBoxCopyId.Location = new Point(186, 106);
            textBoxCopyId.Name = "textBoxCopyId";
            textBoxCopyId.Size = new Size(270, 27);
            textBoxCopyId.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(27, 95);
            label7.Name = "label7";
            label7.Size = new Size(103, 38);
            label7.TabIndex = 13;
            label7.Text = "CopyId";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(172, 8);
            label6.Name = "label6";
            label6.Size = new Size(308, 46);
            label6.TabIndex = 12;
            label6.Text = "Enter Loan Details";
            // 
            // IssueBooksForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1431, 562);
            Controls.Add(panelBookLoan);
            Controls.Add(panelStudentDetail);
            Controls.Add(panel2);
            Name = "IssueBooksForm";
            Text = "IssueBooksForm";
            panelStudentDetail.ResumeLayout(false);
            panelStudentDetail.PerformLayout();
            panelBookLoan.ResumeLayout(false);
            panelBookLoan.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panelStudentDetail;
        private TextBox textBoxUsername;
        private Label label3;
        private Label label1;
        private Button buttonSubmit;
        private TextBox textBoxLastName;
        private Label label4;
        private TextBox textBoxFirstName;
        private Label label2;
        private Panel panelBookLoan;
        private Label label6;
        private TextBox textBoxCopyId;
        private Label label7;
        private Button buttonCheckout;
        private Button buttonAddCopy;
        private TextBox textBoxBookNames;
    }
}