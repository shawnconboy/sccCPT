namespace birthDateString
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
            dayOfWeekTextbox = new TextBox();
            label2 = new Label();
            nameOfMonthTextbox = new TextBox();
            label3 = new Label();
            numberDayOfMonthTextbox = new TextBox();
            label4 = new Label();
            yearTextbox = new TextBox();
            showDateButton = new Button();
            clearButton = new Button();
            exitButton = new Button();
            resultLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(256, 98);
            label1.Name = "label1";
            label1.Size = new Size(140, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter the day of the week";
            // 
            // dayOfWeekTextbox
            // 
            dayOfWeekTextbox.Location = new Point(422, 95);
            dayOfWeekTextbox.Name = "dayOfWeekTextbox";
            dayOfWeekTextbox.Size = new Size(100, 23);
            dayOfWeekTextbox.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(236, 130);
            label2.Name = "label2";
            label2.Size = new Size(160, 15);
            label2.TabIndex = 0;
            label2.Text = "Enter the name of the month";
            // 
            // nameOfMonthTextbox
            // 
            nameOfMonthTextbox.Location = new Point(422, 127);
            nameOfMonthTextbox.Name = "nameOfMonthTextbox";
            nameOfMonthTextbox.Size = new Size(100, 23);
            nameOfMonthTextbox.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(200, 162);
            label3.Name = "label3";
            label3.Size = new Size(196, 15);
            label3.TabIndex = 0;
            label3.Text = "Enter the numeric day of the month";
            // 
            // numberDayOfMonthTextbox
            // 
            numberDayOfMonthTextbox.Location = new Point(422, 159);
            numberDayOfMonthTextbox.Name = "numberDayOfMonthTextbox";
            numberDayOfMonthTextbox.Size = new Size(100, 23);
            numberDayOfMonthTextbox.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(317, 194);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 0;
            label4.Text = "Enter the year";
            // 
            // yearTextbox
            // 
            yearTextbox.Location = new Point(422, 191);
            yearTextbox.Name = "yearTextbox";
            yearTextbox.Size = new Size(100, 23);
            yearTextbox.TabIndex = 3;
            // 
            // showDateButton
            // 
            showDateButton.Location = new Point(240, 294);
            showDateButton.Name = "showDateButton";
            showDateButton.Size = new Size(75, 23);
            showDateButton.TabIndex = 4;
            showDateButton.Text = "Show &Date";
            showDateButton.UseVisualStyleBackColor = true;
            showDateButton.Click += showDateButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(359, 294);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 5;
            clearButton.Text = "&Clear";
            clearButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(485, 294);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 6;
            exitButton.Text = "&Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += button3_Click;
            // 
            // resultLabel
            // 
            resultLabel.Location = new Point(220, 237);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(360, 23);
            resultLabel.TabIndex = 7;
            resultLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = exitButton;
            ClientSize = new Size(800, 450);
            Controls.Add(resultLabel);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(showDateButton);
            Controls.Add(yearTextbox);
            Controls.Add(numberDayOfMonthTextbox);
            Controls.Add(nameOfMonthTextbox);
            Controls.Add(label4);
            Controls.Add(dayOfWeekTextbox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Birth Date String";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox dayOfWeekTextbox;
        private Label label2;
        private TextBox nameOfMonthTextbox;
        private Label label3;
        private TextBox numberDayOfMonthTextbox;
        private Label label4;
        private TextBox yearTextbox;
        private Button showDateButton;
        private Button clearButton;
        private Button exitButton;
        private Label resultLabel;
    }
}
