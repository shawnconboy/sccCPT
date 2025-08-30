namespace SConboyLab6Gui
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
            yearsWorkedLabel = new Label();
            grossPayLabel = new Label();
            yearsWorkedTextbox = new TextBox();
            grossPayTextbox = new TextBox();
            bonusLabel = new Label();
            bonusResultLabel = new Label();
            titleLabel = new Label();
            calculateBonusButton = new Button();
            clearButton = new Button();
            exitButton = new Button();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // yearsWorkedLabel
            // 
            yearsWorkedLabel.AutoSize = true;
            yearsWorkedLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            yearsWorkedLabel.ForeColor = Color.Red;
            yearsWorkedLabel.Location = new Point(117, 99);
            yearsWorkedLabel.Name = "yearsWorkedLabel";
            yearsWorkedLabel.Size = new Size(158, 21);
            yearsWorkedLabel.TabIndex = 0;
            yearsWorkedLabel.Text = "Enter Years Worked";
            yearsWorkedLabel.Click += label1_Click;
            // 
            // grossPayLabel
            // 
            grossPayLabel.AutoSize = true;
            grossPayLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            grossPayLabel.ForeColor = Color.LimeGreen;
            grossPayLabel.Location = new Point(117, 131);
            grossPayLabel.Name = "grossPayLabel";
            grossPayLabel.Size = new Size(127, 21);
            grossPayLabel.TabIndex = 0;
            grossPayLabel.Text = "Enter Gross Pay";
            grossPayLabel.Click += label1_Click;
            // 
            // yearsWorkedTextbox
            // 
            yearsWorkedTextbox.Location = new Point(298, 99);
            yearsWorkedTextbox.Name = "yearsWorkedTextbox";
            yearsWorkedTextbox.Size = new Size(100, 23);
            yearsWorkedTextbox.TabIndex = 1;
            // 
            // grossPayTextbox
            // 
            grossPayTextbox.Location = new Point(298, 131);
            grossPayTextbox.Name = "grossPayTextbox";
            grossPayTextbox.Size = new Size(100, 23);
            grossPayTextbox.TabIndex = 2;
            // 
            // bonusLabel
            // 
            bonusLabel.AutoSize = true;
            bonusLabel.Location = new Point(124, 229);
            bonusLabel.Name = "bonusLabel";
            bonusLabel.Size = new Size(40, 15);
            bonusLabel.TabIndex = 2;
            bonusLabel.Text = "Bonus";
            // 
            // bonusResultLabel
            // 
            bonusResultLabel.AutoSize = true;
            bonusResultLabel.Location = new Point(298, 229);
            bonusResultLabel.Name = "bonusResultLabel";
            bonusResultLabel.Size = new Size(0, 15);
            bonusResultLabel.TabIndex = 3;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.LightSkyBlue;
            titleLabel.Location = new Point(117, 43);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(281, 30);
            titleLabel.TabIndex = 4;
            titleLabel.Text = "Christmas Bonus Calculator";
            // 
            // calculateBonusButton
            // 
            calculateBonusButton.Location = new Point(167, 183);
            calculateBonusButton.Name = "calculateBonusButton";
            calculateBonusButton.Size = new Size(189, 23);
            calculateBonusButton.TabIndex = 3;
            calculateBonusButton.Text = "&Calculate Bonus";
            toolTip1.SetToolTip(calculateBonusButton, "Caculate Bonus");
            calculateBonusButton.UseVisualStyleBackColor = true;
            calculateBonusButton.Click += calculateBonusButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(117, 291);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(88, 23);
            clearButton.TabIndex = 4;
            clearButton.Text = "&Clear";
            toolTip1.SetToolTip(clearButton, "Clear fields");
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(310, 291);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(88, 23);
            exitButton.TabIndex = 5;
            exitButton.Text = "Exit";
            toolTip1.SetToolTip(exitButton, "Exit Program");
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AcceptButton = calculateBonusButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = exitButton;
            ClientSize = new Size(515, 393);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(titleLabel);
            Controls.Add(bonusResultLabel);
            Controls.Add(bonusLabel);
            Controls.Add(grossPayTextbox);
            Controls.Add(yearsWorkedTextbox);
            Controls.Add(grossPayLabel);
            Controls.Add(yearsWorkedLabel);
            Controls.Add(calculateBonusButton);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Christmas Bonus Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label yearsWorkedLabel;
        private Label grossPayLabel;
        private TextBox yearsWorkedTextbox;
        private TextBox grossPayTextbox;
        private Label bonusLabel;
        private Label bonusResultLabel;
        private Label titleLabel;
        private Button calculateBonusButton;
        private Button clearButton;
        private Button exitButton;
        private ToolTip toolTip1;
    }
}
