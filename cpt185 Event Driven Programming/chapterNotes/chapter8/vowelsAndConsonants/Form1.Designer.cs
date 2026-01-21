namespace vowelsAndConsonants
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
            label2 = new Label();
            vowelsLabel = new Label();
            consonantsLabel = new Label();
            SuspendLayout();
            // 
            // userEntryTextbox
            // 
            userEntryTextbox.Location = new Point(275, 210);
            userEntryTextbox.Multiline = true;
            userEntryTextbox.Name = "userEntryTextbox";
            userEntryTextbox.Size = new Size(250, 30);
            userEntryTextbox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(275, 114);
            label1.Name = "label1";
            label1.Size = new Size(246, 30);
            label1.TabIndex = 1;
            label1.Text = "Vowels and Consonants";
            // 
            // checkButton
            // 
            checkButton.Location = new Point(248, 356);
            checkButton.Name = "checkButton";
            checkButton.Size = new Size(75, 23);
            checkButton.TabIndex = 2;
            checkButton.Text = "Check";
            checkButton.UseVisualStyleBackColor = true;
            checkButton.Click += checkButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(363, 356);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 3;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(475, 356);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 4;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(337, 174);
            label2.Name = "label2";
            label2.Size = new Size(127, 15);
            label2.TabIndex = 5;
            label2.Text = "Enter text to see results";
            // 
            // vowelsLabel
            // 
            vowelsLabel.AutoSize = true;
            vowelsLabel.Location = new Point(279, 271);
            vowelsLabel.Name = "vowelsLabel";
            vowelsLabel.Size = new Size(52, 15);
            vowelsLabel.TabIndex = 6;
            vowelsLabel.Text = "Vowels : ";
            // 
            // consonantsLabel
            // 
            consonantsLabel.AutoSize = true;
            consonantsLabel.Location = new Point(279, 306);
            consonantsLabel.Name = "consonantsLabel";
            consonantsLabel.Size = new Size(79, 15);
            consonantsLabel.TabIndex = 6;
            consonantsLabel.Text = "Consonants : ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(consonantsLabel);
            Controls.Add(vowelsLabel);
            Controls.Add(label2);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(checkButton);
            Controls.Add(label1);
            Controls.Add(userEntryTextbox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userEntryTextbox;
        private Label label1;
        private Button checkButton;
        private Button clearButton;
        private Button exitButton;
        private Label label2;
        private Label vowelsLabel;
        private Label consonantsLabel;
    }
}
