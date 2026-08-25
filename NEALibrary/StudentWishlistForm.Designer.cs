namespace NEALibrary
{
    partial class StudentWishlistForm
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
            textBoxISBN = new TextBox();
            label14 = new Label();
            textBoxAuthorName = new TextBox();
            buttonSubmit = new Button();
            label2 = new Label();
            textBoxTitle = new TextBox();
            label1 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(textBoxISBN);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(textBoxAuthorName);
            panel2.Controls.Add(buttonSubmit);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBoxTitle);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(26, 88);
            panel2.Name = "panel2";
            panel2.Size = new Size(841, 398);
            panel2.TabIndex = 24;
            // 
            // textBoxISBN
            // 
            textBoxISBN.Location = new Point(329, 159);
            textBoxISBN.Name = "textBoxISBN";
            textBoxISBN.Size = new Size(266, 27);
            textBoxISBN.TabIndex = 27;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(178, 5);
            label14.Name = "label14";
            label14.Size = new Size(216, 38);
            label14.TabIndex = 26;
            label14.Text = "Enter Book Data";
            // 
            // textBoxAuthorName
            // 
            textBoxAuthorName.Location = new Point(329, 104);
            textBoxAuthorName.Name = "textBoxAuthorName";
            textBoxAuthorName.Size = new Size(266, 27);
            textBoxAuthorName.TabIndex = 10;
            // 
            // buttonSubmit
            // 
            buttonSubmit.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSubmit.Location = new Point(400, 227);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(113, 38);
            buttonSubmit.TabIndex = 19;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(126, 43);
            label2.Name = "label2";
            label2.Size = new Size(70, 38);
            label2.TabIndex = 5;
            label2.Text = "Title";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(329, 54);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(266, 27);
            textBoxTitle.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(71, 148);
            label1.Name = "label1";
            label1.Size = new Size(125, 38);
            label1.TabIndex = 7;
            label1.Text = "ISBN-13 ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 93);
            label3.Name = "label3";
            label3.Size = new Size(184, 38);
            label3.TabIndex = 9;
            label3.Text = "Author Name";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Blue;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(916, 55);
            panel1.TabIndex = 25;
            // 
            // StudentWishlistForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 608);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "StudentWishlistForm";
            Text = "StudentWishlistForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label14;
        private Button buttonSubmit;
        private Label label2;
        private TextBox textBoxTitle;
        private Label label1;
        private Label label3;
        private TextBox textBoxISBN;
        private TextBox textBoxAuthorName;
        private Panel panel1;
    }
}