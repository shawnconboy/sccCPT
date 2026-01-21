namespace penniesForPay
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
            subHeaderLabel = new Label();
            numDaysTextbox = new TextBox();
            resultLabel = new Label();
            calculateButton = new Button();
            clearButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(251, 48);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 0;
            label1.Text = "Pennies For Pay";
            // 
            // subHeaderLabel
            // 
            subHeaderLabel.AutoSize = true;
            subHeaderLabel.Location = new Point(145, 118);
            subHeaderLabel.Name = "subHeaderLabel";
            subHeaderLabel.Size = new Size(162, 15);
            subHeaderLabel.TabIndex = 1;
            subHeaderLabel.Text = "Enter number of days worked";
            // 
            // numDaysTextbox
            // 
            numDaysTextbox.Location = new Point(347, 115);
            numDaysTextbox.Name = "numDaysTextbox";
            numDaysTextbox.Size = new Size(100, 23);
            numDaysTextbox.TabIndex = 2;
            // 
            // resultLabel
            // 
            resultLabel.Location = new Point(246, 172);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(100, 23);
            resultLabel.TabIndex = 3;
            resultLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(145, 245);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(75, 23);
            calculateButton.TabIndex = 4;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(259, 245);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 4;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(372, 245);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 4;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AcceptButton = calculateButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = exitButton;
            ClientSize = new Size(593, 317);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(calculateButton);
            Controls.Add(resultLabel);
            Controls.Add(numDaysTextbox);
            Controls.Add(subHeaderLabel);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pennies For Pay";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label subHeaderLabel;
        private TextBox numDaysTextbox;
        private Label resultLabel;
        private Button calculateButton;
        private Button clearButton;
        private Button exitButton;
    }
}
