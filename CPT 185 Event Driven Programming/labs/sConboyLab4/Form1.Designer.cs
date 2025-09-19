namespace sConboyLab4
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
            headingLabel = new Label();
            distanceTextbox = new TextBox();
            groupBox1 = new GroupBox();
            fromListbox = new ListBox();
            groupBox2 = new GroupBox();
            toListbox = new ListBox();
            subHeadingLabel = new Label();
            convertedLabel = new Label();
            convertButton = new Button();
            exitButton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // headingLabel
            // 
            headingLabel.AutoSize = true;
            headingLabel.Location = new Point(179, 46);
            headingLabel.Name = "headingLabel";
            headingLabel.Size = new Size(185, 20);
            headingLabel.TabIndex = 0;
            headingLabel.Text = "Enter a distance to convert";
            // 
            // distanceTextbox
            // 
            distanceTextbox.Location = new Point(437, 43);
            distanceTextbox.Name = "distanceTextbox";
            distanceTextbox.Size = new Size(125, 27);
            distanceTextbox.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(fromListbox);
            groupBox1.Location = new Point(114, 108);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 136);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "From";
            // 
            // fromListbox
            // 
            fromListbox.FormattingEnabled = true;
            fromListbox.Items.AddRange(new object[] { "Inches", "Feet", "Yards" });
            fromListbox.Location = new Point(42, 28);
            fromListbox.Name = "fromListbox";
            fromListbox.Size = new Size(166, 64);
            fromListbox.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(toListbox);
            groupBox2.Location = new Point(437, 108);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 136);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "To";
            // 
            // toListbox
            // 
            toListbox.FormattingEnabled = true;
            toListbox.Items.AddRange(new object[] { "Inches", "Feet", "Yards" });
            toListbox.Location = new Point(42, 28);
            toListbox.Name = "toListbox";
            toListbox.Size = new Size(166, 64);
            toListbox.TabIndex = 0;
            // 
            // subHeadingLabel
            // 
            subHeadingLabel.AutoSize = true;
            subHeadingLabel.Location = new Point(226, 296);
            subHeadingLabel.Name = "subHeadingLabel";
            subHeadingLabel.Size = new Size(138, 20);
            subHeadingLabel.TabIndex = 0;
            subHeadingLabel.Text = "Converted Distance";
            // 
            // convertedLabel
            // 
            convertedLabel.BorderStyle = BorderStyle.FixedSingle;
            convertedLabel.Location = new Point(437, 284);
            convertedLabel.Name = "convertedLabel";
            convertedLabel.Size = new Size(179, 32);
            convertedLabel.TabIndex = 0;
            // 
            // convertButton
            // 
            convertButton.Location = new Point(270, 382);
            convertButton.Name = "convertButton";
            convertButton.Size = new Size(94, 29);
            convertButton.TabIndex = 3;
            convertButton.Text = "Convert";
            convertButton.UseVisualStyleBackColor = true;
            convertButton.Click += convertButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(437, 382);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(94, 29);
            exitButton.TabIndex = 3;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AcceptButton = convertButton;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = exitButton;
            ClientSize = new Size(800, 450);
            Controls.Add(exitButton);
            Controls.Add(convertButton);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(distanceTextbox);
            Controls.Add(convertedLabel);
            Controls.Add(subHeadingLabel);
            Controls.Add(headingLabel);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Distance Converter";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headingLabel;
        private TextBox distanceTextbox;
        private GroupBox groupBox1;
        private ListBox fromListbox;
        private GroupBox groupBox2;
        private ListBox toListbox;
        private Label subHeadingLabel;
        private Label convertedLabel;
        private Button convertButton;
        private Button exitButton;
    }
}
