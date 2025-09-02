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
            label1 = new Label();
            originalPriceTextbox = new TextBox();
            label2 = new Label();
            discoutPercentTextbox = new TextBox();
            label3 = new Label();
            salePriceLabel = new Label();
            calculateButton = new Button();
            exitButton = new Button();
            clearButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 69);
            label1.Name = "label1";
            label1.Size = new Size(161, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter the item's original price";
            // 
            // originalPriceTextbox
            // 
            originalPriceTextbox.Location = new Point(303, 69);
            originalPriceTextbox.Name = "originalPriceTextbox";
            originalPriceTextbox.Size = new Size(100, 23);
            originalPriceTextbox.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 98);
            label2.Name = "label2";
            label2.Size = new Size(165, 15);
            label2.TabIndex = 0;
            label2.Text = "Enter the discount percentage";
            // 
            // discoutPercentTextbox
            // 
            discoutPercentTextbox.Location = new Point(303, 98);
            discoutPercentTextbox.Name = "discoutPercentTextbox";
            discoutPercentTextbox.Size = new Size(100, 23);
            discoutPercentTextbox.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(182, 147);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 0;
            label3.Text = "Sale price";
            // 
            // salePriceLabel
            // 
            salePriceLabel.BorderStyle = BorderStyle.FixedSingle;
            salePriceLabel.Location = new Point(303, 136);
            salePriceLabel.Name = "salePriceLabel";
            salePriceLabel.Size = new Size(100, 26);
            salePriceLabel.TabIndex = 0;
            salePriceLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(66, 197);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(139, 23);
            calculateButton.TabIndex = 2;
            calculateButton.Text = "Calculate Sale Price";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(349, 197);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 4;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(238, 197);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 3;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 322);
            Controls.Add(clearButton);
            Controls.Add(exitButton);
            Controls.Add(calculateButton);
            Controls.Add(discoutPercentTextbox);
            Controls.Add(salePriceLabel);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(originalPriceTextbox);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sale Price Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox originalPriceTextbox;
        private Label label2;
        private TextBox discoutPercentTextbox;
        private Label label3;
        private Label salePriceLabel;
        private Button calculateButton;
        private Button exitButton;
        private Button clearButton;
    }
}
