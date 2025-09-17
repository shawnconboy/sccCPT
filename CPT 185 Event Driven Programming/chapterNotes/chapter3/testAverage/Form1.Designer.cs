namespace testAverage
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
            test1Label = new Label();
            test2Label = new Label();
            test3Label = new Label();
            averageLabel = new Label();
            test1Textbox = new TextBox();
            test2Textbox = new TextBox();
            test3Textbox = new TextBox();
            resultLabel = new Label();
            calculateButton = new Button();
            clearButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // test1Label
            // 
            test1Label.AutoSize = true;
            test1Label.Location = new Point(175, 56);
            test1Label.Name = "test1Label";
            test1Label.Size = new Size(43, 15);
            test1Label.TabIndex = 0;
            test1Label.Text = "Test 1 :";
            // 
            // test2Label
            // 
            test2Label.AutoSize = true;
            test2Label.Location = new Point(175, 87);
            test2Label.Name = "test2Label";
            test2Label.Size = new Size(43, 15);
            test2Label.TabIndex = 0;
            test2Label.Text = "Test 2 :";
            // 
            // test3Label
            // 
            test3Label.AutoSize = true;
            test3Label.Location = new Point(175, 117);
            test3Label.Name = "test3Label";
            test3Label.Size = new Size(43, 15);
            test3Label.TabIndex = 0;
            test3Label.Text = "Test 3 :";
            // 
            // averageLabel
            // 
            averageLabel.AutoSize = true;
            averageLabel.Location = new Point(106, 172);
            averageLabel.Name = "averageLabel";
            averageLabel.Size = new Size(112, 15);
            averageLabel.TabIndex = 0;
            averageLabel.Text = "Average Test Score :";
            // 
            // test1Textbox
            // 
            test1Textbox.Location = new Point(254, 56);
            test1Textbox.Name = "test1Textbox";
            test1Textbox.Size = new Size(100, 23);
            test1Textbox.TabIndex = 0;
            // 
            // test2Textbox
            // 
            test2Textbox.Location = new Point(254, 87);
            test2Textbox.Name = "test2Textbox";
            test2Textbox.Size = new Size(100, 23);
            test2Textbox.TabIndex = 1;
            // 
            // test3Textbox
            // 
            test3Textbox.Location = new Point(254, 117);
            test3Textbox.Name = "test3Textbox";
            test3Textbox.Size = new Size(100, 23);
            test3Textbox.TabIndex = 2;
            // 
            // resultLabel
            // 
            resultLabel.BorderStyle = BorderStyle.FixedSingle;
            resultLabel.Location = new Point(254, 172);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(100, 23);
            resultLabel.TabIndex = 2;
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(144, 238);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(75, 39);
            calculateButton.TabIndex = 3;
            calculateButton.Text = "Calculate Average";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(225, 238);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 39);
            clearButton.TabIndex = 4;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(306, 238);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 39);
            exitButton.TabIndex = 5;
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
            ClientSize = new Size(520, 335);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(calculateButton);
            Controls.Add(resultLabel);
            Controls.Add(test3Textbox);
            Controls.Add(test2Textbox);
            Controls.Add(test1Textbox);
            Controls.Add(averageLabel);
            Controls.Add(test3Label);
            Controls.Add(test2Label);
            Controls.Add(test1Label);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Test Average";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label test1Label;
        private Label test2Label;
        private Label test3Label;
        private Label averageLabel;
        private TextBox test1Textbox;
        private TextBox test2Textbox;
        private TextBox test3Textbox;
        private Label resultLabel;
        private Button calculateButton;
        private Button clearButton;
        private Button exitButton;
    }
}
