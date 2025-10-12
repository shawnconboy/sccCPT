namespace totalSales
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
            salesListbox = new ListBox();
            label2 = new Label();
            salesTotalLabel = new Label();
            averageLabel = new Label();
            largestLabel = new Label();
            label5 = new Label();
            label6 = new Label();
            label3 = new Label();
            smallestLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(76, 39);
            label1.Name = "label1";
            label1.Size = new Size(116, 30);
            label1.TabIndex = 0;
            label1.Text = "Total Sales";
            // 
            // salesListbox
            // 
            salesListbox.FormattingEnabled = true;
            salesListbox.ItemHeight = 15;
            salesListbox.Location = new Point(74, 99);
            salesListbox.Name = "salesListbox";
            salesListbox.Size = new Size(120, 109);
            salesListbox.TabIndex = 1;
            salesListbox.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 243);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 2;
            label2.Text = "Total : ";
            // 
            // salesTotalLabel
            // 
            salesTotalLabel.Location = new Point(116, 239);
            salesTotalLabel.Name = "salesTotalLabel";
            salesTotalLabel.Size = new Size(100, 23);
            salesTotalLabel.TabIndex = 3;
            salesTotalLabel.Text = "$0.00";
            salesTotalLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // averageLabel
            // 
            averageLabel.Location = new Point(116, 262);
            averageLabel.Name = "averageLabel";
            averageLabel.Size = new Size(100, 23);
            averageLabel.TabIndex = 3;
            averageLabel.Text = "$0.00";
            averageLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // largestLabel
            // 
            largestLabel.Location = new Point(116, 285);
            largestLabel.Name = "largestLabel";
            largestLabel.Size = new Size(100, 23);
            largestLabel.TabIndex = 3;
            largestLabel.Text = "$0.00";
            largestLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 266);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 2;
            label5.Text = "Average :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(54, 289);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 2;
            label6.Text = "Largest";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 312);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Smallest";
            // 
            // smallestLabel
            // 
            smallestLabel.Location = new Point(116, 308);
            smallestLabel.Name = "smallestLabel";
            smallestLabel.Size = new Size(100, 23);
            smallestLabel.TabIndex = 3;
            smallestLabel.Text = "$0.00";
            smallestLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(270, 347);
            Controls.Add(smallestLabel);
            Controls.Add(largestLabel);
            Controls.Add(averageLabel);
            Controls.Add(label3);
            Controls.Add(salesTotalLabel);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(salesListbox);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Total Sales";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox salesListbox;
        private Label label2;
        private Label salesTotalLabel;
        private Label averageLabel;
        private Label largestLabel;
        private Label label5;
        private Label label6;
        private Label label3;
        private Label smallestLabel;
    }
}
