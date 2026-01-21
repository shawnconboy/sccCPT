namespace salePriceCalculator
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
            originalPriceLabel = new Label();
            originalPriceTextbox = new TextBox();
            discountLabel = new Label();
            discountTextbox = new TextBox();
            salePriceLabel = new Label();
            salePriceTextbox = new TextBox();
            calculateButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // originalPriceLabel
            // 
            originalPriceLabel.AutoSize = true;
            originalPriceLabel.Location = new Point(252, 118);
            originalPriceLabel.Name = "originalPriceLabel";
            originalPriceLabel.Size = new Size(158, 15);
            originalPriceLabel.TabIndex = 0;
            originalPriceLabel.Text = "Enter the item's orginal price";
            // 
            // originalPriceTextbox
            // 
            originalPriceTextbox.Location = new Point(449, 115);
            originalPriceTextbox.Name = "originalPriceTextbox";
            originalPriceTextbox.Size = new Size(100, 23);
            originalPriceTextbox.TabIndex = 0;
            // 
            // discountLabel
            // 
            discountLabel.AutoSize = true;
            discountLabel.Location = new Point(252, 159);
            discountLabel.Name = "discountLabel";
            discountLabel.Size = new Size(165, 15);
            discountLabel.TabIndex = 0;
            discountLabel.Text = "Enter the discount percentage";
            // 
            // discountTextbox
            // 
            discountTextbox.Location = new Point(449, 156);
            discountTextbox.Name = "discountTextbox";
            discountTextbox.Size = new Size(100, 23);
            discountTextbox.TabIndex = 1;
            // 
            // salePriceLabel
            // 
            salePriceLabel.AutoSize = true;
            salePriceLabel.Location = new Point(353, 208);
            salePriceLabel.Name = "salePriceLabel";
            salePriceLabel.Size = new Size(57, 15);
            salePriceLabel.TabIndex = 3;
            salePriceLabel.Text = "Sale price";
            // 
            // salePriceTextbox
            // 
            salePriceTextbox.Enabled = false;
            salePriceTextbox.Location = new Point(449, 200);
            salePriceTextbox.Name = "salePriceTextbox";
            salePriceTextbox.Size = new Size(100, 23);
            salePriceTextbox.TabIndex = 0;
            salePriceTextbox.TabStop = false;
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(291, 304);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(75, 42);
            calculateButton.TabIndex = 2;
            calculateButton.Text = "Calculate Sale Price";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(434, 304);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 42);
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
            Controls.Add(calculateButton);
            Controls.Add(salePriceTextbox);
            Controls.Add(discountTextbox);
            Controls.Add(salePriceLabel);
            Controls.Add(discountLabel);
            Controls.Add(originalPriceTextbox);
            Controls.Add(originalPriceLabel);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sale Price Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label originalPriceLabel;
        private TextBox originalPriceTextbox;
        private Label discountLabel;
        private TextBox discountTextbox;
        private Label salePriceLabel;
        private TextBox salePriceTextbox;
        private Button calculateButton;
        private Button exitButton;
    }
}
