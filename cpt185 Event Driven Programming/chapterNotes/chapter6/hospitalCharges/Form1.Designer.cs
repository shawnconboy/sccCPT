namespace hospitalCharges
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
            daysSpentTextbox = new TextBox();
            label2 = new Label();
            medicationTextbox = new TextBox();
            label3 = new Label();
            surgicalTextbox = new TextBox();
            label4 = new Label();
            labFeesTextbox = new TextBox();
            label5 = new Label();
            rehabTextbox = new TextBox();
            label6 = new Label();
            calculateButton = new Button();
            clearButton = new Button();
            exitButton = new Button();
            stayFeeLabel = new Label();
            miscFeeLabel = new Label();
            grandTotalLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(114, 78);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 0;
            label1.Text = "Days spent in hospital";
            // 
            // daysSpentTextbox
            // 
            daysSpentTextbox.Location = new Point(261, 75);
            daysSpentTextbox.Name = "daysSpentTextbox";
            daysSpentTextbox.Size = new Size(100, 23);
            daysSpentTextbox.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(125, 107);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 0;
            label2.Text = "Medication charges";
            // 
            // medicationTextbox
            // 
            medicationTextbox.Location = new Point(261, 104);
            medicationTextbox.Name = "medicationTextbox";
            medicationTextbox.Size = new Size(100, 23);
            medicationTextbox.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(143, 136);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 0;
            label3.Text = "Surgical charges";
            // 
            // surgicalTextbox
            // 
            surgicalTextbox.Location = new Point(261, 133);
            surgicalTextbox.Name = "surgicalTextbox";
            surgicalTextbox.Size = new Size(100, 23);
            surgicalTextbox.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(184, 165);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 0;
            label4.Text = "Lab Fees";
            // 
            // labFeesTextbox
            // 
            labFeesTextbox.Location = new Point(261, 162);
            labFeesTextbox.Name = "labFeesTextbox";
            labFeesTextbox.Size = new Size(100, 23);
            labFeesTextbox.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(150, 194);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 0;
            label5.Text = "Physical Rehab";
            // 
            // rehabTextbox
            // 
            rehabTextbox.Location = new Point(261, 191);
            rehabTextbox.Name = "rehabTextbox";
            rehabTextbox.Size = new Size(100, 23);
            rehabTextbox.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(140, 19);
            label6.Name = "label6";
            label6.Size = new Size(195, 30);
            label6.TabIndex = 2;
            label6.Text = "Hospital Summary";
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(114, 244);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(75, 23);
            calculateButton.TabIndex = 5;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(200, 244);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 6;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(286, 244);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 7;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // stayFeeLabel
            // 
            stayFeeLabel.BorderStyle = BorderStyle.FixedSingle;
            stayFeeLabel.Location = new Point(157, 290);
            stayFeeLabel.Name = "stayFeeLabel";
            stayFeeLabel.Size = new Size(161, 24);
            stayFeeLabel.TabIndex = 4;
            stayFeeLabel.Text = "Stay Fee : $0.00";
            stayFeeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // miscFeeLabel
            // 
            miscFeeLabel.BorderStyle = BorderStyle.FixedSingle;
            miscFeeLabel.Location = new Point(157, 325);
            miscFeeLabel.Name = "miscFeeLabel";
            miscFeeLabel.Size = new Size(161, 24);
            miscFeeLabel.TabIndex = 4;
            miscFeeLabel.Text = "Misc Fee : $0.00";
            miscFeeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // grandTotalLabel
            // 
            grandTotalLabel.BorderStyle = BorderStyle.FixedSingle;
            grandTotalLabel.Location = new Point(157, 359);
            grandTotalLabel.Name = "grandTotalLabel";
            grandTotalLabel.Size = new Size(161, 24);
            grandTotalLabel.TabIndex = 4;
            grandTotalLabel.Text = "Grand Total : $0.00";
            grandTotalLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AcceptButton = calculateButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = exitButton;
            ClientSize = new Size(475, 450);
            Controls.Add(grandTotalLabel);
            Controls.Add(miscFeeLabel);
            Controls.Add(stayFeeLabel);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(calculateButton);
            Controls.Add(label6);
            Controls.Add(rehabTextbox);
            Controls.Add(labFeesTextbox);
            Controls.Add(label5);
            Controls.Add(surgicalTextbox);
            Controls.Add(label4);
            Controls.Add(medicationTextbox);
            Controls.Add(label3);
            Controls.Add(daysSpentTextbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hospital Charges";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox daysSpentTextbox;
        private Label label2;
        private TextBox medicationTextbox;
        private Label label3;
        private TextBox surgicalTextbox;
        private Label label4;
        private TextBox labFeesTextbox;
        private Label label5;
        private TextBox rehabTextbox;
        private Label label6;
        private Button calculateButton;
        private Button clearButton;
        private Button exitButton;
        private Label stayFeeLabel;
        private Label miscFeeLabel;
        private Label grandTotalLabel;
    }
}
