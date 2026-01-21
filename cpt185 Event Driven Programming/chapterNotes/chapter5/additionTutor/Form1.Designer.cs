namespace tuitionCalculator
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
            headerLabel = new Label();
            problemLabel = new Label();
            userAnswerTextbox = new TextBox();
            checkButton = new Button();
            skipButton = new Button();
            finishButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headerLabel.Location = new Point(273, 36);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(254, 25);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Add the numbers together!";
            // 
            // problemLabel
            // 
            problemLabel.Location = new Point(348, 116);
            problemLabel.Name = "problemLabel";
            problemLabel.Size = new Size(100, 23);
            problemLabel.TabIndex = 1;
            problemLabel.Text = "num1 + num2 = ?";
            problemLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // userAnswerTextbox
            // 
            userAnswerTextbox.Location = new Point(348, 175);
            userAnswerTextbox.Name = "userAnswerTextbox";
            userAnswerTextbox.Size = new Size(100, 23);
            userAnswerTextbox.TabIndex = 2;
            // 
            // checkButton
            // 
            checkButton.Location = new Point(238, 279);
            checkButton.Name = "checkButton";
            checkButton.Size = new Size(104, 23);
            checkButton.TabIndex = 3;
            checkButton.Text = "Check Answer";
            checkButton.UseVisualStyleBackColor = true;
            checkButton.Click += checkButton_Click;
            // 
            // skipButton
            // 
            skipButton.Location = new Point(348, 279);
            skipButton.Name = "skipButton";
            skipButton.Size = new Size(104, 23);
            skipButton.TabIndex = 3;
            skipButton.Text = "Skip";
            skipButton.UseVisualStyleBackColor = true;
            skipButton.Click += skipButton_Click;
            // 
            // finishButton
            // 
            finishButton.Location = new Point(459, 279);
            finishButton.Name = "finishButton";
            finishButton.Size = new Size(104, 23);
            finishButton.TabIndex = 3;
            finishButton.Text = "Finish";
            finishButton.UseVisualStyleBackColor = true;
            finishButton.Click += finishButton_Click;
            // 
            // Form1
            // 
            AcceptButton = checkButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = finishButton;
            ClientSize = new Size(800, 450);
            Controls.Add(finishButton);
            Controls.Add(skipButton);
            Controls.Add(checkButton);
            Controls.Add(userAnswerTextbox);
            Controls.Add(problemLabel);
            Controls.Add(headerLabel);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Addition Tutor";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Label problemLabel;
        private TextBox userAnswerTextbox;
        private Button checkButton;
        private Button skipButton;
        private Button finishButton;
    }
}
