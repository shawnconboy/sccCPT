namespace sConboy_185_Test_2
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
            processButton = new Button();
            exitButton = new Button();
            clearButton = new Button();
            totalSalariesLabel = new Label();
            recordsLabel = new Label();
            averageLabel = new Label();
            largestSalaryLabel = new Label();
            smallestSalaryLabel = new Label();
            bonusLabel = new Label();
            label7 = new Label();
            yearComboBox = new ComboBox();
            salariesListbox = new ListBox();
            toolTip1 = new ToolTip(components);
            label1 = new Label();
            label2 = new Label();
            openFile = new OpenFileDialog();
            SuspendLayout();
            // 
            // processButton
            // 
            processButton.Location = new Point(62, 423);
            processButton.Name = "processButton";
            processButton.Size = new Size(125, 29);
            processButton.TabIndex = 1;
            processButton.Text = "&Process the file ->";
            toolTip1.SetToolTip(processButton, "Press to process file");
            processButton.UseVisualStyleBackColor = true;
            processButton.Click += processButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(366, 423);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(125, 29);
            exitButton.TabIndex = 3;
            exitButton.Text = "&Exit";
            toolTip1.SetToolTip(exitButton, "Press to exit form");
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(214, 423);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(125, 29);
            clearButton.TabIndex = 2;
            clearButton.Text = "&Clear";
            toolTip1.SetToolTip(clearButton, "Press to clear screen");
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // totalSalariesLabel
            // 
            totalSalariesLabel.AutoSize = true;
            totalSalariesLabel.Location = new Point(271, 179);
            totalSalariesLabel.Name = "totalSalariesLabel";
            totalSalariesLabel.Size = new Size(167, 20);
            totalSalariesLabel.TabIndex = 3;
            totalSalariesLabel.Text = "The total salaries : $0.00";
            // 
            // recordsLabel
            // 
            recordsLabel.AutoSize = true;
            recordsLabel.Location = new Point(271, 215);
            recordsLabel.Name = "recordsLabel";
            recordsLabel.Size = new Size(178, 20);
            recordsLabel.TabIndex = 3;
            recordsLabel.Text = "The number of records : 0";
            // 
            // averageLabel
            // 
            averageLabel.AutoSize = true;
            averageLabel.Location = new Point(271, 251);
            averageLabel.Name = "averageLabel";
            averageLabel.Size = new Size(136, 20);
            averageLabel.TabIndex = 3;
            averageLabel.Text = "The average : $0.00";
            // 
            // largestSalaryLabel
            // 
            largestSalaryLabel.AutoSize = true;
            largestSalaryLabel.Location = new Point(271, 284);
            largestSalaryLabel.Name = "largestSalaryLabel";
            largestSalaryLabel.Size = new Size(170, 20);
            largestSalaryLabel.TabIndex = 3;
            largestSalaryLabel.Text = "The largest salary : $0.00";
            // 
            // smallestSalaryLabel
            // 
            smallestSalaryLabel.AutoSize = true;
            smallestSalaryLabel.Location = new Point(271, 317);
            smallestSalaryLabel.Name = "smallestSalaryLabel";
            smallestSalaryLabel.Size = new Size(179, 20);
            smallestSalaryLabel.TabIndex = 3;
            smallestSalaryLabel.Text = "The smallest salary : $0.00";
            // 
            // bonusLabel
            // 
            bonusLabel.AutoSize = true;
            bonusLabel.Location = new Point(271, 352);
            bonusLabel.Name = "bonusLabel";
            bonusLabel.Size = new Size(192, 20);
            bonusLabel.TabIndex = 3;
            bonusLabel.Text = "The bonus amount is : $0.00";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(199, 111);
            label7.Name = "label7";
            label7.Size = new Size(44, 20);
            label7.TabIndex = 6;
            label7.Text = "Year :";
            // 
            // yearComboBox
            // 
            yearComboBox.FormattingEnabled = true;
            yearComboBox.Location = new Point(249, 111);
            yearComboBox.Name = "yearComboBox";
            yearComboBox.Size = new Size(104, 28);
            yearComboBox.TabIndex = 0;
            // 
            // salariesListbox
            // 
            salariesListbox.FormattingEnabled = true;
            salariesListbox.Location = new Point(62, 178);
            salariesListbox.Name = "salariesListbox";
            salariesListbox.Size = new Size(169, 204);
            salariesListbox.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(157, 46);
            label1.Name = "label1";
            label1.Size = new Size(238, 28);
            label1.TabIndex = 9;
            label1.Text = "Choose year to see data";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 148);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 10;
            label2.Text = "Salaries from file";
            // 
            // openFile
            // 
            openFile.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AcceptButton = processButton;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = exitButton;
            ClientSize = new Size(552, 531);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(salariesListbox);
            Controls.Add(yearComboBox);
            Controls.Add(label7);
            Controls.Add(bonusLabel);
            Controls.Add(smallestSalaryLabel);
            Controls.Add(largestSalaryLabel);
            Controls.Add(averageLabel);
            Controls.Add(recordsLabel);
            Controls.Add(totalSalariesLabel);
            Controls.Add(clearButton);
            Controls.Add(exitButton);
            Controls.Add(processButton);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "sConboy Test 2 185 A01H Salaries Report";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button processButton;
        private Button exitButton;
        private Button clearButton;
        private Label totalSalariesLabel;
        private Label recordsLabel;
        private Label averageLabel;
        private Label largestSalaryLabel;
        private Label smallestSalaryLabel;
        private Label bonusLabel;
        private Label label7;
        private ComboBox yearComboBox;
        private ListBox salariesListbox;
        private ToolTip toolTip1;
        private Label label1;
        private Label label2;
        private OpenFileDialog openFile;
    }
}
