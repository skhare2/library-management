namespace NEALibrary
{
    partial class StudentViewLoanForm
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
            dataGridViewLoan = new DataGridView();
            panel2 = new Panel();
            textBoxLateFee = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoan).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewLoan
            // 
            dataGridViewLoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLoan.Location = new Point(576, 73);
            dataGridViewLoan.Name = "dataGridViewLoan";
            dataGridViewLoan.RowHeadersWidth = 51;
            dataGridViewLoan.Size = new Size(711, 633);
            dataGridViewLoan.TabIndex = 43;
            dataGridViewLoan.CellContentClick += dataGridViewLoan_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Blue;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1415, 55);
            panel2.TabIndex = 44;
            // 
            // textBoxLateFee
            // 
            textBoxLateFee.Location = new Point(266, 229);
            textBoxLateFee.Name = "textBoxLateFee";
            textBoxLateFee.ReadOnly = true;
            textBoxLateFee.Size = new Size(216, 27);
            textBoxLateFee.TabIndex = 45;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(109, 218);
            label8.Name = "label8";
            label8.Size = new Size(132, 38);
            label8.TabIndex = 46;
            label8.Text = "Late Fees";
            // 
            // StudentViewLoanForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1415, 798);
            Controls.Add(label8);
            Controls.Add(textBoxLateFee);
            Controls.Add(panel2);
            Controls.Add(dataGridViewLoan);
            Name = "StudentViewLoanForm";
            Text = "StudentViewLoanForm";
            Load += StudentViewLoanForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewLoan;
        private Panel panel2;
        private TextBox textBoxLateFee;
        private Label label8;
    }
}