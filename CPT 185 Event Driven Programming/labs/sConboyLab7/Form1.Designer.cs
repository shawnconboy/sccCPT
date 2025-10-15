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
            SuspendLayout();
            // 
            // correctAnswerListbox
            // 
            correctAnswerListbox.FormattingEnabled = true;
            correctAnswerListbox.ItemHeight = 15;
            correctAnswerListbox.Location = new Point(65, 77);
            correctAnswerListbox.Name = "correctAnswerListbox";
            correctAnswerListbox.Size = new Size(120, 274);
            correctAnswerListbox.TabIndex = 0;
            // 
            // userAnswerListbox
            // 
            userAnswerListbox.FormattingEnabled = true;
            userAnswerListbox.ItemHeight = 15;
            userAnswerListbox.Location = new Point(254, 81);
            userAnswerListbox.Name = "userAnswerListbox";
            userAnswerListbox.Size = new Size(120, 274);
            userAnswerListbox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 48);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 2;
            label1.Text = "Correct Answers";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(254, 48);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 2;
            label2.Text = "User Answers";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
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
    }
}
