namespace bookClubPoints
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
            headerLabel = new Label();
            label1 = new Label();
            purchasedTextbox = new TextBox();
            pointsHeaderLabel = new Label();
            pointsLabel = new Label();
            calculateButton = new Button();
            clearButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headerLabel.Location = new Point(309, 57);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(182, 30);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Book Club Points";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(198, 128);
            label1.Name = "label1";
            label1.Size = new Size(247, 15);
            label1.TabIndex = 1;
            label1.Text = "Enter number of books purchased this month";
            // 
            // purchasedTextbox
            // 
            purchasedTextbox.Location = new Point(503, 125);
            purchasedTextbox.Name = "purchasedTextbox";
            purchasedTextbox.Size = new Size(100, 23);
            purchasedTextbox.TabIndex = 0;
            // 
            // pointsHeaderLabel
            // 
            pointsHeaderLabel.AutoSize = true;
            pointsHeaderLabel.Location = new Point(198, 228);
            pointsHeaderLabel.Name = "pointsHeaderLabel";
            pointsHeaderLabel.Size = new Size(90, 15);
            pointsHeaderLabel.TabIndex = 3;
            pointsHeaderLabel.Text = "Points Awarded";
            // 
            // pointsLabel
            // 
            pointsLabel.Location = new Point(384, 228);
            pointsLabel.Name = "pointsLabel";
            pointsLabel.Size = new Size(219, 23);
            pointsLabel.TabIndex = 4;
            pointsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(198, 308);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(75, 23);
            calculateButton.TabIndex = 1;
            calculateButton.Text = "See Points";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(363, 308);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 2;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(528, 308);
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
            Controls.Add(pointsLabel);
            Controls.Add(pointsHeaderLabel);
            Controls.Add(purchasedTextbox);
            Controls.Add(label1);
            Controls.Add(headerLabel);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book Club Points";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Label label1;
        private TextBox purchasedTextbox;
        private Label pointsHeaderLabel;
        private Label pointsLabel;
        private Button calculateButton;
        private Button clearButton;
        private Button exitButton;
    }
}
