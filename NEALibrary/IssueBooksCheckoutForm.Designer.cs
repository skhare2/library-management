namespace NEALibrary
{
    partial class IssueBooksCheckoutForm
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
            dateTimePickerDueDate = new DateTimePicker();
            label9 = new Label();
            dateTimePickerIssueDate = new DateTimePicker();
            label8 = new Label();
            label5 = new Label();
            buttonCheckoutFinal = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dateTimePickerDueDate);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(dateTimePickerIssueDate);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(buttonCheckoutFinal);
            panel1.Location = new Point(38, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(941, 445);
            panel1.TabIndex = 0;
            // 
            // dateTimePickerDueDate
            // 
            dateTimePickerDueDate.Font = new Font("Segoe UI", 12F);
            dateTimePickerDueDate.Location = new Point(272, 217);
            dateTimePickerDueDate.Name = "dateTimePickerDueDate";
            dateTimePickerDueDate.Size = new Size(327, 34);
            dateTimePickerDueDate.TabIndex = 29;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 19.8000011F);
            label9.Location = new Point(86, 211);
            label9.Name = "label9";
            label9.Size = new Size(161, 46);
            label9.TabIndex = 28;
            label9.Text = "Due Date";
            // 
            // dateTimePickerIssueDate
            // 
            dateTimePickerIssueDate.Font = new Font("Segoe UI", 12F);
            dateTimePickerIssueDate.Location = new Point(272, 146);
            dateTimePickerIssueDate.Name = "dateTimePickerIssueDate";
            dateTimePickerIssueDate.Size = new Size(327, 34);
            dateTimePickerIssueDate.TabIndex = 27;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(207, 40);
            label8.Name = "label8";
            label8.Size = new Size(308, 46);
            label8.TabIndex = 26;
            label8.Text = "Enter Loan Details";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 19.8000011F);
            label5.Location = new Point(73, 138);
            label5.Name = "label5";
            label5.Size = new Size(174, 46);
            label5.TabIndex = 25;
            label5.Text = "Issue Date";
            // 
            // buttonCheckoutFinal
            // 
            buttonCheckoutFinal.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCheckoutFinal.Location = new Point(272, 315);
            buttonCheckoutFinal.Name = "buttonCheckoutFinal";
            buttonCheckoutFinal.Size = new Size(327, 52);
            buttonCheckoutFinal.TabIndex = 24;
            buttonCheckoutFinal.Text = "Checkout";
            buttonCheckoutFinal.UseVisualStyleBackColor = true;
            buttonCheckoutFinal.Click += buttonCheckoutFinal_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Blue;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1178, 55);
            panel2.TabIndex = 20;
            // 
            // IssueBooksCheckoutForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 657);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "IssueBooksCheckoutForm";
            Text = "IssueBooksCheckoutForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DateTimePicker dateTimePickerDueDate;
        private Label label9;
        private DateTimePicker dateTimePickerIssueDate;
        private Label label8;
        private Label label5;
        private Button buttonCheckoutFinal;
        private Panel panel2;
    }
}