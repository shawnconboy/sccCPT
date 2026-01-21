namespace colorMixer
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
            firstGroupBox = new GroupBox();
            yellowOne = new RadioButton();
            blueOne = new RadioButton();
            redOne = new RadioButton();
            secondGroupBox = new GroupBox();
            yellowTwo = new RadioButton();
            blueTwo = new RadioButton();
            redTwo = new RadioButton();
            mixButton = new Button();
            exitButton = new Button();
            firstGroupBox.SuspendLayout();
            secondGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // firstGroupBox
            // 
            firstGroupBox.Controls.Add(yellowOne);
            firstGroupBox.Controls.Add(blueOne);
            firstGroupBox.Controls.Add(redOne);
            firstGroupBox.Location = new Point(127, 103);
            firstGroupBox.Name = "firstGroupBox";
            firstGroupBox.Size = new Size(171, 173);
            firstGroupBox.TabIndex = 0;
            firstGroupBox.TabStop = false;
            firstGroupBox.Text = "Select the first color";
            // 
            // yellowOne
            // 
            yellowOne.AutoSize = true;
            yellowOne.Location = new Point(19, 97);
            yellowOne.Name = "yellowOne";
            yellowOne.Size = new Size(73, 24);
            yellowOne.TabIndex = 2;
            yellowOne.TabStop = true;
            yellowOne.Text = "Yellow";
            yellowOne.UseVisualStyleBackColor = true;
            // 
            // blueOne
            // 
            blueOne.AutoSize = true;
            blueOne.Location = new Point(19, 67);
            blueOne.Name = "blueOne";
            blueOne.Size = new Size(59, 24);
            blueOne.TabIndex = 1;
            blueOne.TabStop = true;
            blueOne.Text = "Blue";
            blueOne.UseVisualStyleBackColor = true;
            // 
            // redOne
            // 
            redOne.AutoSize = true;
            redOne.Location = new Point(19, 37);
            redOne.Name = "redOne";
            redOne.Size = new Size(56, 24);
            redOne.TabIndex = 0;
            redOne.TabStop = true;
            redOne.Text = "Red";
            redOne.UseVisualStyleBackColor = true;
            // 
            // secondGroupBox
            // 
            secondGroupBox.Controls.Add(yellowTwo);
            secondGroupBox.Controls.Add(blueTwo);
            secondGroupBox.Controls.Add(redTwo);
            secondGroupBox.Location = new Point(476, 103);
            secondGroupBox.Name = "secondGroupBox";
            secondGroupBox.Size = new Size(197, 173);
            secondGroupBox.TabIndex = 1;
            secondGroupBox.TabStop = false;
            secondGroupBox.Text = "Select the second color";
            // 
            // yellowTwo
            // 
            yellowTwo.AutoSize = true;
            yellowTwo.Location = new Point(19, 97);
            yellowTwo.Name = "yellowTwo";
            yellowTwo.Size = new Size(73, 24);
            yellowTwo.TabIndex = 2;
            yellowTwo.TabStop = true;
            yellowTwo.Text = "Yellow";
            yellowTwo.UseVisualStyleBackColor = true;
            // 
            // blueTwo
            // 
            blueTwo.AutoSize = true;
            blueTwo.Location = new Point(19, 67);
            blueTwo.Name = "blueTwo";
            blueTwo.Size = new Size(59, 24);
            blueTwo.TabIndex = 1;
            blueTwo.TabStop = true;
            blueTwo.Text = "Blue";
            blueTwo.UseVisualStyleBackColor = true;
            // 
            // redTwo
            // 
            redTwo.AutoSize = true;
            redTwo.Location = new Point(19, 37);
            redTwo.Name = "redTwo";
            redTwo.Size = new Size(56, 24);
            redTwo.TabIndex = 0;
            redTwo.TabStop = true;
            redTwo.Text = "Red";
            redTwo.UseVisualStyleBackColor = true;
            // 
            // mixButton
            // 
            mixButton.Location = new Point(281, 337);
            mixButton.Name = "mixButton";
            mixButton.Size = new Size(94, 29);
            mixButton.TabIndex = 2;
            mixButton.Text = "Mix";
            mixButton.UseVisualStyleBackColor = true;
            mixButton.Click += mixButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(425, 337);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(94, 29);
            exitButton.TabIndex = 3;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AcceptButton = mixButton;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = exitButton;
            ClientSize = new Size(800, 450);
            Controls.Add(exitButton);
            Controls.Add(mixButton);
            Controls.Add(secondGroupBox);
            Controls.Add(firstGroupBox);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Color Mixer";
            firstGroupBox.ResumeLayout(false);
            firstGroupBox.PerformLayout();
            secondGroupBox.ResumeLayout(false);
            secondGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox firstGroupBox;
        private RadioButton yellowOne;
        private RadioButton blueOne;
        private RadioButton redOne;
        private GroupBox secondGroupBox;
        private RadioButton yellowTwo;
        private RadioButton blueTwo;
        private RadioButton redTwo;
        private Button mixButton;
        private Button exitButton;
    }
}
