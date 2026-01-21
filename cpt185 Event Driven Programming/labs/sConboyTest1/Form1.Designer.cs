namespace sConboyTest1
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
            brandLabel = new Label();
            manufacturerListbox = new ListBox();
            priceLabel = new Label();
            priceTextbox = new TextBox();
            transmissionLabel = new Label();
            transmissionTypeTextbox = new TextBox();
            subtotalLabel = new Label();
            subTotalTextbox = new TextBox();
            taxesLabel = new Label();
            taxesTextbox = new TextBox();
            totalLabel = new Label();
            totalTextbox = new TextBox();
            calculateButton = new Button();
            clearButton = new Button();
            exitButton = new Button();
            transmissionListboxLabel = new Label();
            transmissionListbox = new ListBox();
            taxRateLabel = new Label();
            taxRateTextbox = new TextBox();
            carChoiceLabel = new Label();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // brandLabel
            // 
            brandLabel.AutoSize = true;
            brandLabel.Font = new Font("Times New Roman", 10.2F);
            brandLabel.Location = new Point(128, 44);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new Size(101, 19);
            brandLabel.TabIndex = 0;
            brandLabel.Text = "Manufacturer";
            // 
            // manufacturerListbox
            // 
            manufacturerListbox.Font = new Font("Times New Roman", 10.2F);
            manufacturerListbox.FormattingEnabled = true;
            manufacturerListbox.ItemHeight = 19;
            manufacturerListbox.Items.AddRange(new object[] { "Lamborghini", "Ferrari", "Corvette", "Tesla", "Bentley" });
            manufacturerListbox.Location = new Point(128, 77);
            manufacturerListbox.Name = "manufacturerListbox";
            manufacturerListbox.Size = new Size(150, 99);
            manufacturerListbox.TabIndex = 1;
            toolTip1.SetToolTip(manufacturerListbox, "Choose a car");
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Times New Roman", 10.2F);
            priceLabel.Location = new Point(434, 101);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(46, 19);
            priceLabel.TabIndex = 2;
            priceLabel.Text = "Price";
            // 
            // priceTextbox
            // 
            priceTextbox.BackColor = SystemColors.Window;
            priceTextbox.Font = new Font("Times New Roman", 10.2F);
            priceTextbox.Location = new Point(522, 101);
            priceTextbox.Name = "priceTextbox";
            priceTextbox.ReadOnly = true;
            priceTextbox.Size = new Size(125, 27);
            priceTextbox.TabIndex = 3;
            // 
            // transmissionLabel
            // 
            transmissionLabel.Font = new Font("Times New Roman", 10.2F);
            transmissionLabel.Location = new Point(388, 157);
            transmissionLabel.Name = "transmissionLabel";
            transmissionLabel.Size = new Size(93, 20);
            transmissionLabel.TabIndex = 2;
            transmissionLabel.Text = "Transmission";
            transmissionLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // transmissionTypeTextbox
            // 
            transmissionTypeTextbox.BackColor = SystemColors.Window;
            transmissionTypeTextbox.Font = new Font("Times New Roman", 10.2F);
            transmissionTypeTextbox.Location = new Point(522, 154);
            transmissionTypeTextbox.Name = "transmissionTypeTextbox";
            transmissionTypeTextbox.ReadOnly = true;
            transmissionTypeTextbox.Size = new Size(125, 27);
            transmissionTypeTextbox.TabIndex = 3;
            // 
            // subtotalLabel
            // 
            subtotalLabel.AutoSize = true;
            subtotalLabel.Font = new Font("Times New Roman", 10.2F);
            subtotalLabel.Location = new Point(421, 291);
            subtotalLabel.Name = "subtotalLabel";
            subtotalLabel.Size = new Size(68, 19);
            subtotalLabel.TabIndex = 2;
            subtotalLabel.Text = "SubTotal";
            // 
            // subTotalTextbox
            // 
            subTotalTextbox.BackColor = SystemColors.Window;
            subTotalTextbox.Font = new Font("Times New Roman", 10.2F);
            subTotalTextbox.Location = new Point(522, 288);
            subTotalTextbox.Name = "subTotalTextbox";
            subTotalTextbox.ReadOnly = true;
            subTotalTextbox.Size = new Size(125, 27);
            subTotalTextbox.TabIndex = 3;
            // 
            // taxesLabel
            // 
            taxesLabel.AutoSize = true;
            taxesLabel.Font = new Font("Times New Roman", 10.2F);
            taxesLabel.Location = new Point(434, 324);
            taxesLabel.Name = "taxesLabel";
            taxesLabel.Size = new Size(47, 19);
            taxesLabel.TabIndex = 2;
            taxesLabel.Text = "Taxes";
            // 
            // taxesTextbox
            // 
            taxesTextbox.BackColor = SystemColors.Window;
            taxesTextbox.Font = new Font("Times New Roman", 10.2F);
            taxesTextbox.Location = new Point(522, 321);
            taxesTextbox.Name = "taxesTextbox";
            taxesTextbox.ReadOnly = true;
            taxesTextbox.Size = new Size(125, 27);
            taxesTextbox.TabIndex = 3;
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Font = new Font("Times New Roman", 10.2F);
            totalLabel.Location = new Point(440, 357);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(43, 19);
            totalLabel.TabIndex = 2;
            totalLabel.Text = "Total";
            // 
            // totalTextbox
            // 
            totalTextbox.BackColor = SystemColors.Window;
            totalTextbox.Font = new Font("Times New Roman", 10.2F);
            totalTextbox.Location = new Point(522, 354);
            totalTextbox.Name = "totalTextbox";
            totalTextbox.ReadOnly = true;
            totalTextbox.Size = new Size(125, 27);
            totalTextbox.TabIndex = 3;
            // 
            // calculateButton
            // 
            calculateButton.Font = new Font("Times New Roman", 10.2F);
            calculateButton.Location = new Point(184, 448);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(94, 29);
            calculateButton.TabIndex = 1;
            calculateButton.Text = "&Calculate";
            toolTip1.SetToolTip(calculateButton, "Press to calculate total");
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // clearButton
            // 
            clearButton.Font = new Font("Times New Roman", 10.2F);
            clearButton.Location = new Point(352, 448);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(94, 29);
            clearButton.TabIndex = 2;
            clearButton.Text = "C&lear";
            toolTip1.SetToolTip(clearButton, "Press to clear the form");
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Times New Roman", 10.2F);
            exitButton.Location = new Point(522, 448);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(94, 29);
            exitButton.TabIndex = 3;
            exitButton.Text = "E&xit";
            toolTip1.SetToolTip(exitButton, "Press to exit the form");
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // transmissionListboxLabel
            // 
            transmissionListboxLabel.AutoSize = true;
            transmissionListboxLabel.Font = new Font("Times New Roman", 10.2F);
            transmissionListboxLabel.Location = new Point(128, 253);
            transmissionListboxLabel.Name = "transmissionListboxLabel";
            transmissionListboxLabel.Size = new Size(135, 19);
            transmissionListboxLabel.TabIndex = 0;
            transmissionListboxLabel.Text = "Transmission Type";
            // 
            // transmissionListbox
            // 
            transmissionListbox.Font = new Font("Times New Roman", 10.2F);
            transmissionListbox.FormattingEnabled = true;
            transmissionListbox.ItemHeight = 19;
            transmissionListbox.Items.AddRange(new object[] { "Automatic", "Manual", "Hybrid" });
            transmissionListbox.Location = new Point(128, 288);
            transmissionListbox.Name = "transmissionListbox";
            transmissionListbox.Size = new Size(150, 61);
            transmissionListbox.TabIndex = 1;
            toolTip1.SetToolTip(transmissionListbox, "Choose a transmission type");
            // 
            // taxRateLabel
            // 
            taxRateLabel.AutoSize = true;
            taxRateLabel.Font = new Font("Times New Roman", 10.2F);
            taxRateLabel.Location = new Point(482, 221);
            taxRateLabel.Name = "taxRateLabel";
            taxRateLabel.Size = new Size(67, 19);
            taxRateLabel.TabIndex = 2;
            taxRateLabel.Text = "Tax Rate";
            // 
            // taxRateTextbox
            // 
            taxRateTextbox.Font = new Font("Times New Roman", 10.2F);
            taxRateTextbox.Location = new Point(609, 218);
            taxRateTextbox.Name = "taxRateTextbox";
            taxRateTextbox.Size = new Size(56, 27);
            taxRateTextbox.TabIndex = 0;
            toolTip1.SetToolTip(taxRateTextbox, "Enter current tax rate");
            // 
            // carChoiceLabel
            // 
            carChoiceLabel.Font = new Font("Times New Roman", 10.2F);
            carChoiceLabel.Location = new Point(388, 56);
            carChoiceLabel.Name = "carChoiceLabel";
            carChoiceLabel.Size = new Size(295, 32);
            carChoiceLabel.TabIndex = 0;
            carChoiceLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AcceptButton = calculateButton;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = exitButton;
            ClientSize = new Size(800, 579);
            Controls.Add(taxRateLabel);
            Controls.Add(taxRateTextbox);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(calculateButton);
            Controls.Add(totalTextbox);
            Controls.Add(totalLabel);
            Controls.Add(taxesTextbox);
            Controls.Add(taxesLabel);
            Controls.Add(subTotalTextbox);
            Controls.Add(subtotalLabel);
            Controls.Add(transmissionTypeTextbox);
            Controls.Add(transmissionLabel);
            Controls.Add(priceTextbox);
            Controls.Add(priceLabel);
            Controls.Add(transmissionListbox);
            Controls.Add(transmissionListboxLabel);
            Controls.Add(manufacturerListbox);
            Controls.Add(carChoiceLabel);
            Controls.Add(brandLabel);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Conboy Test 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label brandLabel;
        private ListBox manufacturerListbox;
        private Label priceLabel;
        private TextBox priceTextbox;
        private Label transmissionLabel;
        private TextBox transmissionTypeTextbox;
        private Label subtotalLabel;
        private TextBox subTotalTextbox;
        private Label taxesLabel;
        private TextBox taxesTextbox;
        private Label totalLabel;
        private TextBox totalTextbox;
        private Button calculateButton;
        private Button clearButton;
        private Button exitButton;
        private Label transmissionListboxLabel;
        private ListBox transmissionListbox;
        private Label taxRateLabel;
        private TextBox taxRateTextbox;
        private Label carChoiceLabel;
        private ToolTip toolTip1;
    }
}
