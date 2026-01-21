namespace employeeAndProductionWorker
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
            nameLabel = new Label();
            hourlyLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            employeeNameTextbox = new TextBox();
            employeeIDTextbox = new TextBox();
            employeeShiftTextbox = new TextBox();
            employeeRateTextbox = new TextBox();
            submitButton = new Button();
            employeeListbox = new ListBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(33, 50);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(119, 20);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Employee Name";
            // 
            // hourlyLabel
            // 
            hourlyLabel.AutoSize = true;
            hourlyLabel.Location = new Point(58, 97);
            hourlyLabel.Name = "hourlyLabel";
            hourlyLabel.Size = new Size(94, 20);
            hourlyLabel.TabIndex = 1;
            hourlyLabel.Text = "Employee ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 143);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 1;
            label1.Text = "Shift";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 192);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 1;
            label2.Text = "Pay Rate";
            // 
            // employeeNameTextbox
            // 
            employeeNameTextbox.Location = new Point(210, 47);
            employeeNameTextbox.Name = "employeeNameTextbox";
            employeeNameTextbox.Size = new Size(125, 27);
            employeeNameTextbox.TabIndex = 0;
            // 
            // employeeIDTextbox
            // 
            employeeIDTextbox.Location = new Point(210, 94);
            employeeIDTextbox.Name = "employeeIDTextbox";
            employeeIDTextbox.Size = new Size(125, 27);
            employeeIDTextbox.TabIndex = 1;
            // 
            // employeeShiftTextbox
            // 
            employeeShiftTextbox.Location = new Point(210, 140);
            employeeShiftTextbox.Name = "employeeShiftTextbox";
            employeeShiftTextbox.Size = new Size(125, 27);
            employeeShiftTextbox.TabIndex = 2;
            // 
            // employeeRateTextbox
            // 
            employeeRateTextbox.Location = new Point(210, 189);
            employeeRateTextbox.Name = "employeeRateTextbox";
            employeeRateTextbox.Size = new Size(125, 27);
            employeeRateTextbox.TabIndex = 3;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(152, 239);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(94, 29);
            submitButton.TabIndex = 4;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // employeeListbox
            // 
            employeeListbox.FormattingEnabled = true;
            employeeListbox.Location = new Point(37, 28);
            employeeListbox.Name = "employeeListbox";
            employeeListbox.Size = new Size(247, 204);
            employeeListbox.TabIndex = 0;
            employeeListbox.SelectedIndexChanged += employeeListbox_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(submitButton);
            groupBox1.Controls.Add(nameLabel);
            groupBox1.Controls.Add(hourlyLabel);
            groupBox1.Controls.Add(employeeRateTextbox);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(employeeIDTextbox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(employeeShiftTextbox);
            groupBox1.Controls.Add(employeeNameTextbox);
            groupBox1.Location = new Point(42, 101);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(369, 281);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add An Employee";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(employeeListbox);
            groupBox2.Location = new Point(445, 101);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(323, 275);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "All Employees";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(289, 32);
            label3.Name = "label3";
            label3.Size = new Size(232, 38);
            label3.TabIndex = 7;
            label3.Text = "Employee Portal";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 483);
            Controls.Add(label3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private Label hourlyLabel;
        private Label label1;
        private Label label2;
        private TextBox employeeNameTextbox;
        private TextBox employeeIDTextbox;
        private TextBox employeeShiftTextbox;
        private TextBox employeeRateTextbox;
        private Button submitButton;
        private ListBox employeeListbox;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label3;
    }
}
