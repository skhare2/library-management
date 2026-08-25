namespace NEALibrary
{
    partial class AddStudentCodeForm
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
            labelAttempts = new Label();
            labelChange = new Label();
            buttonCode = new Button();
            labelCode = new Label();
            textBoxCode = new TextBox();
            panel1 = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(labelAttempts);
            panel2.Controls.Add(labelChange);
            panel2.Controls.Add(buttonCode);
            panel2.Controls.Add(labelCode);
            panel2.Controls.Add(textBoxCode);
            panel2.Location = new Point(12, 113);
            panel2.Name = "panel2";
            panel2.Size = new Size(767, 125);
            panel2.TabIndex = 14;
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
            // textBoxCode
            // 
            textBoxCode.Location = new Point(266, 24);
            textBoxCode.Name = "textBoxCode";
            textBoxCode.Size = new Size(266, 27);
            textBoxCode.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Blue;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1007, 55);
            panel1.TabIndex = 15;
            // 
            // AddStudentCodeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 284);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AddStudentCodeForm";
            Text = "AddStudentCodeForm";
            Load += AddStudentCodeForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label labelAttempts;
        private Label labelChange;
        private Button buttonCode;
        private Label labelCode;
        private TextBox textBoxCode;
        private Panel panel1;
    }
}