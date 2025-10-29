namespace phoneBook
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
            nameListbox = new ListBox();
            phoneLabel = new Label();
            exitButton = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(281, 165);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 0;
            label1.Text = "Phone Number";
            // 
            // nameListbox
            // 
            nameListbox.FormattingEnabled = true;
            nameListbox.ItemHeight = 15;
            nameListbox.Location = new Point(91, 145);
            nameListbox.Name = "nameListbox";
            nameListbox.Size = new Size(120, 124);
            nameListbox.TabIndex = 1;
            // 
            // phoneLabel
            // 
            phoneLabel.BorderStyle = BorderStyle.FixedSingle;
            phoneLabel.Location = new Point(259, 190);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(123, 25);
            phoneLabel.TabIndex = 2;
            phoneLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(199, 293);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 3;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(111, 117);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 4;
            label3.Text = "Enter a Name";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 450);
            Controls.Add(label3);
            Controls.Add(exitButton);
            Controls.Add(phoneLabel);
            Controls.Add(nameListbox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox nameListbox;
        private Label phoneLabel;
        private Button exitButton;
        private Label label3;
    }
}
