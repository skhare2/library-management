namespace NEALibrary
{
    partial class ViewCompletedReservationForm
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
            dataGridViewReservation = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservation).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Blue;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(893, 55);
            panel2.TabIndex = 23;
            // 
            // dataGridViewReservation
            // 
            dataGridViewReservation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReservation.Location = new Point(12, 61);
            dataGridViewReservation.Name = "dataGridViewReservation";
            dataGridViewReservation.RowHeadersWidth = 51;
            dataGridViewReservation.Size = new Size(869, 411);
            dataGridViewReservation.TabIndex = 43;
            // 
            // ViewCompletedReservationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 484);
            Controls.Add(dataGridViewReservation);
            Controls.Add(panel2);
            Name = "ViewCompletedReservationForm";
            Text = "ViewCompletedReservationForm";
            Load += ViewCompletedReservationForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservation).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private DataGridView dataGridViewReservation;
    }
}