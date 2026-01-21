namespace carList
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
            carInfoGroupBox = new GroupBox();
            mileageTextbox = new TextBox();
            yearTextbox = new TextBox();
            makeTextbox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            carsListbox = new ListBox();
            addButton = new Button();
            exitButton = new Button();
            carInfoGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // carInfoGroupBox
            // 
            carInfoGroupBox.Controls.Add(mileageTextbox);
            carInfoGroupBox.Controls.Add(yearTextbox);
            carInfoGroupBox.Controls.Add(makeTextbox);
            carInfoGroupBox.Controls.Add(label3);
            carInfoGroupBox.Controls.Add(label2);
            carInfoGroupBox.Controls.Add(label1);
            carInfoGroupBox.Location = new Point(96, 116);
            carInfoGroupBox.Name = "carInfoGroupBox";
            carInfoGroupBox.Size = new Size(400, 264);
            carInfoGroupBox.TabIndex = 0;
            carInfoGroupBox.TabStop = false;
            carInfoGroupBox.Text = "Car Information";
            // 
            // mileageTextbox
            // 
            mileageTextbox.Location = new Point(161, 199);
            mileageTextbox.Name = "mileageTextbox";
            mileageTextbox.Size = new Size(200, 39);
            mileageTextbox.TabIndex = 2;
            // 
            // yearTextbox
            // 
            yearTextbox.Location = new Point(161, 38);
            yearTextbox.Name = "yearTextbox";
            yearTextbox.Size = new Size(200, 39);
            yearTextbox.TabIndex = 0;
            // 
            // makeTextbox
            // 
            makeTextbox.Location = new Point(161, 119);
            makeTextbox.Name = "makeTextbox";
            makeTextbox.Size = new Size(200, 39);
            makeTextbox.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 206);
            label3.Name = "label3";
            label3.Size = new Size(112, 32);
            label3.TabIndex = 0;
            label3.Text = "Mileage :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 45);
            label2.Name = "label2";
            label2.Size = new Size(70, 32);
            label2.TabIndex = 0;
            label2.Text = "Year :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 119);
            label1.Name = "label1";
            label1.Size = new Size(85, 32);
            label1.TabIndex = 0;
            label1.Text = "Make :";
            // 
            // carsListbox
            // 
            carsListbox.FormattingEnabled = true;
            carsListbox.Location = new Point(602, 116);
            carsListbox.Name = "carsListbox";
            carsListbox.Size = new Size(455, 260);
            carsListbox.TabIndex = 1;
            carsListbox.TabStop = false;
            // 
            // addButton
            // 
            addButton.Location = new Point(183, 456);
            addButton.Name = "addButton";
            addButton.Size = new Size(213, 52);
            addButton.TabIndex = 1;
            addButton.Text = "Add Car To List";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(722, 456);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(213, 46);
            exitButton.TabIndex = 2;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1137, 584);
            Controls.Add(exitButton);
            Controls.Add(addButton);
            Controls.Add(carsListbox);
            Controls.Add(carInfoGroupBox);
            Name = "Form1";
            Text = "Form1";
            carInfoGroupBox.ResumeLayout(false);
            carInfoGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox carInfoGroupBox;
        private TextBox mileageTextbox;
        private TextBox yearTextbox;
        private TextBox makeTextbox;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListBox carsListbox;
        private Button addButton;
        private Button exitButton;
    }
}
