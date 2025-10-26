namespace frequentCharacter
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
            userTextbox = new TextBox();
            checkButton = new Button();
            clearButton = new Button();
            exitButton = new Button();
            label2 = new Label();
            resultLabel = new Label();
            label3 = new Label();
            quantityLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(284, 46);
            label1.Name = "label1";
            label1.Size = new Size(233, 25);
            label1.TabIndex = 0;
            label1.Text = "Most Frequent Character";
            // 
            // userTextbox
            // 
            userTextbox.Location = new Point(271, 141);
            userTextbox.Name = "userTextbox";
            userTextbox.Size = new Size(259, 23);
            userTextbox.TabIndex = 1;
            userTextbox.TextAlign = HorizontalAlignment.Center;
            // 
            // checkButton
            // 
            checkButton.Location = new Point(271, 291);
            checkButton.Name = "checkButton";
            checkButton.Size = new Size(75, 23);
            checkButton.TabIndex = 2;
            checkButton.Text = "Check";
            checkButton.UseVisualStyleBackColor = true;
            checkButton.Click += checkButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(363, 291);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 3;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(455, 291);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 4;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(247, 215);
            label2.Name = "label2";
            label2.Size = new Size(190, 15);
            label2.TabIndex = 5;
            label2.Text = "Character that appeared the most :";
            // 
            // resultLabel
            // 
            resultLabel.BorderStyle = BorderStyle.FixedSingle;
            resultLabel.Location = new Point(453, 214);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(100, 23);
            resultLabel.TabIndex = 6;
            resultLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(247, 250);
            label3.Name = "label3";
            label3.Size = new Size(176, 15);
            label3.TabIndex = 5;
            label3.Text = "Times that character appeared : ";
            // 
            // quantityLabel
            // 
            quantityLabel.BorderStyle = BorderStyle.FixedSingle;
            quantityLabel.Location = new Point(453, 246);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(100, 23);
            quantityLabel.TabIndex = 6;
            quantityLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AcceptButton = checkButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = exitButton;
            ClientSize = new Size(800, 450);
            Controls.Add(quantityLabel);
            Controls.Add(resultLabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(checkButton);
            Controls.Add(userTextbox);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frequency Checker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox userTextbox;
        private Button checkButton;
        private Button clearButton;
        private Button exitButton;
        private Label label2;
        private Label resultLabel;
        private Label label3;
        private Label quantityLabel;
    }
}
