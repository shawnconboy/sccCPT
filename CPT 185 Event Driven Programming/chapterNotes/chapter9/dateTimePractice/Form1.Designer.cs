namespace dateTimePractice
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
            dateTimePicker = new DateTimePicker();
            label2 = new Label();
            resultLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(320, 71);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 0;
            label1.Text = "Pick A Date";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(225, 118);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(300, 31);
            dateTimePicker.TabIndex = 1;
            dateTimePicker.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(167, 261);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 2;
            label2.Text = "You Picked :";
            // 
            // resultLabel
            // 
            resultLabel.Location = new Point(290, 248);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(310, 38);
            resultLabel.TabIndex = 3;
            resultLabel.TextAlign = ContentAlignment.BottomCenter;
            resultLabel.Click += resultLabel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultLabel);
            Controls.Add(label2);
            Controls.Add(dateTimePicker);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dateTimePicker;
        private Label label2;
        private Label resultLabel;
    }
}
