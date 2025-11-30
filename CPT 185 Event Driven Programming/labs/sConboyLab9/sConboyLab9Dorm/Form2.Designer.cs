namespace sConboyLab9Dorm
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            closeButton = new Button();
            dormChargesLabel = new Label();
            mealChargesLabel = new Label();
            totalChargesLabel = new Label();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(319, 86);
            label1.Name = "label1";
            label1.Size = new Size(141, 25);
            label1.TabIndex = 0;
            label1.Text = "Dorm Charges : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(319, 146);
            label2.Name = "label2";
            label2.Size = new Size(133, 25);
            label2.TabIndex = 0;
            label2.Text = "Meal Charges : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(319, 207);
            label3.Name = "label3";
            label3.Size = new Size(127, 25);
            label3.TabIndex = 0;
            label3.Text = "Total Charges :";
            // 
            // closeButton
            // 
            closeButton.Location = new Point(443, 363);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(122, 34);
            closeButton.TabIndex = 1;
            closeButton.Text = "&Close";
            toolTip1.SetToolTip(closeButton, "Press to close");
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // dormChargesLabel
            // 
            dormChargesLabel.BorderStyle = BorderStyle.FixedSingle;
            dormChargesLabel.Location = new Point(540, 85);
            dormChargesLabel.Name = "dormChargesLabel";
            dormChargesLabel.Size = new Size(214, 38);
            dormChargesLabel.TabIndex = 2;
            // 
            // mealChargesLabel
            // 
            mealChargesLabel.BorderStyle = BorderStyle.FixedSingle;
            mealChargesLabel.Location = new Point(540, 145);
            mealChargesLabel.Name = "mealChargesLabel";
            mealChargesLabel.Size = new Size(214, 38);
            mealChargesLabel.TabIndex = 2;
            // 
            // totalChargesLabel
            // 
            totalChargesLabel.BorderStyle = BorderStyle.FixedSingle;
            totalChargesLabel.Location = new Point(540, 206);
            totalChargesLabel.Name = "totalChargesLabel";
            totalChargesLabel.Size = new Size(214, 38);
            totalChargesLabel.TabIndex = 2;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = closeButton;
            ClientSize = new Size(1072, 471);
            Controls.Add(totalChargesLabel);
            Controls.Add(mealChargesLabel);
            Controls.Add(dormChargesLabel);
            Controls.Add(closeButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dormitory Total Charges";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button closeButton;
        private Label dormChargesLabel;
        private Label mealChargesLabel;
        private Label totalChargesLabel;
        private ToolTip toolTip1;
    }
}