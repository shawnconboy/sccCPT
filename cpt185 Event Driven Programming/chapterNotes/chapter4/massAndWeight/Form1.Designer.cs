namespace massAndWeight
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
            convertButton = new Button();
            clearButton = new Button();
            exitButton = new Button();
            enterMassLabel = new Label();
            userMassTextbox = new TextBox();
            resultLabel = new Label();
            SuspendLayout();
            // 
            // convertButton
            // 
            convertButton.Location = new Point(253, 268);
            convertButton.Name = "convertButton";
            convertButton.Size = new Size(94, 29);
            convertButton.TabIndex = 1;
            convertButton.Text = "Convert";
            convertButton.UseVisualStyleBackColor = true;
            convertButton.Click += convertButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(353, 268);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(94, 29);
            clearButton.TabIndex = 2;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(453, 268);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(94, 29);
            exitButton.TabIndex = 3;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // enterMassLabel
            // 
            enterMassLabel.AutoSize = true;
            enterMassLabel.Location = new Point(220, 71);
            enterMassLabel.Name = "enterMassLabel";
            enterMassLabel.Size = new Size(167, 20);
            enterMassLabel.TabIndex = 1;
            enterMassLabel.Text = "Enter object's mass (Kg)";
            // 
            // userMassTextbox
            // 
            userMassTextbox.Location = new Point(453, 68);
            userMassTextbox.Name = "userMassTextbox";
            userMassTextbox.Size = new Size(125, 27);
            userMassTextbox.TabIndex = 0;
            // 
            // resultLabel
            // 
            resultLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultLabel.Location = new Point(253, 169);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(294, 40);
            resultLabel.TabIndex = 3;
            resultLabel.Text = "Object weight (n) :  ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultLabel);
            Controls.Add(userMassTextbox);
            Controls.Add(enterMassLabel);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(convertButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button convertButton;
        private Button clearButton;
        private Button exitButton;
        private Label enterMassLabel;
        private TextBox userMassTextbox;
        private Label resultLabel;
    }
}
