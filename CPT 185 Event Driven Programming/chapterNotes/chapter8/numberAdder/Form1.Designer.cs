namespace numberAdder
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
            userTextbox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            resultLabel = new Label();
            addButton = new Button();
            clearButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // userTextbox
            // 
            userTextbox.Location = new Point(244, 131);
            userTextbox.Name = "userTextbox";
            userTextbox.Size = new Size(410, 39);
            userTextbox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(244, 58);
            label1.Name = "label1";
            label1.Size = new Size(410, 32);
            label1.TabIndex = 1;
            label1.Text = "Enter numbers separated by commas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(244, 225);
            label2.Name = "label2";
            label2.Size = new Size(179, 32);
            label2.TabIndex = 2;
            label2.Text = "Number Total : ";
            // 
            // resultLabel
            // 
            resultLabel.BorderStyle = BorderStyle.FixedSingle;
            resultLabel.Location = new Point(498, 216);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(156, 51);
            resultLabel.TabIndex = 3;
            resultLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addButton
            // 
            addButton.Location = new Point(218, 352);
            addButton.Name = "addButton";
            addButton.Size = new Size(150, 46);
            addButton.TabIndex = 4;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(374, 352);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(150, 46);
            clearButton.TabIndex = 5;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(530, 352);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(150, 46);
            exitButton.TabIndex = 6;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 535);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(addButton);
            Controls.Add(resultLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(userTextbox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userTextbox;
        private Label label1;
        private Label label2;
        private Label resultLabel;
        private Button addButton;
        private Button clearButton;
        private Button exitButton;
    }
}
