namespace nameFormatter
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
            firstNameTextbox = new TextBox();
            middleNameTextbox = new TextBox();
            lastNameTextbox = new TextBox();
            suffixTextbox = new TextBox();
            headingLabel = new Label();
            suffixFirstMiddleLastButton = new Button();
            firstMiddleLastButton = new Button();
            firstLastButton = new Button();
            lastFirstMiddleSuffixButton = new Button();
            lastFirstMiddleButton = new Button();
            lastFirstButton = new Button();
            exitButton = new Button();
            resultLabel = new Label();
            clearButton = new Button();
            SuspendLayout();
            // 
            // firstNameTextbox
            // 
            firstNameTextbox.Location = new Point(276, 65);
            firstNameTextbox.Name = "firstNameTextbox";
            firstNameTextbox.PlaceholderText = "First Name";
            firstNameTextbox.Size = new Size(166, 23);
            firstNameTextbox.TabIndex = 0;
            // 
            // middleNameTextbox
            // 
            middleNameTextbox.Location = new Point(276, 108);
            middleNameTextbox.Name = "middleNameTextbox";
            middleNameTextbox.PlaceholderText = "Middle Name";
            middleNameTextbox.Size = new Size(166, 23);
            middleNameTextbox.TabIndex = 1;
            // 
            // lastNameTextbox
            // 
            lastNameTextbox.Location = new Point(276, 155);
            lastNameTextbox.Name = "lastNameTextbox";
            lastNameTextbox.PlaceholderText = "Last Name";
            lastNameTextbox.Size = new Size(166, 23);
            lastNameTextbox.TabIndex = 2;
            // 
            // suffixTextbox
            // 
            suffixTextbox.Location = new Point(276, 205);
            suffixTextbox.Name = "suffixTextbox";
            suffixTextbox.PlaceholderText = "Mr. Mrs. Ms. Dr. Sr. Etc...";
            suffixTextbox.Size = new Size(166, 23);
            suffixTextbox.TabIndex = 3;
            // 
            // headingLabel
            // 
            headingLabel.AutoSize = true;
            headingLabel.Location = new Point(276, 22);
            headingLabel.Name = "headingLabel";
            headingLabel.Size = new Size(166, 15);
            headingLabel.TabIndex = 0;
            headingLabel.Text = "Please enter your information.";
            headingLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // suffixFirstMiddleLastButton
            // 
            suffixFirstMiddleLastButton.Location = new Point(119, 268);
            suffixFirstMiddleLastButton.Name = "suffixFirstMiddleLastButton";
            suffixFirstMiddleLastButton.Size = new Size(140, 25);
            suffixFirstMiddleLastButton.TabIndex = 4;
            suffixFirstMiddleLastButton.Text = "Suffix First Middle Last";
            suffixFirstMiddleLastButton.UseVisualStyleBackColor = true;
            suffixFirstMiddleLastButton.Click += suffixFirstMiddleLastButton_Click;
            // 
            // firstMiddleLastButton
            // 
            firstMiddleLastButton.Location = new Point(289, 268);
            firstMiddleLastButton.Name = "firstMiddleLastButton";
            firstMiddleLastButton.Size = new Size(140, 25);
            firstMiddleLastButton.TabIndex = 5;
            firstMiddleLastButton.Text = "First Middle Last";
            firstMiddleLastButton.UseVisualStyleBackColor = true;
            firstMiddleLastButton.Click += firstMiddleLastButton_Click;
            // 
            // firstLastButton
            // 
            firstLastButton.Location = new Point(460, 268);
            firstLastButton.Name = "firstLastButton";
            firstLastButton.Size = new Size(140, 25);
            firstLastButton.TabIndex = 6;
            firstLastButton.Text = "First Last";
            firstLastButton.UseVisualStyleBackColor = true;
            firstLastButton.Click += firstLastButton_Click;
            // 
            // lastFirstMiddleSuffixButton
            // 
            lastFirstMiddleSuffixButton.Location = new Point(119, 319);
            lastFirstMiddleSuffixButton.Name = "lastFirstMiddleSuffixButton";
            lastFirstMiddleSuffixButton.Size = new Size(140, 25);
            lastFirstMiddleSuffixButton.TabIndex = 7;
            lastFirstMiddleSuffixButton.Text = "Last, First Middle, Suffix";
            lastFirstMiddleSuffixButton.UseVisualStyleBackColor = true;
            lastFirstMiddleSuffixButton.Click += lastFirstMiddleSuffixButton_Click;
            // 
            // lastFirstMiddleButton
            // 
            lastFirstMiddleButton.Location = new Point(289, 319);
            lastFirstMiddleButton.Name = "lastFirstMiddleButton";
            lastFirstMiddleButton.Size = new Size(140, 25);
            lastFirstMiddleButton.TabIndex = 8;
            lastFirstMiddleButton.Text = "Last, First Middle";
            lastFirstMiddleButton.UseVisualStyleBackColor = true;
            lastFirstMiddleButton.Click += lastFirstMiddleButton_Click;
            // 
            // lastFirstButton
            // 
            lastFirstButton.Location = new Point(460, 319);
            lastFirstButton.Name = "lastFirstButton";
            lastFirstButton.Size = new Size(140, 25);
            lastFirstButton.TabIndex = 9;
            lastFirstButton.Text = "Last, First";
            lastFirstButton.UseVisualStyleBackColor = true;
            lastFirstButton.Click += lastFirstButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(376, 449);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 11;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // resultLabel
            // 
            resultLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultLabel.Location = new Point(211, 395);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(297, 40);
            resultLabel.TabIndex = 11;
            resultLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(267, 448);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 10;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = exitButton;
            ClientSize = new Size(718, 498);
            Controls.Add(clearButton);
            Controls.Add(resultLabel);
            Controls.Add(exitButton);
            Controls.Add(firstLastButton);
            Controls.Add(firstMiddleLastButton);
            Controls.Add(lastFirstButton);
            Controls.Add(lastFirstMiddleButton);
            Controls.Add(lastFirstMiddleSuffixButton);
            Controls.Add(suffixFirstMiddleLastButton);
            Controls.Add(headingLabel);
            Controls.Add(suffixTextbox);
            Controls.Add(lastNameTextbox);
            Controls.Add(middleNameTextbox);
            Controls.Add(firstNameTextbox);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Name Formatter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstNameTextbox;
        private TextBox middleNameTextbox;
        private TextBox lastNameTextbox;
        private TextBox suffixTextbox;
        private Label headingLabel;
        private Button suffixFirstMiddleLastButton;
        private Button firstMiddleLastButton;
        private Button firstLastButton;
        private Button lastFirstMiddleSuffixButton;
        private Button lastFirstMiddleButton;
        private Button lastFirstButton;
        private Button exitButton;
        private Label resultLabel;
        private Button clearButton;
    }
}
