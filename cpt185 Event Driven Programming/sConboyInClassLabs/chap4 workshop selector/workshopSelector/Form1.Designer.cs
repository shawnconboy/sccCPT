namespace workshopSelector
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
            workshopListbox = new ListBox();
            locationListbox = new ListBox();
            calculateButton = new Button();
            clearButton = new Button();
            exitButton = new Button();
            toolTip1 = new ToolTip(components);
            outputLabel = new Label();
            SuspendLayout();
            // 
            // workshopListbox
            // 
            workshopListbox.FormattingEnabled = true;
            workshopListbox.ItemHeight = 15;
            workshopListbox.Items.AddRange(new object[] { "Handling Stress", "Time Management", "Supervision Skills", "Negotiation", "How to Interview" });
            workshopListbox.Location = new Point(23, 68);
            workshopListbox.Margin = new Padding(3, 2, 3, 2);
            workshopListbox.Name = "workshopListbox";
            workshopListbox.Size = new Size(132, 79);
            workshopListbox.TabIndex = 0;
            // 
            // locationListbox
            // 
            locationListbox.FormattingEnabled = true;
            locationListbox.ItemHeight = 15;
            locationListbox.Items.AddRange(new object[] { "Austin", "Chicago", "Dallas", "Orlando", "Phoenix", "Raleigh" });
            locationListbox.Location = new Point(190, 68);
            locationListbox.Margin = new Padding(3, 2, 3, 2);
            locationListbox.Name = "locationListbox";
            locationListbox.Size = new Size(132, 94);
            locationListbox.TabIndex = 0;
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(46, 235);
            calculateButton.Margin = new Padding(3, 2, 3, 2);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(82, 48);
            calculateButton.TabIndex = 1;
            calculateButton.Text = "Calculate Cost";
            toolTip1.SetToolTip(calculateButton, "Press to calculate cost");
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(154, 235);
            clearButton.Margin = new Padding(3, 2, 3, 2);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(82, 48);
            clearButton.TabIndex = 1;
            clearButton.Text = "Clear";
            toolTip1.SetToolTip(clearButton, "Press to clear data");
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(256, 235);
            exitButton.Margin = new Padding(3, 2, 3, 2);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(82, 48);
            exitButton.TabIndex = 1;
            exitButton.Text = "Exit";
            toolTip1.SetToolTip(exitButton, "Press to exit");
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // outputLabel
            // 
            outputLabel.BorderStyle = BorderStyle.Fixed3D;
            outputLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outputLabel.Location = new Point(388, 68);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(388, 203);
            outputLabel.TabIndex = 2;
            // 
            // Form1
            // 
            AcceptButton = calculateButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = exitButton;
            ClientSize = new Size(829, 371);
            Controls.Add(outputLabel);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(calculateButton);
            Controls.Add(locationListbox);
            Controls.Add(workshopListbox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Workshop Selector";
            ResumeLayout(false);
        }

        #endregion

        private ListBox workshopListbox;
        private ListBox locationListbox;
        private Button calculateButton;
        private Button clearButton;
        private Button exitButton;
        private ToolTip toolTip1;
        private Label outputLabel;
    }
}
