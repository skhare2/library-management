namespace NEALibrary
{
    partial class AddLibrarian
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
            dataGridViewLoan = new DataGridView();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoan).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Blue;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1271, 55);
            panel1.TabIndex = 20;
            // 
            // dataGridViewLoan
            // 
            dataGridViewLoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLoan.Location = new Point(472, 120);
            dataGridViewLoan.Name = "dataGridViewLoan";
            dataGridViewLoan.RowHeadersWidth = 51;
            dataGridViewLoan.Size = new Size(775, 526);
            dataGridViewLoan.TabIndex = 45;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(89, 58);
            label7.Name = "label7";
            label7.Size = new Size(281, 46);
            label7.TabIndex = 44;
            label7.Text = "Librarian Details";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(32, 146);
            label8.Name = "label8";
            label8.Size = new Size(70, 38);
            label8.TabIndex = 43;
            label8.Text = "Title";
            // 
            // AddLibrarian
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1271, 658);
            Controls.Add(dataGridViewLoan);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(panel1);
            Name = "AddLibrarian";
            Text = "AddLibrarian";
            Load += AddLibrarian_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridViewLoan;
        private Label label7;
        private Label label8;
    }
}