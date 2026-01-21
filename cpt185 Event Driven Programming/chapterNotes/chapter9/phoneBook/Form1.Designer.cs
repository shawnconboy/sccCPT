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
            label1.Location = new Point(321, 220);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 0;
            label1.Text = "Phone Number";
            // 
            // nameListbox
            // 
            nameListbox.FormattingEnabled = true;
            nameListbox.Location = new Point(104, 193);
            nameListbox.Margin = new Padding(3, 4, 3, 4);
            nameListbox.Name = "nameListbox";
            nameListbox.Size = new Size(137, 164);
            nameListbox.TabIndex = 1;
            nameListbox.SelectedIndexChanged += nameListbox_SelectedIndexChanged;
            // 
            // phoneLabel
            // 
            phoneLabel.BorderStyle = BorderStyle.FixedSingle;
            phoneLabel.Location = new Point(296, 253);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(140, 33);
            phoneLabel.TabIndex = 2;
            phoneLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(227, 391);
            exitButton.Margin = new Padding(3, 4, 3, 4);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(86, 31);
            exitButton.TabIndex = 3;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(127, 156);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 4;
            label3.Text = "Enter a Name";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 600);
            Controls.Add(label3);
            Controls.Add(exitButton);
            Controls.Add(phoneLabel);
            Controls.Add(nameListbox);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
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
