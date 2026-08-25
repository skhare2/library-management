namespace NEALibrary
{
    partial class StudentLeaderboardForm
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
            label8 = new Label();
            label1 = new Label();
            label2 = new Label();
            dateTimePickerInitial = new DateTimePicker();
            dateTimePickerFinal = new DateTimePicker();
            buttonCheckoutFinal = new Button();
            label3 = new Label();
            textBoxUpToPosition = new TextBox();
            dataGridViewLeaderboard = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLeaderboard).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Blue;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1423, 55);
            panel1.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(22, 130);
            label8.Name = "label8";
            label8.Size = new Size(166, 38);
            label8.TabIndex = 50;
            label8.Text = "Inititial Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 197);
            label1.Name = "label1";
            label1.Size = new Size(141, 38);
            label1.TabIndex = 52;
            label1.Text = "Final Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 68);
            label2.Name = "label2";
            label2.Size = new Size(576, 38);
            label2.TabIndex = 53;
            label2.Text = "Please select the interval for the Leaderboard";
            // 
            // dateTimePickerInitial
            // 
            dateTimePickerInitial.Location = new Point(238, 139);
            dateTimePickerInitial.Name = "dateTimePickerInitial";
            dateTimePickerInitial.Size = new Size(250, 27);
            dateTimePickerInitial.TabIndex = 54;
            // 
            // dateTimePickerFinal
            // 
            dateTimePickerFinal.Location = new Point(238, 206);
            dateTimePickerFinal.Name = "dateTimePickerFinal";
            dateTimePickerFinal.Size = new Size(250, 27);
            dateTimePickerFinal.TabIndex = 55;
            // 
            // buttonCheckoutFinal
            // 
            buttonCheckoutFinal.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCheckoutFinal.Location = new Point(238, 329);
            buttonCheckoutFinal.Name = "buttonCheckoutFinal";
            buttonCheckoutFinal.Size = new Size(262, 38);
            buttonCheckoutFinal.TabIndex = 56;
            buttonCheckoutFinal.Text = "Checkout";
            buttonCheckoutFinal.UseVisualStyleBackColor = true;
            buttonCheckoutFinal.Click += buttonCheckoutFinal_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 261);
            label3.Name = "label3";
            label3.Size = new Size(226, 38);
            label3.TabIndex = 57;
            label3.Text = "Student Position ";
            // 
            // textBoxUpToPosition
            // 
            textBoxUpToPosition.Location = new Point(238, 272);
            textBoxUpToPosition.Name = "textBoxUpToPosition";
            textBoxUpToPosition.Size = new Size(250, 27);
            textBoxUpToPosition.TabIndex = 58;
            // 
            // dataGridViewLeaderboard
            // 
            dataGridViewLeaderboard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLeaderboard.Location = new Point(658, 78);
            dataGridViewLeaderboard.Name = "dataGridViewLeaderboard";
            dataGridViewLeaderboard.RowHeadersWidth = 51;
            dataGridViewLeaderboard.Size = new Size(717, 540);
            dataGridViewLeaderboard.TabIndex = 59;
            // 
            // StudentLeaderboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1423, 670);
            Controls.Add(dataGridViewLeaderboard);
            Controls.Add(textBoxUpToPosition);
            Controls.Add(label3);
            Controls.Add(buttonCheckoutFinal);
            Controls.Add(dateTimePickerFinal);
            Controls.Add(dateTimePickerInitial);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label8);
            Controls.Add(panel1);
            Name = "StudentLeaderboardForm";
            Text = "StudentLeaderboardForm";
            Load += StudentLeaderboardForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewLeaderboard).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label8;
        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePickerInitial;
        private DateTimePicker dateTimePickerFinal;
        private Button buttonCheckoutFinal;
        private Label label3;
        private TextBox textBoxUpToPosition;
        private DataGridView dataGridViewLeaderboard;
    }
}