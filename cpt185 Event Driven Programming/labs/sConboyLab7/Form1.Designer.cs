namespace sConboyLab7
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
            correctAnswerListbox = new ListBox();
            userAnswerListbox = new ListBox();
            label1 = new Label();
            label2 = new Label();
            incorrectAnswerListbox = new ListBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            correctLabel = new Label();
            wrongLabel = new Label();
            SuspendLayout();
            // 
            // correctAnswerListbox
            // 
            correctAnswerListbox.FormattingEnabled = true;
            correctAnswerListbox.ItemHeight = 15;
            correctAnswerListbox.Location = new Point(71, 81);
            correctAnswerListbox.Name = "correctAnswerListbox";
            correctAnswerListbox.Size = new Size(120, 304);
            correctAnswerListbox.TabIndex = 0;
            // 
            // userAnswerListbox
            // 
            userAnswerListbox.FormattingEnabled = true;
            userAnswerListbox.ItemHeight = 15;
            userAnswerListbox.Location = new Point(241, 81);
            userAnswerListbox.Name = "userAnswerListbox";
            userAnswerListbox.Size = new Size(120, 304);
            userAnswerListbox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 52);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 2;
            label1.Text = "Correct Answers";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(241, 48);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 2;
            label2.Text = "User Answers";
            // 
            // incorrectAnswerListbox
            // 
            incorrectAnswerListbox.FormattingEnabled = true;
            incorrectAnswerListbox.ItemHeight = 15;
            incorrectAnswerListbox.Location = new Point(409, 81);
            incorrectAnswerListbox.Name = "incorrectAnswerListbox";
            incorrectAnswerListbox.Size = new Size(120, 304);
            incorrectAnswerListbox.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(409, 48);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 2;
            label3.Text = "Incorrect Answers";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 447);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 3;
            label4.Text = "Correct :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(71, 485);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 3;
            label5.Text = "Wrong :";
            // 
            // correctLabel
            // 
            correctLabel.BorderStyle = BorderStyle.FixedSingle;
            correctLabel.Location = new Point(139, 447);
            correctLabel.Name = "correctLabel";
            correctLabel.Size = new Size(52, 15);
            correctLabel.TabIndex = 3;
            correctLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // wrongLabel
            // 
            wrongLabel.BorderStyle = BorderStyle.FixedSingle;
            wrongLabel.Location = new Point(139, 485);
            wrongLabel.Name = "wrongLabel";
            wrongLabel.Size = new Size(49, 15);
            wrongLabel.TabIndex = 3;
            wrongLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 601);
            Controls.Add(wrongLabel);
            Controls.Add(label5);
            Controls.Add(correctLabel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(incorrectAnswerListbox);
            Controls.Add(userAnswerListbox);
            Controls.Add(correctAnswerListbox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox correctAnswerListbox;
        private ListBox userAnswerListbox;
        private Label label1;
        private Label label2;
        private ListBox incorrectAnswerListbox;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label correctLabel;
        private Label wrongLabel;
    }
}
