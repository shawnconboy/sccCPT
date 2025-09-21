namespace timeZone
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
            cityListbox = new ListBox();
            label2 = new Label();
            resultLabel = new Label();
            showButton = new Button();
            exitButton = new Button();
            clearButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(278, 47);
            label1.Name = "label1";
            label1.Size = new Size(245, 15);
            label1.TabIndex = 0;
            label1.Text = "Select a city and I will give you the time zone.";
            // 
            // cityListbox
            // 
            cityListbox.FormattingEnabled = true;
            cityListbox.ItemHeight = 15;
            cityListbox.Items.AddRange(new object[] { "Denver", "Honolulu", "Minneapolis", "New York", "San Francisco" });
            cityListbox.Location = new Point(348, 123);
            cityListbox.Name = "cityListbox";
            cityListbox.Size = new Size(105, 79);
            cityListbox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(282, 253);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 2;
            label2.Text = "Time Zone";
            // 
            // resultLabel
            // 
            resultLabel.BorderStyle = BorderStyle.FixedSingle;
            resultLabel.Location = new Point(404, 252);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(119, 23);
            resultLabel.TabIndex = 3;
            resultLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // showButton
            // 
            showButton.Location = new Point(282, 342);
            showButton.Name = "showButton";
            showButton.Size = new Size(75, 23);
            showButton.TabIndex = 4;
            showButton.Text = "Show Me";
            showButton.UseVisualStyleBackColor = true;
            showButton.Click += showButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(444, 342);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 4;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(363, 342);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 4;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // Form1
            // 
            AcceptButton = showButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = exitButton;
            ClientSize = new Size(800, 450);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(showButton);
            Controls.Add(resultLabel);
            Controls.Add(label2);
            Controls.Add(cityListbox);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Time Zone";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox cityListbox;
        private Label label2;
        private Label resultLabel;
        private Button showButton;
        private Button exitButton;
        private Button clearButton;
    }
}
