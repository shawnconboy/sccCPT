namespace romanNumeralConverter
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
            enterNumberLabel = new Label();
            label2 = new Label();
            userNumberTextbox = new TextBox();
            conversionLabel = new Label();
            convertButton = new Button();
            clearButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // enterNumberLabel
            // 
            enterNumberLabel.AutoSize = true;
            enterNumberLabel.Location = new Point(124, 126);
            enterNumberLabel.Name = "enterNumberLabel";
            enterNumberLabel.Size = new Size(187, 15);
            enterNumberLabel.TabIndex = 0;
            enterNumberLabel.Text = "Enter a number from 1 through 10";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(141, 56);
            label2.Name = "label2";
            label2.Size = new Size(276, 30);
            label2.TabIndex = 1;
            label2.Text = "Roman Numeral Converter";
            // 
            // userNumberTextbox
            // 
            userNumberTextbox.Location = new Point(334, 123);
            userNumberTextbox.Name = "userNumberTextbox";
            userNumberTextbox.Size = new Size(100, 23);
            userNumberTextbox.TabIndex = 0;
            // 
            // conversionLabel
            // 
            conversionLabel.AutoSize = true;
            conversionLabel.Location = new Point(228, 187);
            conversionLabel.Name = "conversionLabel";
            conversionLabel.Size = new Size(68, 15);
            conversionLabel.TabIndex = 3;
            conversionLabel.Text = "Converted :";
            // 
            // convertButton
            // 
            convertButton.Location = new Point(161, 292);
            convertButton.Name = "convertButton";
            convertButton.Size = new Size(75, 23);
            convertButton.TabIndex = 1;
            convertButton.Text = "Convert";
            convertButton.UseVisualStyleBackColor = true;
            convertButton.Click += convertButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(242, 292);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 2;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(323, 292);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 3;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AcceptButton = convertButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = exitButton;
            ClientSize = new Size(558, 450);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(convertButton);
            Controls.Add(conversionLabel);
            Controls.Add(userNumberTextbox);
            Controls.Add(label2);
            Controls.Add(enterNumberLabel);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Roman Numeral Converter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label enterNumberLabel;
        private Label label2;
        private TextBox userNumberTextbox;
        private Label conversionLabel;
        private Button convertButton;
        private Button clearButton;
        private Button exitButton;
    }
}
