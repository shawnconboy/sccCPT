namespace sConboyLab3
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
            ticketGroupBox = new GroupBox();
            classCTicketsTextbox = new TextBox();
            classCTicketsLabel = new Label();
            classBTicketsTextbox = new TextBox();
            classBTicketsLabel = new Label();
            classATicketsTextbox = new TextBox();
            classATicketsLabel = new Label();
            label1 = new Label();
            revenueGroupBox = new GroupBox();
            totalRevenueTotalLabel = new Label();
            classCRevenueTotalLabel = new Label();
            classBRevenueTotalLabel = new Label();
            classARevenueTotalLabel = new Label();
            totalRevenueLabel = new Label();
            classCRevenueLabel = new Label();
            classARevenueLabel = new Label();
            classBRevenueLabel = new Label();
            calculateRevenueButton = new Button();
            clearButton = new Button();
            exitButton = new Button();
            toolTip1 = new ToolTip(components);
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            ticketGroupBox.SuspendLayout();
            revenueGroupBox.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ticketGroupBox
            // 
            ticketGroupBox.Controls.Add(classCTicketsTextbox);
            ticketGroupBox.Controls.Add(classCTicketsLabel);
            ticketGroupBox.Controls.Add(classBTicketsTextbox);
            ticketGroupBox.Controls.Add(classBTicketsLabel);
            ticketGroupBox.Controls.Add(classATicketsTextbox);
            ticketGroupBox.Controls.Add(classATicketsLabel);
            ticketGroupBox.Controls.Add(label1);
            ticketGroupBox.Font = new Font("Times New Roman", 12F);
            ticketGroupBox.Location = new Point(58, 115);
            ticketGroupBox.Name = "ticketGroupBox";
            ticketGroupBox.Size = new Size(250, 211);
            ticketGroupBox.TabIndex = 0;
            ticketGroupBox.TabStop = false;
            ticketGroupBox.Text = "Tickets Sold";
            // 
            // classCTicketsTextbox
            // 
            classCTicketsTextbox.Location = new Point(99, 158);
            classCTicketsTextbox.Name = "classCTicketsTextbox";
            classCTicketsTextbox.PlaceholderText = "0";
            classCTicketsTextbox.Size = new Size(86, 26);
            classCTicketsTextbox.TabIndex = 2;
            // 
            // classCTicketsLabel
            // 
            classCTicketsLabel.AutoSize = true;
            classCTicketsLabel.Location = new Point(25, 161);
            classCTicketsLabel.Name = "classCTicketsLabel";
            classCTicketsLabel.Size = new Size(60, 19);
            classCTicketsLabel.TabIndex = 1;
            classCTicketsLabel.Text = "Class C:";
            // 
            // classBTicketsTextbox
            // 
            classBTicketsTextbox.Location = new Point(99, 119);
            classBTicketsTextbox.Name = "classBTicketsTextbox";
            classBTicketsTextbox.PlaceholderText = "0";
            classBTicketsTextbox.Size = new Size(86, 26);
            classBTicketsTextbox.TabIndex = 1;
            // 
            // classBTicketsLabel
            // 
            classBTicketsLabel.AutoSize = true;
            classBTicketsLabel.Location = new Point(25, 122);
            classBTicketsLabel.Name = "classBTicketsLabel";
            classBTicketsLabel.Size = new Size(59, 19);
            classBTicketsLabel.TabIndex = 1;
            classBTicketsLabel.Text = "Class B:";
            // 
            // classATicketsTextbox
            // 
            classATicketsTextbox.Location = new Point(99, 79);
            classATicketsTextbox.Name = "classATicketsTextbox";
            classATicketsTextbox.PlaceholderText = "0";
            classATicketsTextbox.Size = new Size(86, 26);
            classATicketsTextbox.TabIndex = 0;
            // 
            // classATicketsLabel
            // 
            classATicketsLabel.AutoSize = true;
            classATicketsLabel.Location = new Point(25, 82);
            classATicketsLabel.Name = "classATicketsLabel";
            classATicketsLabel.Size = new Size(59, 19);
            classATicketsLabel.TabIndex = 1;
            classATicketsLabel.Text = "Class A:";
            // 
            // label1
            // 
            label1.Location = new Point(24, 27);
            label1.Name = "label1";
            label1.Size = new Size(202, 49);
            label1.TabIndex = 0;
            label1.Text = "Enter the number of tickets sold for each class of seats";
            // 
            // revenueGroupBox
            // 
            revenueGroupBox.Controls.Add(totalRevenueTotalLabel);
            revenueGroupBox.Controls.Add(classCRevenueTotalLabel);
            revenueGroupBox.Controls.Add(classBRevenueTotalLabel);
            revenueGroupBox.Controls.Add(classARevenueTotalLabel);
            revenueGroupBox.Controls.Add(totalRevenueLabel);
            revenueGroupBox.Controls.Add(classCRevenueLabel);
            revenueGroupBox.Controls.Add(classARevenueLabel);
            revenueGroupBox.Controls.Add(classBRevenueLabel);
            revenueGroupBox.Font = new Font("Times New Roman", 12F);
            revenueGroupBox.Location = new Point(412, 115);
            revenueGroupBox.Name = "revenueGroupBox";
            revenueGroupBox.Size = new Size(290, 211);
            revenueGroupBox.TabIndex = 1;
            revenueGroupBox.TabStop = false;
            revenueGroupBox.Text = "Revenue Generated";
            // 
            // totalRevenueTotalLabel
            // 
            totalRevenueTotalLabel.BackColor = Color.White;
            totalRevenueTotalLabel.BorderStyle = BorderStyle.FixedSingle;
            totalRevenueTotalLabel.Location = new Point(130, 145);
            totalRevenueTotalLabel.Name = "totalRevenueTotalLabel";
            totalRevenueTotalLabel.Size = new Size(127, 19);
            totalRevenueTotalLabel.TabIndex = 2;
            totalRevenueTotalLabel.Text = "$0.00";
            // 
            // classCRevenueTotalLabel
            // 
            classCRevenueTotalLabel.BackColor = Color.White;
            classCRevenueTotalLabel.BorderStyle = BorderStyle.FixedSingle;
            classCRevenueTotalLabel.Location = new Point(130, 111);
            classCRevenueTotalLabel.Name = "classCRevenueTotalLabel";
            classCRevenueTotalLabel.Size = new Size(127, 19);
            classCRevenueTotalLabel.TabIndex = 2;
            classCRevenueTotalLabel.Text = "$0.00";
            // 
            // classBRevenueTotalLabel
            // 
            classBRevenueTotalLabel.BackColor = Color.White;
            classBRevenueTotalLabel.BorderStyle = BorderStyle.FixedSingle;
            classBRevenueTotalLabel.Location = new Point(130, 80);
            classBRevenueTotalLabel.Name = "classBRevenueTotalLabel";
            classBRevenueTotalLabel.Size = new Size(127, 19);
            classBRevenueTotalLabel.TabIndex = 2;
            classBRevenueTotalLabel.Text = "$0.00";
            // 
            // classARevenueTotalLabel
            // 
            classARevenueTotalLabel.BackColor = Color.White;
            classARevenueTotalLabel.BorderStyle = BorderStyle.FixedSingle;
            classARevenueTotalLabel.Location = new Point(130, 45);
            classARevenueTotalLabel.Name = "classARevenueTotalLabel";
            classARevenueTotalLabel.Size = new Size(127, 19);
            classARevenueTotalLabel.TabIndex = 2;
            classARevenueTotalLabel.Text = "$0.00";
            // 
            // totalRevenueLabel
            // 
            totalRevenueLabel.AutoSize = true;
            totalRevenueLabel.Location = new Point(39, 146);
            totalRevenueLabel.Name = "totalRevenueLabel";
            totalRevenueLabel.Size = new Size(42, 19);
            totalRevenueLabel.TabIndex = 1;
            totalRevenueLabel.Text = "Total:";
            // 
            // classCRevenueLabel
            // 
            classCRevenueLabel.AutoSize = true;
            classCRevenueLabel.Location = new Point(39, 111);
            classCRevenueLabel.Name = "classCRevenueLabel";
            classCRevenueLabel.Size = new Size(60, 19);
            classCRevenueLabel.TabIndex = 1;
            classCRevenueLabel.Text = "Class C:";
            // 
            // classARevenueLabel
            // 
            classARevenueLabel.AutoSize = true;
            classARevenueLabel.Location = new Point(39, 45);
            classARevenueLabel.Name = "classARevenueLabel";
            classARevenueLabel.Size = new Size(59, 19);
            classARevenueLabel.TabIndex = 1;
            classARevenueLabel.Text = "Class A:";
            // 
            // classBRevenueLabel
            // 
            classBRevenueLabel.AutoSize = true;
            classBRevenueLabel.Location = new Point(39, 80);
            classBRevenueLabel.Name = "classBRevenueLabel";
            classBRevenueLabel.Size = new Size(59, 19);
            classBRevenueLabel.TabIndex = 1;
            classBRevenueLabel.Text = "Class B:";
            // 
            // calculateRevenueButton
            // 
            calculateRevenueButton.Font = new Font("Times New Roman", 12F);
            calculateRevenueButton.Location = new Point(180, 361);
            calculateRevenueButton.Name = "calculateRevenueButton";
            calculateRevenueButton.Size = new Size(93, 53);
            calculateRevenueButton.TabIndex = 1;
            calculateRevenueButton.Text = "Calculate &Revenue";
            toolTip1.SetToolTip(calculateRevenueButton, "Press to calculate revenue");
            calculateRevenueButton.UseVisualStyleBackColor = true;
            calculateRevenueButton.Click += calculateRevenueButton_Click;
            // 
            // clearButton
            // 
            clearButton.Font = new Font("Times New Roman", 12F);
            clearButton.Location = new Point(330, 361);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(93, 53);
            clearButton.TabIndex = 2;
            clearButton.Text = "&Clear";
            toolTip1.SetToolTip(clearButton, "Press to clear data");
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Times New Roman", 12F);
            exitButton.Location = new Point(480, 361);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(93, 53);
            exitButton.TabIndex = 3;
            exitButton.Text = "&Exit";
            toolTip1.SetToolTip(exitButton, "Press to exit app");
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(58, 57);
            label2.Name = "label2";
            label2.Size = new Size(444, 17);
            label2.TabIndex = 4;
            label2.Text = "Enter number of ticket sales on left side to see income earned on the right.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 8.25F);
            label3.Location = new Point(15, 14);
            label3.Name = "label3";
            label3.Size = new Size(109, 14);
            label3.TabIndex = 4;
            label3.Text = "R to calculate revenue";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 8.25F);
            label4.Location = new Point(15, 28);
            label4.Name = "label4";
            label4.Size = new Size(111, 14);
            label4.TabIndex = 4;
            label4.Text = "C to clear entered info";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 8.25F);
            label5.Location = new Point(15, 44);
            label5.Name = "label5";
            label5.Size = new Size(48, 14);
            label5.TabIndex = 4;
            label5.Text = "E to exit";
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(58, 434);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 60);
            panel1.TabIndex = 5;
            // 
            // Form1
            // 
            AcceptButton = calculateRevenueButton;
            AutoScaleDimensions = new SizeF(6F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = exitButton;
            ClientSize = new Size(752, 530);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(calculateRevenueButton);
            Controls.Add(revenueGroupBox);
            Controls.Add(ticketGroupBox);
            Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ShawnConboy Chapter3 StadiumSeating";
            ticketGroupBox.ResumeLayout(false);
            ticketGroupBox.PerformLayout();
            revenueGroupBox.ResumeLayout(false);
            revenueGroupBox.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox ticketGroupBox;
        private TextBox classCTicketsTextbox;
        private Label classCTicketsLabel;
        private TextBox classBTicketsTextbox;
        private Label classBTicketsLabel;
        private TextBox classATicketsTextbox;
        private Label classATicketsLabel;
        private Label label1;
        private GroupBox revenueGroupBox;
        private Label totalRevenueLabel;
        private Label classCRevenueLabel;
        private Label classARevenueLabel;
        private Label classBRevenueLabel;
        private Label totalRevenueTotalLabel;
        private Label classCRevenueTotalLabel;
        private Label classBRevenueTotalLabel;
        private Label classARevenueTotalLabel;
        private Button calculateRevenueButton;
        private Button clearButton;
        private Button exitButton;
        private ToolTip toolTip1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel1;
    }
}
