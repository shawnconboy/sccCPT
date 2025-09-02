namespace wageCalculator
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
            hoursWorkedLabel = new Label();
            hoursWorkedTextbox = new TextBox();
            payRateLabel = new Label();
            payRateTextbox = new TextBox();
            calculatePayButton = new Button();
            totalPayLabel = new Label();
            totalPayResultLabel = new Label();
            exitButton = new Button();
            label1 = new Label();
            afterTaxesResultLabel = new Label();
            SuspendLayout();
            // 
            // hoursWorkedLabel
            // 
            hoursWorkedLabel.AutoSize = true;
            hoursWorkedLabel.Location = new Point(154, 70);
            hoursWorkedLabel.Name = "hoursWorkedLabel";
            hoursWorkedLabel.Size = new Size(140, 15);
            hoursWorkedLabel.TabIndex = 0;
            hoursWorkedLabel.Text = "Number of hours worked";
            // 
            // hoursWorkedTextbox
            // 
            hoursWorkedTextbox.Location = new Point(322, 62);
            hoursWorkedTextbox.Name = "hoursWorkedTextbox";
            hoursWorkedTextbox.Size = new Size(100, 23);
            hoursWorkedTextbox.TabIndex = 0;
            // 
            // payRateLabel
            // 
            payRateLabel.AutoSize = true;
            payRateLabel.Location = new Point(154, 99);
            payRateLabel.Name = "payRateLabel";
            payRateLabel.Size = new Size(88, 15);
            payRateLabel.TabIndex = 0;
            payRateLabel.Text = "Hourly pay rate";
            // 
            // payRateTextbox
            // 
            payRateTextbox.Location = new Point(322, 96);
            payRateTextbox.Name = "payRateTextbox";
            payRateTextbox.Size = new Size(100, 23);
            payRateTextbox.TabIndex = 1;
            // 
            // calculatePayButton
            // 
            calculatePayButton.Location = new Point(175, 159);
            calculatePayButton.Name = "calculatePayButton";
            calculatePayButton.Size = new Size(108, 40);
            calculatePayButton.TabIndex = 2;
            calculatePayButton.Text = "Calculate Gross Pay";
            calculatePayButton.UseVisualStyleBackColor = true;
            calculatePayButton.Click += calculatePayButton_Click;
            // 
            // totalPayLabel
            // 
            totalPayLabel.AutoSize = true;
            totalPayLabel.Location = new Point(175, 233);
            totalPayLabel.Name = "totalPayLabel";
            totalPayLabel.Size = new Size(65, 15);
            totalPayLabel.TabIndex = 3;
            totalPayLabel.Text = "Total Gross";
            // 
            // totalPayResultLabel
            // 
            totalPayResultLabel.AutoSize = true;
            totalPayResultLabel.Location = new Point(322, 234);
            totalPayResultLabel.Name = "totalPayResultLabel";
            totalPayResultLabel.Size = new Size(0, 15);
            totalPayResultLabel.TabIndex = 4;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(322, 159);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(100, 40);
            exitButton.TabIndex = 3;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(175, 267);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 3;
            label1.Text = "After Taxes";
            // 
            // afterTaxesResultLabel
            // 
            afterTaxesResultLabel.AutoSize = true;
            afterTaxesResultLabel.Location = new Point(322, 268);
            afterTaxesResultLabel.Name = "afterTaxesResultLabel";
            afterTaxesResultLabel.Size = new Size(0, 15);
            afterTaxesResultLabel.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 321);
            Controls.Add(exitButton);
            Controls.Add(afterTaxesResultLabel);
            Controls.Add(totalPayResultLabel);
            Controls.Add(label1);
            Controls.Add(totalPayLabel);
            Controls.Add(calculatePayButton);
            Controls.Add(payRateTextbox);
            Controls.Add(payRateLabel);
            Controls.Add(hoursWorkedTextbox);
            Controls.Add(hoursWorkedLabel);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Wage Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label hoursWorkedLabel;
        private TextBox hoursWorkedTextbox;
        private Label payRateLabel;
        private TextBox payRateTextbox;
        private Button calculatePayButton;
        private Label totalPayLabel;
        private Label totalPayResultLabel;
        private Button exitButton;
        private Label label1;
        private Label afterTaxesResultLabel;
    }
}
