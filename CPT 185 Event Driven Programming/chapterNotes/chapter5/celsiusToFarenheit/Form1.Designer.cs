namespace celsiusToFarenheit
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
            convertedListbox = new ListBox();
            exitButton = new Button();
            switchButton = new Button();
            showButton = new Button();
            subHeaderLabel = new Label();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headerLabel.Location = new Point(161, 58);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(394, 38);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Celsius to Farenheit Coverter";
            // 
            // convertedListbox
            // 
            convertedListbox.FormattingEnabled = true;
            convertedListbox.Location = new Point(391, 132);
            convertedListbox.Name = "convertedListbox";
            convertedListbox.Size = new Size(298, 264);
            convertedListbox.TabIndex = 1;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(143, 319);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(94, 29);
            exitButton.TabIndex = 2;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // switchButton
            // 
            switchButton.Location = new Point(143, 270);
            switchButton.Name = "switchButton";
            switchButton.Size = new Size(94, 29);
            switchButton.TabIndex = 2;
            switchButton.Text = "Switch";
            switchButton.UseVisualStyleBackColor = true;
            switchButton.Click += switchButton_Click;
            // 
            // showButton
            // 
            showButton.Location = new Point(143, 225);
            showButton.Name = "showButton";
            showButton.Size = new Size(147, 29);
            showButton.TabIndex = 2;
            showButton.Text = "Show Conversions";
            showButton.UseVisualStyleBackColor = true;
            showButton.Click += showButton_Click;
            // 
            // subHeaderLabel
            // 
            subHeaderLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            subHeaderLabel.Location = new Point(143, 132);
            subHeaderLabel.Name = "subHeaderLabel";
            subHeaderLabel.Size = new Size(213, 56);
            subHeaderLabel.TabIndex = 3;
            subHeaderLabel.Text = "Press show conversions to load list.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 450);
            Controls.Add(subHeaderLabel);
            Controls.Add(showButton);
            Controls.Add(switchButton);
            Controls.Add(exitButton);
            Controls.Add(convertedListbox);
            Controls.Add(headerLabel);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Celsius To Farenheit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private ListBox convertedListbox;
        private Button exitButton;
        private Button switchButton;
        private Button showButton;
        private Label subHeaderLabel;
    }
}
