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
            label1.Location = new Point(280, 77);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 0;
            label1.Text = "Day";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(280, 128);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 0;
            label2.Text = "Month";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(280, 177);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 0;
            label3.Text = "Year";
            // 
            // dayTextbox
            // 
            dayTextbox.Location = new Point(396, 74);
            dayTextbox.Name = "dayTextbox";
            dayTextbox.Size = new Size(125, 27);
            dayTextbox.TabIndex = 0;
            // 
            // monthTextbox
            // 
            monthTextbox.Location = new Point(396, 121);
            monthTextbox.Name = "monthTextbox";
            monthTextbox.Size = new Size(125, 27);
            monthTextbox.TabIndex = 1;
            // 
            // yearTextbox
            // 
            yearTextbox.Location = new Point(396, 170);
            yearTextbox.Name = "yearTextbox";
            yearTextbox.Size = new Size(125, 27);
            yearTextbox.TabIndex = 2;
            // 
            // resultLabel
            // 
            resultLabel.BorderStyle = BorderStyle.Fixed3D;
            resultLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultLabel.Location = new Point(280, 258);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(241, 65);
            resultLabel.TabIndex = 2;
            resultLabel.Text = "Is it magic?";
            // 
            // checkButton
            // 
            checkButton.Location = new Point(253, 355);
            checkButton.Name = "checkButton";
            checkButton.Size = new Size(94, 58);
            checkButton.TabIndex = 3;
            checkButton.Text = "Check";
            toolTip1.SetToolTip(checkButton, "Check if date is magic");
            checkButton.UseVisualStyleBackColor = true;
            checkButton.Click += checkButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(353, 355);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(94, 58);
            clearButton.TabIndex = 4;
            clearButton.Text = "Clear";
            toolTip1.SetToolTip(clearButton, "Clear the form");
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(453, 355);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(94, 58);
            exitButton.TabIndex = 5;
            exitButton.Text = "Exit";
            toolTip1.SetToolTip(exitButton, "Exit the application");
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Magic Dates Conboy";
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
