namespace wordSeparator
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
            userTextbox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            convertButton = new Button();
            clearButton = new Button();
            exitButton = new Button();
            resultLabel = new Label();
            SuspendLayout();
            // 
            // userTextbox
            // 
            userTextbox.Location = new Point(168, 132);
            userTextbox.Name = "userTextbox";
            userTextbox.Size = new Size(279, 26);
            userTextbox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(255, 48);
            label1.Name = "label1";
            label1.Size = new Size(105, 19);
            label1.TabIndex = 1;
            label1.Text = "Word Separator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(180, 95);
            label2.Name = "label2";
            label2.Size = new Size(255, 19);
            label2.TabIndex = 2;
            label2.Text = "Enter a set of words with no separations";
            // 
            // convertButton
            // 
            convertButton.Location = new Point(172, 264);
            convertButton.Name = "convertButton";
            convertButton.Size = new Size(86, 26);
            convertButton.TabIndex = 3;
            convertButton.Text = "Convert";
            convertButton.UseVisualStyleBackColor = true;
            convertButton.Click += convertButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(264, 264);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(86, 26);
            clearButton.TabIndex = 4;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(356, 264);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(86, 26);
            exitButton.TabIndex = 5;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // resultLabel
            // 
            resultLabel.BorderStyle = BorderStyle.FixedSingle;
            resultLabel.Location = new Point(172, 200);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(270, 22);
            resultLabel.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 450);
            Controls.Add(resultLabel);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(convertButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(userTextbox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userTextbox;
        private Label label1;
        private Label label2;
        private Button convertButton;
        private Button clearButton;
        private Button exitButton;
        private Label resultLabel;
    }
}
