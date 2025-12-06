namespace magicDates
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dayTextbox = new TextBox();
            monthTextbox = new TextBox();
            yearTextbox = new TextBox();
            resultLabel = new Label();
            checkButton = new Button();
            clearButton = new Button();
            exitButton = new Button();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(245, 58);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 0;
            label1.Text = "Day";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(245, 96);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 0;
            label2.Text = "Month";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(245, 133);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 0;
            label3.Text = "Year";
            // 
            // dayTextbox
            // 
            dayTextbox.Location = new Point(346, 56);
            dayTextbox.Margin = new Padding(3, 2, 3, 2);
            dayTextbox.Name = "dayTextbox";
            dayTextbox.Size = new Size(110, 23);
            dayTextbox.TabIndex = 0;
            // 
            // monthTextbox
            // 
            monthTextbox.Location = new Point(346, 91);
            monthTextbox.Margin = new Padding(3, 2, 3, 2);
            monthTextbox.Name = "monthTextbox";
            monthTextbox.Size = new Size(110, 23);
            monthTextbox.TabIndex = 1;
            // 
            // yearTextbox
            // 
            yearTextbox.Location = new Point(346, 128);
            yearTextbox.Margin = new Padding(3, 2, 3, 2);
            yearTextbox.Name = "yearTextbox";
            yearTextbox.Size = new Size(110, 23);
            yearTextbox.TabIndex = 2;
            // 
            // resultLabel
            // 
            resultLabel.BorderStyle = BorderStyle.Fixed3D;
            resultLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultLabel.Location = new Point(245, 194);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(211, 49);
            resultLabel.TabIndex = 2;
            resultLabel.Text = "Is it magic?";
            // 
            // checkButton
            // 
            checkButton.Location = new Point(221, 266);
            checkButton.Margin = new Padding(3, 2, 3, 2);
            checkButton.Name = "checkButton";
            checkButton.Size = new Size(82, 44);
            checkButton.TabIndex = 3;
            checkButton.Text = "Check";
            toolTip1.SetToolTip(checkButton, "Check if date is magic");
            checkButton.UseVisualStyleBackColor = true;
            checkButton.Click += checkButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(309, 266);
            clearButton.Margin = new Padding(3, 2, 3, 2);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(82, 44);
            clearButton.TabIndex = 4;
            clearButton.Text = "Clear";
            toolTip1.SetToolTip(clearButton, "Clear the form");
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(396, 266);
            exitButton.Margin = new Padding(3, 2, 3, 2);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(82, 44);
            exitButton.TabIndex = 5;
            exitButton.Text = "Exit";
            toolTip1.SetToolTip(exitButton, "Exit the application");
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AcceptButton = checkButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = exitButton;
            ClientSize = new Size(700, 338);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(checkButton);
            Controls.Add(resultLabel);
            Controls.Add(yearTextbox);
            Controls.Add(monthTextbox);
            Controls.Add(dayTextbox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "sConboy Magic Dates";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox dayTextbox;
        private TextBox monthTextbox;
        private TextBox yearTextbox;
        private Label resultLabel;
        private Button checkButton;
        private Button clearButton;
        private Button exitButton;
        private ToolTip toolTip1;
    }
}
