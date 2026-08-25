namespace NEALibrary
{
    partial class RemoveCopy
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
            buttonAddCopyId = new Button();
            label2 = new Label();
            textBoxCopyId = new TextBox();
            label1 = new Label();
            textBoxBookNames = new TextBox();
            buttonSubmit = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Blue;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1304, 55);
            panel1.TabIndex = 18;
            // 
            // buttonAddCopyId
            // 
            buttonAddCopyId.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAddCopyId.Location = new Point(535, 147);
            buttonAddCopyId.Name = "buttonAddCopyId";
            buttonAddCopyId.Size = new Size(188, 38);
            buttonAddCopyId.TabIndex = 22;
            buttonAddCopyId.Text = "Add CopyId";
            buttonAddCopyId.UseVisualStyleBackColor = true;
            buttonAddCopyId.Click += buttonAddCopyId_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(104, 144);
            label2.Name = "label2";
            label2.Size = new Size(103, 38);
            label2.TabIndex = 20;
            label2.Text = "CopyId";
            // 
            // textBoxCopyId
            // 
            textBoxCopyId.Location = new Point(228, 155);
            textBoxCopyId.Name = "textBoxCopyId";
            textBoxCopyId.Size = new Size(266, 27);
            textBoxCopyId.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 73);
            label1.Name = "label1";
            label1.Size = new Size(737, 38);
            label1.TabIndex = 23;
            label1.Text = "Please enter the copyids of the books you want to remove";
            // 
            // textBoxBookNames
            // 
            textBoxBookNames.Location = new Point(766, 73);
            textBoxBookNames.Multiline = true;
            textBoxBookNames.Name = "textBoxBookNames";
            textBoxBookNames.ReadOnly = true;
            textBoxBookNames.ScrollBars = ScrollBars.Both;
            textBoxBookNames.Size = new Size(507, 418);
            textBoxBookNames.TabIndex = 24;
            // 
            // buttonSubmit
            // 
            buttonSubmit.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSubmit.Location = new Point(253, 278);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(188, 38);
            buttonSubmit.TabIndex = 25;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // RemoveCopy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1304, 503);
            Controls.Add(buttonSubmit);
            Controls.Add(textBoxBookNames);
            Controls.Add(label1);
            Controls.Add(buttonAddCopyId);
            Controls.Add(label2);
            Controls.Add(textBoxCopyId);
            Controls.Add(panel1);
            Name = "RemoveCopy";
            Text = "RemoveCopy";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button buttonAddCopyId;
        private Label label2;
        private TextBox textBoxCopyId;
        private Label label1;
        private TextBox textBoxBookNames;
        private Button buttonSubmit;
    }
}