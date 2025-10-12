namespace tut7_2
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
            testScoresListbox = new ListBox();
            label2 = new Label();
            highScoreLabel = new Label();
            label4 = new Label();
            lowScoreLabel = new Label();
            label6 = new Label();
            averageScoreLabel = new Label();
            getScoresButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 76);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "Test Scores";
            // 
            // testScoresListbox
            // 
            testScoresListbox.FormattingEnabled = true;
            testScoresListbox.ItemHeight = 15;
            testScoresListbox.Location = new Point(72, 94);
            testScoresListbox.Name = "testScoresListbox";
            testScoresListbox.Size = new Size(120, 94);
            testScoresListbox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(228, 93);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 2;
            label2.Text = "Highest Score";
            // 
            // highScoreLabel
            // 
            highScoreLabel.BorderStyle = BorderStyle.FixedSingle;
            highScoreLabel.Location = new Point(346, 93);
            highScoreLabel.Name = "highScoreLabel";
            highScoreLabel.Size = new Size(51, 19);
            highScoreLabel.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(232, 136);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 2;
            label4.Text = "Lowest Score";
            // 
            // lowScoreLabel
            // 
            lowScoreLabel.BorderStyle = BorderStyle.FixedSingle;
            lowScoreLabel.Location = new Point(346, 135);
            lowScoreLabel.Name = "lowScoreLabel";
            lowScoreLabel.Size = new Size(51, 19);
            lowScoreLabel.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(226, 172);
            label6.Name = "label6";
            label6.Size = new Size(82, 15);
            label6.TabIndex = 2;
            label6.Text = "Average Score";
            // 
            // averageScoreLabel
            // 
            averageScoreLabel.BorderStyle = BorderStyle.FixedSingle;
            averageScoreLabel.Location = new Point(346, 172);
            averageScoreLabel.Name = "averageScoreLabel";
            averageScoreLabel.Size = new Size(51, 19);
            averageScoreLabel.TabIndex = 2;
            // 
            // getScoresButton
            // 
            getScoresButton.Location = new Point(142, 243);
            getScoresButton.Name = "getScoresButton";
            getScoresButton.Size = new Size(75, 23);
            getScoresButton.TabIndex = 3;
            getScoresButton.Text = "Get Scores";
            getScoresButton.UseVisualStyleBackColor = true;
            getScoresButton.Click += getScoresButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(251, 243);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 4;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 343);
            Controls.Add(exitButton);
            Controls.Add(getScoresButton);
            Controls.Add(averageScoreLabel);
            Controls.Add(lowScoreLabel);
            Controls.Add(highScoreLabel);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(testScoresListbox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox testScoresListbox;
        private Label label2;
        private Label highScoreLabel;
        private Label label4;
        private Label lowScoreLabel;
        private Label label6;
        private Label averageScoreLabel;
        private Button getScoresButton;
        private Button exitButton;
    }
}
