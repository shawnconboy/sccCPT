namespace tuitionIncrease
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
            subHeaderLabel = new Label();
            resultsListbox = new ListBox();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Location = new Point(247, 45);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(91, 15);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Tuition Increase";
            // 
            // subHeaderLabel
            // 
            subHeaderLabel.AutoSize = true;
            subHeaderLabel.Location = new Point(90, 107);
            subHeaderLabel.Name = "subHeaderLabel";
            subHeaderLabel.Size = new Size(244, 30);
            subHeaderLabel.TabIndex = 1;
            subHeaderLabel.Text = "Current tuition cost is $6000 per semester.\r\n2.5% Increase each year over the next 5 years.";
            // 
            // resultsListbox
            // 
            resultsListbox.FormattingEnabled = true;
            resultsListbox.ItemHeight = 15;
            resultsListbox.Location = new Point(374, 107);
            resultsListbox.Name = "resultsListbox";
            resultsListbox.Size = new Size(238, 94);
            resultsListbox.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 263);
            Controls.Add(resultsListbox);
            Controls.Add(subHeaderLabel);
            Controls.Add(headerLabel);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tuition Increase";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Label subHeaderLabel;
        private ListBox resultsListbox;
    }
}
