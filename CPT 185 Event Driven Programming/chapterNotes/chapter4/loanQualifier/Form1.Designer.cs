namespace loanQualifier
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
            salaryLabel = new Label();
            salaryTextbox = new TextBox();
            yearsWorkedLabel = new Label();
            yearsWorkedTextbox = new TextBox();
            loanDecisionLabel = new Label();
            resultLabel = new Label();
            checkButton = new Button();
            clearButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // salaryLabel
            // 
            salaryLabel.AutoSize = true;
            salaryLabel.Location = new Point(141, 79);
            salaryLabel.Name = "salaryLabel";
            salaryLabel.Size = new Size(79, 15);
            salaryLabel.TabIndex = 0;
            salaryLabel.Text = "Annual Salary";
            // 
            // salaryTextbox
            // 
            salaryTextbox.Location = new Point(339, 76);
            salaryTextbox.Name = "salaryTextbox";
            salaryTextbox.Size = new Size(100, 23);
            salaryTextbox.TabIndex = 0;
            // 
            // yearsWorkedLabel
            // 
            yearsWorkedLabel.AutoSize = true;
            yearsWorkedLabel.Location = new Point(141, 126);
            yearsWorkedLabel.Name = "yearsWorkedLabel";
            yearsWorkedLabel.Size = new Size(108, 15);
            yearsWorkedLabel.TabIndex = 0;
            yearsWorkedLabel.Text = "Years at current job";
            // 
            // yearsWorkedTextbox
            // 
            yearsWorkedTextbox.Location = new Point(339, 123);
            yearsWorkedTextbox.Name = "yearsWorkedTextbox";
            yearsWorkedTextbox.Size = new Size(100, 23);
            yearsWorkedTextbox.TabIndex = 1;
            // 
            // loanDecisionLabel
            // 
            loanDecisionLabel.AutoSize = true;
            loanDecisionLabel.Location = new Point(141, 198);
            loanDecisionLabel.Name = "loanDecisionLabel";
            loanDecisionLabel.Size = new Size(81, 15);
            loanDecisionLabel.TabIndex = 0;
            loanDecisionLabel.Text = "Loan Decision";
            // 
            // resultLabel
            // 
            resultLabel.BorderStyle = BorderStyle.FixedSingle;
            resultLabel.Location = new Point(141, 231);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(298, 26);
            resultLabel.TabIndex = 0;
            resultLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // checkButton
            // 
            checkButton.Location = new Point(141, 291);
            checkButton.Name = "checkButton";
            checkButton.Size = new Size(91, 39);
            checkButton.TabIndex = 2;
            checkButton.Text = "Check Qualification";
            checkButton.UseVisualStyleBackColor = true;
            checkButton.Click += checkButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(256, 291);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 39);
            clearButton.TabIndex = 3;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(364, 291);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 39);
            exitButton.TabIndex = 4;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AcceptButton = checkButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = exitButton;
            ClientSize = new Size(581, 450);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(checkButton);
            Controls.Add(yearsWorkedTextbox);
            Controls.Add(resultLabel);
            Controls.Add(loanDecisionLabel);
            Controls.Add(yearsWorkedLabel);
            Controls.Add(salaryTextbox);
            Controls.Add(salaryLabel);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label salaryLabel;
        private TextBox salaryTextbox;
        private Label yearsWorkedLabel;
        private TextBox yearsWorkedTextbox;
        private Label loanDecisionLabel;
        private Label resultLabel;
        private Button checkButton;
        private Button clearButton;
        private Button exitButton;
    }
}
