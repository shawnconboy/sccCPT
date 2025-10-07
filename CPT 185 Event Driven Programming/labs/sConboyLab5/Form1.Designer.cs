namespace sConboyLab5
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
            headerLabel = new Label();
            startingLabel = new Label();
            averageLabel = new Label();
            numDaysLabel = new Label();
            startingNumTextbox = new TextBox();
            averageTextbox = new TextBox();
            numDaysTextbox = new TextBox();
            resultsListbox = new ListBox();
            showResultsButton = new Button();
            clearButton = new Button();
            exitButton = new Button();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            headerLabel.Location = new Point(236, 33);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(91, 19);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Population";
            // 
            // startingLabel
            // 
            startingLabel.AutoSize = true;
            startingLabel.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            startingLabel.Location = new Point(77, 103);
            startingLabel.Name = "startingLabel";
            startingLabel.Size = new Size(241, 19);
            startingLabel.TabIndex = 1;
            startingLabel.Text = "Starting Number Of Organisms";
            // 
            // averageLabel
            // 
            averageLabel.AutoSize = true;
            averageLabel.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            averageLabel.Location = new Point(77, 166);
            averageLabel.Name = "averageLabel";
            averageLabel.Size = new Size(206, 19);
            averageLabel.TabIndex = 1;
            averageLabel.Text = "Average Daily Increase(%)";
            // 
            // numDaysLabel
            // 
            numDaysLabel.AutoSize = true;
            numDaysLabel.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            numDaysLabel.Location = new Point(77, 233);
            numDaysLabel.Name = "numDaysLabel";
            numDaysLabel.Size = new Size(221, 19);
            numDaysLabel.TabIndex = 1;
            numDaysLabel.Text = "Number Of Days To Multiply";
            // 
            // startingNumTextbox
            // 
            startingNumTextbox.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            startingNumTextbox.Location = new Point(327, 100);
            startingNumTextbox.Name = "startingNumTextbox";
            startingNumTextbox.Size = new Size(125, 27);
            startingNumTextbox.TabIndex = 0;
            toolTip1.SetToolTip(startingNumTextbox, "Enter starting number of organisms");
            // 
            // averageTextbox
            // 
            averageTextbox.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            averageTextbox.Location = new Point(327, 163);
            averageTextbox.Name = "averageTextbox";
            averageTextbox.Size = new Size(125, 27);
            averageTextbox.TabIndex = 1;
            toolTip1.SetToolTip(averageTextbox, "Enter average daily Increase");
            // 
            // numDaysTextbox
            // 
            numDaysTextbox.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            numDaysTextbox.Location = new Point(327, 230);
            numDaysTextbox.Name = "numDaysTextbox";
            numDaysTextbox.Size = new Size(125, 27);
            numDaysTextbox.TabIndex = 2;
            toolTip1.SetToolTip(numDaysTextbox, "Enter number of days to multiply");
            // 
            // resultsListbox
            // 
            resultsListbox.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            resultsListbox.FormattingEnabled = true;
            resultsListbox.ItemHeight = 19;
            resultsListbox.Location = new Point(511, 100);
            resultsListbox.Name = "resultsListbox";
            resultsListbox.Size = new Size(233, 270);
            resultsListbox.TabIndex = 3;
            resultsListbox.TabStop = false;
            // 
            // showResultsButton
            // 
            showResultsButton.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            showResultsButton.Location = new Point(77, 352);
            showResultsButton.Name = "showResultsButton";
            showResultsButton.Size = new Size(111, 29);
            showResultsButton.TabIndex = 3;
            showResultsButton.Text = "&Show Results";
            toolTip1.SetToolTip(showResultsButton, "Press to show results");
            showResultsButton.UseVisualStyleBackColor = true;
            showResultsButton.Click += showResultsButton_Click;
            // 
            // clearButton
            // 
            clearButton.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            clearButton.Location = new Point(209, 352);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(111, 29);
            clearButton.TabIndex = 4;
            clearButton.Text = "&Clear";
            toolTip1.SetToolTip(clearButton, "Press to clear form");
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            exitButton.Location = new Point(341, 352);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(111, 29);
            exitButton.TabIndex = 5;
            exitButton.Text = "&Exit";
            toolTip1.SetToolTip(exitButton, "Press to exit form");
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AcceptButton = showResultsButton;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = exitButton;
            ClientSize = new Size(800, 450);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(showResultsButton);
            Controls.Add(resultsListbox);
            Controls.Add(numDaysTextbox);
            Controls.Add(averageTextbox);
            Controls.Add(startingNumTextbox);
            Controls.Add(numDaysLabel);
            Controls.Add(averageLabel);
            Controls.Add(startingLabel);
            Controls.Add(headerLabel);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Shawn Conboy Chapter 5 Population";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Label startingLabel;
        private Label averageLabel;
        private Label numDaysLabel;
        private TextBox startingNumTextbox;
        private TextBox averageTextbox;
        private TextBox numDaysTextbox;
        private ListBox resultsListbox;
        private Button showResultsButton;
        private Button clearButton;
        private Button exitButton;
        private ToolTip toolTip1;
    }
}
