namespace tutorial5_1
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
            startLabel = new Label();
            monthsLabel = new Label();
            endLabel = new Label();
            endingBalanceLabel = new Label();
            startingBalanceTextbox = new TextBox();
            monthsTextbox = new TextBox();
            calculateButton = new Button();
            clearButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // startLabel
            // 
            startLabel.AutoSize = true;
            startLabel.Location = new Point(79, 57);
            startLabel.Name = "startLabel";
            startLabel.Size = new Size(92, 15);
            startLabel.TabIndex = 0;
            startLabel.Text = "Starting Balance";
            // 
            // monthsLabel
            // 
            monthsLabel.AutoSize = true;
            monthsLabel.Location = new Point(79, 94);
            monthsLabel.Name = "monthsLabel";
            monthsLabel.Size = new Size(109, 15);
            monthsLabel.TabIndex = 0;
            monthsLabel.Text = "Number of Months";
            // 
            // endLabel
            // 
            endLabel.AutoSize = true;
            endLabel.Location = new Point(79, 132);
            endLabel.Name = "endLabel";
            endLabel.Size = new Size(88, 15);
            endLabel.TabIndex = 0;
            endLabel.Text = "Ending Balance";
            // 
            // endingBalanceLabel
            // 
            endingBalanceLabel.BackColor = SystemColors.Window;
            endingBalanceLabel.BorderStyle = BorderStyle.FixedSingle;
            endingBalanceLabel.Location = new Point(244, 132);
            endingBalanceLabel.Name = "endingBalanceLabel";
            endingBalanceLabel.Size = new Size(100, 23);
            endingBalanceLabel.TabIndex = 0;
            endingBalanceLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // startingBalanceTextbox
            // 
            startingBalanceTextbox.Location = new Point(244, 54);
            startingBalanceTextbox.Name = "startingBalanceTextbox";
            startingBalanceTextbox.Size = new Size(100, 23);
            startingBalanceTextbox.TabIndex = 0;
            // 
            // monthsTextbox
            // 
            monthsTextbox.Location = new Point(244, 91);
            monthsTextbox.Name = "monthsTextbox";
            monthsTextbox.Size = new Size(100, 23);
            monthsTextbox.TabIndex = 1;
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(69, 202);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(75, 23);
            calculateButton.TabIndex = 2;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(169, 202);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 3;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(269, 202);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 4;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AcceptButton = calculateButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = exitButton;
            ClientSize = new Size(413, 246);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(calculateButton);
            Controls.Add(monthsTextbox);
            Controls.Add(startingBalanceTextbox);
            Controls.Add(endingBalanceLabel);
            Controls.Add(endLabel);
            Controls.Add(monthsLabel);
            Controls.Add(startLabel);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ending Balance";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label startLabel;
        private Label monthsLabel;
        private Label endLabel;
        private Label endingBalanceLabel;
        private TextBox startingBalanceTextbox;
        private TextBox monthsTextbox;
        private Button calculateButton;
        private Button clearButton;
        private Button exitButton;
    }
}
