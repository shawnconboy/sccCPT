namespace passwordValidation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            passwordTextbox = new TextBox();
            checkButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 49);
            label1.Name = "label1";
            label1.Size = new Size(337, 120);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(161, 225);
            label2.Name = "label2";
            label2.Size = new Size(174, 28);
            label2.TabIndex = 1;
            label2.Text = "Enter a password";
            // 
            // passwordTextbox
            // 
            passwordTextbox.Location = new Point(150, 277);
            passwordTextbox.Name = "passwordTextbox";
            passwordTextbox.Size = new Size(196, 27);
            passwordTextbox.TabIndex = 2;
            // 
            // checkButton
            // 
            checkButton.Location = new Point(80, 350);
            checkButton.Name = "checkButton";
            checkButton.Size = new Size(94, 52);
            checkButton.TabIndex = 3;
            checkButton.Text = "Check Password";
            checkButton.UseVisualStyleBackColor = true;
            checkButton.Click += checkButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(323, 350);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(94, 52);
            exitButton.TabIndex = 4;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AcceptButton = checkButton;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = exitButton;
            ClientSize = new Size(496, 450);
            Controls.Add(exitButton);
            Controls.Add(checkButton);
            Controls.Add(passwordTextbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Password Validation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox passwordTextbox;
        private Button checkButton;
        private Button exitButton;
    }
}
