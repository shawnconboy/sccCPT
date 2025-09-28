namespace bodyMassIndexEnhancement
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
            calculateButton = new Button();
            clearButton = new Button();
            exitButton = new Button();
            heightLabel = new Label();
            heightTextbox = new TextBox();
            weightLabel = new Label();
            weightTextbox = new TextBox();
            bmiLabel = new Label();
            bmiTextbox = new TextBox();
            resultLabel = new Label();
            SuspendLayout();
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(242, 309);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(94, 29);
            calculateButton.TabIndex = 2;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(353, 309);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(94, 29);
            clearButton.TabIndex = 3;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(465, 309);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(94, 29);
            exitButton.TabIndex = 4;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // heightLabel
            // 
            heightLabel.AutoSize = true;
            heightLabel.Location = new Point(242, 87);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new Size(150, 20);
            heightLabel.TabIndex = 1;
            heightLabel.Text = "Enter height in inches";
            // 
            // heightTextbox
            // 
            heightTextbox.Location = new Point(434, 84);
            heightTextbox.Name = "heightTextbox";
            heightTextbox.Size = new Size(125, 27);
            heightTextbox.TabIndex = 0;
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Location = new Point(242, 138);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new Size(161, 20);
            weightLabel.TabIndex = 8;
            weightLabel.Text = "Enter weight in pounds";
            // 
            // weightTextbox
            // 
            weightTextbox.Location = new Point(434, 135);
            weightTextbox.Name = "weightTextbox";
            weightTextbox.Size = new Size(125, 27);
            weightTextbox.TabIndex = 1;
            // 
            // bmiLabel
            // 
            bmiLabel.AutoSize = true;
            bmiLabel.Location = new Point(242, 187);
            bmiLabel.Name = "bmiLabel";
            bmiLabel.Size = new Size(82, 20);
            bmiLabel.TabIndex = 0;
            bmiLabel.Text = "Your BMI is";
            // 
            // bmiTextbox
            // 
            bmiTextbox.BackColor = SystemColors.Window;
            bmiTextbox.Location = new Point(434, 184);
            bmiTextbox.Name = "bmiTextbox";
            bmiTextbox.ReadOnly = true;
            bmiTextbox.Size = new Size(125, 27);
            bmiTextbox.TabIndex = 0;
            // 
            // resultLabel
            // 
            resultLabel.Location = new Point(242, 243);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(317, 44);
            resultLabel.TabIndex = 5;
            resultLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AcceptButton = calculateButton;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = exitButton;
            ClientSize = new Size(800, 450);
            Controls.Add(resultLabel);
            Controls.Add(bmiTextbox);
            Controls.Add(bmiLabel);
            Controls.Add(weightTextbox);
            Controls.Add(weightLabel);
            Controls.Add(heightTextbox);
            Controls.Add(heightLabel);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(calculateButton);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BMI Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button calculateButton;
        private Button clearButton;
        private Button exitButton;
        private Label heightLabel;
        private TextBox heightTextbox;
        private Label weightLabel;
        private TextBox weightTextbox;
        private Label bmiLabel;
        private TextBox bmiTextbox;
        private Label resultLabel;
    }
}
