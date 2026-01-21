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
            workshopListbox.Items.AddRange(new object[] { "Handling Stress", "Time Management", "Supervision Skills", "Negotiation", "How to Interview" });
            workshopListbox.Location = new Point(26, 91);
            workshopListbox.Name = "workshopListbox";
            workshopListbox.Size = new Size(150, 104);
            workshopListbox.TabIndex = 0;
            // 
            // locationListbox
            // 
            locationListbox.FormattingEnabled = true;
            locationListbox.Items.AddRange(new object[] { "Austin", "Chicago", "Dallas", "Orlando", "Phoenix", "Raleigh" });
            locationListbox.Location = new Point(217, 91);
            locationListbox.Name = "locationListbox";
            locationListbox.Size = new Size(150, 124);
            locationListbox.TabIndex = 0;
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(52, 313);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(94, 49);
            calculateButton.TabIndex = 1;
            calculateButton.Text = "Calculate Cost";
            toolTip1.SetToolTip(calculateButton, "Press to calculate cost");
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(176, 313);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(94, 49);
            clearButton.TabIndex = 1;
            clearButton.Text = "Clear";
            toolTip1.SetToolTip(clearButton, "Press to clear data");
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(293, 313);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(94, 49);
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
            outputLabel.Location = new Point(443, 91);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(444, 271);
            outputLabel.TabIndex = 2;
            // 
            // Form1
            // 
            AcceptButton = calculateButton;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = exitButton;
            ClientSize = new Size(947, 495);
            Controls.Add(outputLabel);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(calculateButton);
            Controls.Add(locationListbox);
            Controls.Add(workshopListbox);
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
