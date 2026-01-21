namespace distanceCalculator
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
            distanceListbox = new ListBox();
            speedLabel = new Label();
            hoursLabel = new Label();
            speedTextbox = new TextBox();
            hoursTextbox = new TextBox();
            calculateButton = new Button();
            exitButton = new Button();
            clearButton = new Button();
            SuspendLayout();
            // 
            // distanceListbox
            // 
            distanceListbox.FormattingEnabled = true;
            distanceListbox.ItemHeight = 15;
            distanceListbox.Location = new Point(67, 150);
            distanceListbox.Name = "distanceListbox";
            distanceListbox.Size = new Size(288, 109);
            distanceListbox.TabIndex = 0;
            distanceListbox.TabStop = false;
            // 
            // speedLabel
            // 
            speedLabel.AutoSize = true;
            speedLabel.Location = new Point(67, 37);
            speedLabel.Name = "speedLabel";
            speedLabel.Size = new Size(122, 15);
            speedLabel.TabIndex = 0;
            speedLabel.Text = "Vehicle Speed in MPH";
            // 
            // hoursLabel
            // 
            hoursLabel.AutoSize = true;
            hoursLabel.Location = new Point(67, 80);
            hoursLabel.Name = "hoursLabel";
            hoursLabel.Size = new Size(86, 15);
            hoursLabel.TabIndex = 0;
            hoursLabel.Text = "Hours Traveled";
            // 
            // speedTextbox
            // 
            speedTextbox.Location = new Point(255, 34);
            speedTextbox.Name = "speedTextbox";
            speedTextbox.Size = new Size(100, 23);
            speedTextbox.TabIndex = 0;
            // 
            // hoursTextbox
            // 
            hoursTextbox.Location = new Point(255, 80);
            hoursTextbox.Name = "hoursTextbox";
            hoursTextbox.Size = new Size(100, 23);
            hoursTextbox.TabIndex = 1;
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(67, 287);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(75, 23);
            calculateButton.TabIndex = 2;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(280, 287);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 4;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(177, 287);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 3;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // Form1
            // 
            AcceptButton = calculateButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = exitButton;
            ClientSize = new Size(423, 342);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(calculateButton);
            Controls.Add(hoursTextbox);
            Controls.Add(speedTextbox);
            Controls.Add(hoursLabel);
            Controls.Add(speedLabel);
            Controls.Add(distanceListbox);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox distanceListbox;
        private Label speedLabel;
        private Label hoursLabel;
        private TextBox speedTextbox;
        private TextBox hoursTextbox;
        private Button calculateButton;
        private Button exitButton;
        private Button clearButton;
    }
}
