namespace question12_13
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
            userTextbox = new TextBox();
            confirmButton = new Button();
            exitButton = new Button();
            clearButton = new Button();
            saveFileDialogRandom = new SaveFileDialog();
            randomNumbersListbox = new ListBox();
            readButton = new Button();
            OpenFileDialogRandom = new OpenFileDialog();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 62);
            label1.Name = "label1";
            label1.Size = new Size(291, 20);
            label1.TabIndex = 0;
            label1.Text = "How many random numbers do you need?";
            // 
            // userTextbox
            // 
            userTextbox.Location = new Point(435, 59);
            userTextbox.Name = "userTextbox";
            userTextbox.Size = new Size(125, 27);
            userTextbox.TabIndex = 0;
            // 
            // confirmButton
            // 
            confirmButton.Location = new Point(153, 164);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(94, 29);
            confirmButton.TabIndex = 1;
            confirmButton.Text = "Confirm";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += confirmButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(403, 164);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(94, 29);
            exitButton.TabIndex = 3;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(276, 164);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(94, 29);
            clearButton.TabIndex = 2;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // randomNumbersListbox
            // 
            randomNumbersListbox.FormattingEnabled = true;
            randomNumbersListbox.Location = new Point(175, 271);
            randomNumbersListbox.Name = "randomNumbersListbox";
            randomNumbersListbox.Size = new Size(150, 104);
            randomNumbersListbox.TabIndex = 4;
            // 
            // readButton
            // 
            readButton.Location = new Point(366, 273);
            readButton.Name = "readButton";
            readButton.Size = new Size(94, 29);
            readButton.TabIndex = 5;
            readButton.Text = "Read File";
            readButton.UseVisualStyleBackColor = true;
            readButton.Click += readButton_Click;
            // 
            // OpenFileDialogRandom
            // 
            OpenFileDialogRandom.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AcceptButton = confirmButton;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = exitButton;
            ClientSize = new Size(651, 635);
            Controls.Add(readButton);
            Controls.Add(randomNumbersListbox);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(confirmButton);
            Controls.Add(userTextbox);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Random Number Generator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox userTextbox;
        private Button confirmButton;
        private Button exitButton;
        private Button clearButton;
        private SaveFileDialog saveFileDialogRandom;
        private ListBox randomNumbersListbox;
        private Button readButton;
        private OpenFileDialog OpenFileDialogRandom;
    }
}
