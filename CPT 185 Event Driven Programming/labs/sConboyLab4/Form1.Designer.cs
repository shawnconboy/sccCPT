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
            components = new System.ComponentModel.Container();
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
            clearButton = new Button();
            toolTip1 = new ToolTip(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // headingLabel
            // 
            headingLabel.AutoSize = true;
            headingLabel.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            headingLabel.Location = new Point(157, 34);
            headingLabel.Name = "headingLabel";
            headingLabel.Size = new Size(150, 15);
            headingLabel.TabIndex = 0;
            headingLabel.Text = "Enter a distance to convert";
            // 
            // distanceTextbox
            // 
            distanceTextbox.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            distanceTextbox.Location = new Point(382, 32);
            distanceTextbox.Margin = new Padding(3, 2, 3, 2);
            distanceTextbox.Name = "distanceTextbox";
            distanceTextbox.Size = new Size(110, 22);
            distanceTextbox.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(fromListbox);
            groupBox1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            groupBox1.Location = new Point(100, 81);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(219, 102);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "From";
            // 
            // fromListbox
            // 
            fromListbox.FormattingEnabled = true;
            fromListbox.ItemHeight = 15;
            fromListbox.Items.AddRange(new object[] { "Inches", "Feet", "Yards" });
            fromListbox.Location = new Point(37, 21);
            fromListbox.Margin = new Padding(3, 2, 3, 2);
            fromListbox.Name = "fromListbox";
            fromListbox.Size = new Size(146, 49);
            fromListbox.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(toListbox);
            groupBox2.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            groupBox2.Location = new Point(382, 81);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(219, 102);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "To";
            // 
            // toListbox
            // 
            toListbox.FormattingEnabled = true;
            toListbox.ItemHeight = 15;
            toListbox.Items.AddRange(new object[] { "Inches", "Feet", "Yards" });
            toListbox.Location = new Point(37, 21);
            toListbox.Margin = new Padding(3, 2, 3, 2);
            toListbox.Name = "toListbox";
            toListbox.Size = new Size(146, 49);
            toListbox.TabIndex = 0;
            // 
            // subHeadingLabel
            // 
            subHeadingLabel.AutoSize = true;
            subHeadingLabel.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            subHeadingLabel.Location = new Point(198, 222);
            subHeadingLabel.Name = "subHeadingLabel";
            subHeadingLabel.Size = new Size(113, 15);
            subHeadingLabel.TabIndex = 0;
            subHeadingLabel.Text = "Converted Distance";
            // 
            // convertedLabel
            // 
            convertedLabel.BorderStyle = BorderStyle.FixedSingle;
            convertedLabel.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            convertedLabel.Location = new Point(382, 213);
            convertedLabel.Name = "convertedLabel";
            convertedLabel.Size = new Size(157, 24);
            convertedLabel.TabIndex = 0;
            convertedLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // convertButton
            // 
            convertButton.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            convertButton.Location = new Point(211, 286);
            convertButton.Margin = new Padding(3, 2, 3, 2);
            convertButton.Name = "convertButton";
            convertButton.Size = new Size(82, 22);
            convertButton.TabIndex = 3;
            convertButton.Text = "&Convert";
            toolTip1.SetToolTip(convertButton, "press to convert distance");
            convertButton.UseVisualStyleBackColor = true;
            convertButton.Click += convertButton_Click;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            exitButton.Location = new Point(407, 286);
            exitButton.Margin = new Padding(3, 2, 3, 2);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(82, 22);
            exitButton.TabIndex = 4;
            exitButton.Text = "E&xit";
            toolTip1.SetToolTip(exitButton, "press to exit the form");
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // clearButton
            // 
            clearButton.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            clearButton.Location = new Point(313, 286);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 5;
            clearButton.Text = "C&lear";
            toolTip1.SetToolTip(clearButton, "press to clear the form");
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // Form1
            // 
            AcceptButton = convertButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = exitButton;
            ClientSize = new Size(700, 338);
            Controls.Add(clearButton);
            Controls.Add(exitButton);
            Controls.Add(convertButton);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(distanceTextbox);
            Controls.Add(convertedLabel);
            Controls.Add(subHeadingLabel);
            Controls.Add(headingLabel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Shawn Conboy Chapter 4 Distance Converter";
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
        private Button clearButton;
        private ToolTip toolTip1;
    }
}
