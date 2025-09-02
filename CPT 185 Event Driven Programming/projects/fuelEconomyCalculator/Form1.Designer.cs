namespace fuelEconomyCalculator
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
            milesDrivenTextbox = new TextBox();
            label2 = new Label();
            gallonsUsedTextbox = new TextBox();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            carMpgResultLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 89);
            label1.Name = "label1";
            label1.Size = new Size(180, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter the number of miles driven";
            // 
            // milesDrivenTextbox
            // 
            milesDrivenTextbox.Location = new Point(250, 81);
            milesDrivenTextbox.Name = "milesDrivenTextbox";
            milesDrivenTextbox.Size = new Size(100, 23);
            milesDrivenTextbox.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 127);
            label2.Name = "label2";
            label2.Size = new Size(158, 15);
            label2.TabIndex = 0;
            label2.Text = "Enter the gallons of gas used";
            // 
            // gallonsUsedTextbox
            // 
            gallonsUsedTextbox.Location = new Point(250, 119);
            gallonsUsedTextbox.Name = "gallonsUsedTextbox";
            gallonsUsedTextbox.Size = new Size(100, 23);
            gallonsUsedTextbox.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(146, 175);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 0;
            label3.Text = "Your car's MPG";
            // 
            // button1
            // 
            button1.Location = new Point(158, 242);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(250, 242);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // carMpgResultLabel
            // 
            carMpgResultLabel.BorderStyle = BorderStyle.FixedSingle;
            carMpgResultLabel.Location = new Point(250, 167);
            carMpgResultLabel.Name = "carMpgResultLabel";
            carMpgResultLabel.Size = new Size(94, 23);
            carMpgResultLabel.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 357);
            Controls.Add(carMpgResultLabel);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(gallonsUsedTextbox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(milesDrivenTextbox);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox milesDrivenTextbox;
        private Label label2;
        private TextBox gallonsUsedTextbox;
        private Label label3;
        private Button button1;
        private Button button2;
        private Label carMpgResultLabel;
    }
}
