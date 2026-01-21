namespace chargeAccountValidation
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
            userEntryTextbox = new TextBox();
            label1 = new Label();
            checkButton = new Button();
            clearButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // userEntryTextbox
            // 
            userEntryTextbox.Location = new Point(152, 102);
            userEntryTextbox.Name = "userEntryTextbox";
            userEntryTextbox.Size = new Size(100, 23);
            userEntryTextbox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(126, 68);
            label1.Name = "label1";
            label1.Size = new Size(151, 15);
            label1.TabIndex = 1;
            label1.Text = "Search for account number";
            // 
            // checkButton
            // 
            checkButton.Location = new Point(83, 141);
            checkButton.Name = "checkButton";
            checkButton.Size = new Size(75, 23);
            checkButton.TabIndex = 2;
            checkButton.Text = "Check";
            checkButton.UseVisualStyleBackColor = true;
            checkButton.Click += checkButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(164, 141);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 2;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(245, 141);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 2;
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
            ClientSize = new Size(402, 232);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(checkButton);
            Controls.Add(label1);
            Controls.Add(userEntryTextbox);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Charge Account Validation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userEntryTextbox;
        private Label label1;
        private Button checkButton;
        private Button clearButton;
        private Button exitButton;
    }
}
