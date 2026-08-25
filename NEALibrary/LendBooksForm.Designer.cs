namespace NEALibrary
{
    partial class LendBooksForm
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
            panelStudentDetail = new Panel();
            textBoxUsername = new TextBox();
            textBoxLastName = new TextBox();
            label4 = new Label();
            textBoxFirstName = new TextBox();
            label2 = new Label();
            buttonSubmit = new Button();
            label1 = new Label();
            label3 = new Label();
            panelStudentLoan = new Panel();
            buttonSubmitCheckIN = new Button();
            buttonRemoveReturn = new Button();
            textBoxDueDate = new TextBox();
            textBoxTitle = new TextBox();
            dataGridViewLoan = new DataGridView();
            label5 = new Label();
            textBoxCopyId = new TextBox();
            label6 = new Label();
            buttonReturn = new Button();
            label7 = new Label();
            label8 = new Label();
            panel2 = new Panel();
            panelStudentDetail.SuspendLayout();
            panelStudentLoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoan).BeginInit();
            SuspendLayout();
            // 
            // panelStudentDetail
            // 
            panelStudentDetail.Controls.Add(textBoxUsername);
            panelStudentDetail.Controls.Add(textBoxLastName);
            panelStudentDetail.Controls.Add(label4);
            panelStudentDetail.Controls.Add(textBoxFirstName);
            panelStudentDetail.Controls.Add(label2);
            panelStudentDetail.Controls.Add(buttonSubmit);
            panelStudentDetail.Controls.Add(label1);
            panelStudentDetail.Controls.Add(label3);
            panelStudentDetail.Location = new Point(0, 61);
            panelStudentDetail.Name = "panelStudentDetail";
            panelStudentDetail.Size = new Size(1289, 675);
            panelStudentDetail.TabIndex = 21;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(217, 104);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(266, 27);
            textBoxUsername.TabIndex = 43;
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
            // panelStudentLoan
            // 
            panelStudentLoan.Controls.Add(buttonSubmitCheckIN);
            panelStudentLoan.Controls.Add(buttonRemoveReturn);
            panelStudentLoan.Controls.Add(textBoxDueDate);
            panelStudentLoan.Controls.Add(textBoxTitle);
            panelStudentLoan.Controls.Add(dataGridViewLoan);
            panelStudentLoan.Controls.Add(label5);
            panelStudentLoan.Controls.Add(textBoxCopyId);
            panelStudentLoan.Controls.Add(label6);
            panelStudentLoan.Controls.Add(buttonReturn);
            panelStudentLoan.Controls.Add(label7);
            panelStudentLoan.Controls.Add(label8);
            panelStudentLoan.Location = new Point(16, 61);
            panelStudentLoan.Name = "panelStudentLoan";
            panelStudentLoan.Size = new Size(1270, 659);
            panelStudentLoan.TabIndex = 42;
            panelStudentLoan.Paint += panelStudentLoan_Paint;
            // 
            // buttonSubmitCheckIN
            // 
            buttonSubmitCheckIN.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSubmitCheckIN.Location = new Point(237, 463);
            buttonSubmitCheckIN.Name = "buttonSubmitCheckIN";
            buttonSubmitCheckIN.Size = new Size(113, 38);
            buttonSubmitCheckIN.TabIndex = 46;
            buttonSubmitCheckIN.Text = "Submit";
            buttonSubmitCheckIN.UseVisualStyleBackColor = true;
            buttonSubmitCheckIN.Click += buttonSubmitCheckIN_Click;
            // 
            // buttonRemoveReturn
            // 
            buttonRemoveReturn.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonRemoveReturn.Location = new Point(296, 322);
            buttonRemoveReturn.Name = "buttonRemoveReturn";
            buttonRemoveReturn.Size = new Size(113, 38);
            buttonRemoveReturn.TabIndex = 45;
            buttonRemoveReturn.Text = "Remove Return";
            buttonRemoveReturn.UseVisualStyleBackColor = true;
            buttonRemoveReturn.Click += buttonRemoveReturn_Click;
            // 
            // textBoxDueDate
            // 
            textBoxDueDate.Location = new Point(217, 219);
            textBoxDueDate.Name = "textBoxDueDate";
            textBoxDueDate.ReadOnly = true;
            textBoxDueDate.Size = new Size(266, 27);
            textBoxDueDate.TabIndex = 44;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(217, 104);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.ReadOnly = true;
            textBoxTitle.Size = new Size(266, 27);
            textBoxTitle.TabIndex = 43;
            // 
            // dataGridViewLoan
            // 
            dataGridViewLoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLoan.Location = new Point(563, 3);
            dataGridViewLoan.Name = "dataGridViewLoan";
            dataGridViewLoan.RowHeadersWidth = 51;
            dataGridViewLoan.Size = new Size(711, 633);
            dataGridViewLoan.TabIndex = 42;
            dataGridViewLoan.CellClick += dataGridViewLoan_CellClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(38, 208);
            label5.Name = "label5";
            label5.Size = new Size(134, 38);
            label5.TabIndex = 40;
            label5.Text = "Due Date";
            // 
            // textBoxCopyId
            // 
            textBoxCopyId.Location = new Point(217, 159);
            textBoxCopyId.Name = "textBoxCopyId";
            textBoxCopyId.ReadOnly = true;
            textBoxCopyId.Size = new Size(266, 27);
            textBoxCopyId.TabIndex = 39;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(54, 148);
            label6.Name = "label6";
            label6.Size = new Size(103, 38);
            label6.TabIndex = 38;
            label6.Text = "CopyId";
            // 
            // buttonReturn
            // 
            buttonReturn.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonReturn.Location = new Point(296, 260);
            buttonReturn.Name = "buttonReturn";
            buttonReturn.Size = new Size(113, 38);
            buttonReturn.TabIndex = 37;
            buttonReturn.Text = "Return";
            buttonReturn.UseVisualStyleBackColor = true;
            buttonReturn.Click += buttonReturn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(123, 23);
            label7.Name = "label7";
            label7.Size = new Size(314, 46);
            label7.TabIndex = 10;
            label7.Text = "Enter Book Details";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(54, 93);
            label8.Name = "label8";
            label8.Size = new Size(70, 38);
            label8.TabIndex = 8;
            label8.Text = "Title";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Blue;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1324, 55);
            panel2.TabIndex = 22;
            // 
            // LendBooksForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1324, 748);
            Controls.Add(panel2);
            Controls.Add(panelStudentLoan);
            Controls.Add(panelStudentDetail);
            Name = "LendBooksForm";
            Text = "LendBooksForm";
            panelStudentDetail.ResumeLayout(false);
            panelStudentDetail.PerformLayout();
            panelStudentLoan.ResumeLayout(false);
            panelStudentLoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelStudentDetail;
        private TextBox textBoxLastName;
        private Label label4;
        private TextBox textBoxFirstName;
        private Label label2;
        private Button buttonSubmit;
        private Label label1;
        private Label label3;
        private Panel panel2;
        private Panel panelStudentLoan;
        private Label label5;
        private TextBox textBoxCopyId;
        private Label label6;
        private Button buttonReturn;
        private Label label7;
        private Label label8;
        private DataGridView dataGridViewLoan;
        private TextBox textBoxUsername;
        private TextBox textBoxTitle;
        private TextBox textBoxDueDate;
        private Button buttonRemoveReturn;
        private Button buttonSubmitCheckIN;
    }
}