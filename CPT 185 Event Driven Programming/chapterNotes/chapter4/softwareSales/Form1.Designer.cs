namespace softwareSales
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
            subHeadingLabel = new Label();
            amountPurchasedTextbox = new TextBox();
            headerLabel = new Label();
            discountLabel = new Label();
            totalLabel = new Label();
            calculateButton = new Button();
            clearButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // subHeadingLabel
            // 
            subHeadingLabel.AutoSize = true;
            subHeadingLabel.Location = new Point(216, 114);
            subHeadingLabel.Name = "subHeadingLabel";
            subHeadingLabel.Size = new Size(203, 15);
            subHeadingLabel.TabIndex = 0;
            subHeadingLabel.Text = "Enter amount of packages purchased";
            // 
            // amountPurchasedTextbox
            // 
            amountPurchasedTextbox.Location = new Point(484, 111);
            amountPurchasedTextbox.Name = "amountPurchasedTextbox";
            amountPurchasedTextbox.Size = new Size(100, 23);
            amountPurchasedTextbox.TabIndex = 0;
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headerLabel.Location = new Point(330, 22);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(141, 25);
            headerLabel.TabIndex = 2;
            headerLabel.Text = "Software Sales";
            // 
            // discountLabel
            // 
            discountLabel.AutoSize = true;
            discountLabel.Location = new Point(293, 183);
            discountLabel.Name = "discountLabel";
            discountLabel.Size = new Size(60, 15);
            discountLabel.TabIndex = 3;
            discountLabel.Text = "Discount :";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new Point(293, 236);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(42, 15);
            totalLabel.TabIndex = 3;
            totalLabel.Text = "Total : ";
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(256, 325);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(75, 23);
            calculateButton.TabIndex = 1;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(344, 325);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 2;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(446, 325);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 3;
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
            ClientSize = new Size(800, 450);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(calculateButton);
            Controls.Add(totalLabel);
            Controls.Add(discountLabel);
            Controls.Add(headerLabel);
            Controls.Add(amountPurchasedTextbox);
            Controls.Add(subHeadingLabel);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Software Sales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label subHeadingLabel;
        private TextBox amountPurchasedTextbox;
        private Label headerLabel;
        private Label discountLabel;
        private Label totalLabel;
        private Button calculateButton;
        private Button clearButton;
        private Button exitButton;
    }
}
