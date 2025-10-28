namespace sConboyLab8
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
            components = new System.ComponentModel.Container();
            userTextbox = new TextBox();
            label1 = new Label();
            resultLabel = new Label();
            convertButton = new Button();
            clearButton = new Button();
            exitButton = new Button();
            label2 = new Label();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // userTextbox
            // 
            userTextbox.Location = new Point(298, 117);
            userTextbox.Name = "userTextbox";
            userTextbox.Size = new Size(211, 26);
            userTextbox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 120);
            label1.Name = "label1";
            label1.Size = new Size(153, 19);
            label1.TabIndex = 1;
            label1.Text = "Enter phrase to convert";
            // 
            // resultLabel
            // 
            resultLabel.Location = new Point(156, 183);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(311, 22);
            resultLabel.TabIndex = 2;
            resultLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // convertButton
            // 
            convertButton.Location = new Point(176, 257);
            convertButton.Name = "convertButton";
            convertButton.Size = new Size(86, 26);
            convertButton.TabIndex = 1;
            convertButton.Text = "&Convert";
            toolTip1.SetToolTip(convertButton, "Press to convert");
            convertButton.UseVisualStyleBackColor = true;
            convertButton.Click += convertButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(268, 257);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(86, 26);
            clearButton.TabIndex = 2;
            clearButton.Text = "C&lear";
            toolTip1.SetToolTip(clearButton, "Press to clear");
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(360, 257);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(86, 26);
            exitButton.TabIndex = 3;
            exitButton.Text = "&Exit";
            toolTip1.SetToolTip(exitButton, "Press to exit");
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.7818184F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(210, 31);
            label2.Name = "label2";
            label2.Size = new Size(203, 25);
            label2.TabIndex = 6;
            label2.Text = "Morse Code Converter";
            // 
            // Form1
            // 
            AcceptButton = convertButton;
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = exitButton;
            ClientSize = new Size(622, 323);
            Controls.Add(label2);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(convertButton);
            Controls.Add(resultLabel);
            Controls.Add(label1);
            Controls.Add(userTextbox);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "sConboyLab8MorseCode";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userTextbox;
        private Label label1;
        private Label resultLabel;
        private Button convertButton;
        private Button clearButton;
        private Button exitButton;
        private Label label2;
        private ToolTip toolTip1;
    }
}
