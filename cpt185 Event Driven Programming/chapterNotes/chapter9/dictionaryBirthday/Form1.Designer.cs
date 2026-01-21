namespace dictionaryBirthday
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            nameListBox = new ListBox();
            label2 = new Label();
            birthdayLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(312, 37);
            label1.Name = "label1";
            label1.Size = new Size(127, 25);
            label1.TabIndex = 0;
            label1.Text = "Select A Name";
            // 
            // nameListBox
            // 
            nameListBox.FormattingEnabled = true;
            nameListBox.ItemHeight = 25;
            nameListBox.Location = new Point(245, 100);
            nameListBox.Name = "nameListBox";
            nameListBox.Size = new Size(259, 129);
            nameListBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(236, 304);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 2;
            label2.Text = "Birthday :";
            // 
            // birthdayLabel
            // 
            birthdayLabel.Location = new Point(348, 304);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new Size(193, 38);
            birthdayLabel.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(birthdayLabel);
            Controls.Add(label2);
            Controls.Add(nameListBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox nameListBox;
        private Label label2;
        private Label birthdayLabel;
    }
}
