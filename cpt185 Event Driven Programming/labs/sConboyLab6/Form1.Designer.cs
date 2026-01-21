namespace sConboyLab6
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
            oilAndLubeGroupbox = new GroupBox();
            lubeJobCheckbox = new CheckBox();
            oilChangeCheckbox = new CheckBox();
            flushesGroupbox = new GroupBox();
            transmissionFlushCheckbox = new CheckBox();
            radiatorFlushCheckbox = new CheckBox();
            groupBox1 = new GroupBox();
            tireRotationCheckbox = new CheckBox();
            replaceMufflerCheckbox = new CheckBox();
            inspectionsCheckbox = new CheckBox();
            groupBox2 = new GroupBox();
            laborTextbox = new TextBox();
            label2 = new Label();
            partsTextbox = new TextBox();
            label1 = new Label();
            groupBox3 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            totalFeesLabel = new Label();
            taxOnPartsLabel = new Label();
            partsLabel = new Label();
            serviceAndLaborLabel = new Label();
            label3 = new Label();
            calculateButton = new Button();
            clearButton = new Button();
            exitButton = new Button();
            oilAndLubeGroupbox.SuspendLayout();
            flushesGroupbox.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // oilAndLubeGroupbox
            // 
            oilAndLubeGroupbox.Controls.Add(lubeJobCheckbox);
            oilAndLubeGroupbox.Controls.Add(oilChangeCheckbox);
            oilAndLubeGroupbox.Location = new Point(57, 71);
            oilAndLubeGroupbox.Name = "oilAndLubeGroupbox";
            oilAndLubeGroupbox.Size = new Size(250, 125);
            oilAndLubeGroupbox.TabIndex = 0;
            oilAndLubeGroupbox.TabStop = false;
            oilAndLubeGroupbox.Text = "Oil and Lube";
            // 
            // lubeJobCheckbox
            // 
            lubeJobCheckbox.AutoSize = true;
            lubeJobCheckbox.Location = new Point(31, 70);
            lubeJobCheckbox.Name = "lubeJobCheckbox";
            lubeJobCheckbox.Size = new Size(147, 24);
            lubeJobCheckbox.TabIndex = 0;
            lubeJobCheckbox.Text = "Lube Job ($18.00)";
            lubeJobCheckbox.UseVisualStyleBackColor = true;
            // 
            // oilChangeCheckbox
            // 
            oilChangeCheckbox.AutoSize = true;
            oilChangeCheckbox.Location = new Point(31, 40);
            oilChangeCheckbox.Name = "oilChangeCheckbox";
            oilChangeCheckbox.Size = new Size(161, 24);
            oilChangeCheckbox.TabIndex = 0;
            oilChangeCheckbox.Text = "Oil Change ($26.00)";
            oilChangeCheckbox.UseVisualStyleBackColor = true;
            // 
            // flushesGroupbox
            // 
            flushesGroupbox.Controls.Add(transmissionFlushCheckbox);
            flushesGroupbox.Controls.Add(radiatorFlushCheckbox);
            flushesGroupbox.Location = new Point(349, 71);
            flushesGroupbox.Name = "flushesGroupbox";
            flushesGroupbox.Size = new Size(250, 125);
            flushesGroupbox.TabIndex = 0;
            flushesGroupbox.TabStop = false;
            flushesGroupbox.Text = "Flushes";
            // 
            // transmissionFlushCheckbox
            // 
            transmissionFlushCheckbox.AutoSize = true;
            transmissionFlushCheckbox.Location = new Point(31, 70);
            transmissionFlushCheckbox.Name = "transmissionFlushCheckbox";
            transmissionFlushCheckbox.Size = new Size(209, 24);
            transmissionFlushCheckbox.TabIndex = 0;
            transmissionFlushCheckbox.Text = "Transmission Flush ($80.00)";
            transmissionFlushCheckbox.UseVisualStyleBackColor = true;
            // 
            // radiatorFlushCheckbox
            // 
            radiatorFlushCheckbox.AutoSize = true;
            radiatorFlushCheckbox.Location = new Point(31, 40);
            radiatorFlushCheckbox.Name = "radiatorFlushCheckbox";
            radiatorFlushCheckbox.Size = new Size(182, 24);
            radiatorFlushCheckbox.TabIndex = 0;
            radiatorFlushCheckbox.Text = "Radiator Flush ($30.00)";
            radiatorFlushCheckbox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tireRotationCheckbox);
            groupBox1.Controls.Add(replaceMufflerCheckbox);
            groupBox1.Controls.Add(inspectionsCheckbox);
            groupBox1.Location = new Point(57, 238);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 150);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Misc";
            // 
            // tireRotationCheckbox
            // 
            tireRotationCheckbox.AutoSize = true;
            tireRotationCheckbox.Location = new Point(31, 100);
            tireRotationCheckbox.Name = "tireRotationCheckbox";
            tireRotationCheckbox.Size = new Size(174, 24);
            tireRotationCheckbox.TabIndex = 0;
            tireRotationCheckbox.Text = "Tire Rotation ($20.00)";
            tireRotationCheckbox.UseVisualStyleBackColor = true;
            // 
            // replaceMufflerCheckbox
            // 
            replaceMufflerCheckbox.AutoSize = true;
            replaceMufflerCheckbox.Location = new Point(31, 70);
            replaceMufflerCheckbox.Name = "replaceMufflerCheckbox";
            replaceMufflerCheckbox.Size = new Size(201, 24);
            replaceMufflerCheckbox.TabIndex = 0;
            replaceMufflerCheckbox.Text = "Replace Muffler ($100.00)";
            replaceMufflerCheckbox.UseVisualStyleBackColor = true;
            // 
            // inspectionsCheckbox
            // 
            inspectionsCheckbox.AutoSize = true;
            inspectionsCheckbox.Location = new Point(31, 40);
            inspectionsCheckbox.Name = "inspectionsCheckbox";
            inspectionsCheckbox.Size = new Size(156, 24);
            inspectionsCheckbox.TabIndex = 0;
            inspectionsCheckbox.Text = "Inspection ($15.00)";
            inspectionsCheckbox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(laborTextbox);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(partsTextbox);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(349, 238);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 150);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Parts and Labor";
            // 
            // laborTextbox
            // 
            laborTextbox.Location = new Point(125, 82);
            laborTextbox.Name = "laborTextbox";
            laborTextbox.Size = new Size(96, 27);
            laborTextbox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 85);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 0;
            label2.Text = "Labor (hours)";
            // 
            // partsTextbox
            // 
            partsTextbox.Location = new Point(125, 46);
            partsTextbox.Name = "partsTextbox";
            partsTextbox.Size = new Size(96, 27);
            partsTextbox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 52);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 0;
            label1.Text = "Parts";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(totalFeesLabel);
            groupBox3.Controls.Add(taxOnPartsLabel);
            groupBox3.Controls.Add(partsLabel);
            groupBox3.Controls.Add(serviceAndLaborLabel);
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new Point(57, 430);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(542, 200);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Summary";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(181, 156);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 0;
            label6.Text = "Total Fees";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(158, 110);
            label5.Name = "label5";
            label5.Size = new Size(98, 20);
            label5.TabIndex = 0;
            label5.Text = "Tax (on parts)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(210, 70);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 0;
            label4.Text = "Parts";
            // 
            // totalFeesLabel
            // 
            totalFeesLabel.BorderStyle = BorderStyle.FixedSingle;
            totalFeesLabel.Location = new Point(292, 156);
            totalFeesLabel.Name = "totalFeesLabel";
            totalFeesLabel.Size = new Size(127, 28);
            totalFeesLabel.TabIndex = 0;
            // 
            // taxOnPartsLabel
            // 
            taxOnPartsLabel.BorderStyle = BorderStyle.FixedSingle;
            taxOnPartsLabel.Location = new Point(292, 110);
            taxOnPartsLabel.Name = "taxOnPartsLabel";
            taxOnPartsLabel.Size = new Size(127, 28);
            taxOnPartsLabel.TabIndex = 0;
            // 
            // partsLabel
            // 
            partsLabel.BorderStyle = BorderStyle.FixedSingle;
            partsLabel.Location = new Point(292, 70);
            partsLabel.Name = "partsLabel";
            partsLabel.Size = new Size(127, 28);
            partsLabel.TabIndex = 0;
            // 
            // serviceAndLaborLabel
            // 
            serviceAndLaborLabel.BorderStyle = BorderStyle.FixedSingle;
            serviceAndLaborLabel.Location = new Point(292, 30);
            serviceAndLaborLabel.Name = "serviceAndLaborLabel";
            serviceAndLaborLabel.Size = new Size(127, 28);
            serviceAndLaborLabel.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(123, 30);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 0;
            label3.Text = "Service and Labor";
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(150, 664);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(94, 29);
            calculateButton.TabIndex = 1;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(281, 664);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(94, 29);
            clearButton.TabIndex = 1;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(409, 664);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(94, 29);
            exitButton.TabIndex = 1;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 757);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(calculateButton);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(flushesGroupbox);
            Controls.Add(oilAndLubeGroupbox);
            Name = "Form1";
            Text = "Form1";
            oilAndLubeGroupbox.ResumeLayout(false);
            oilAndLubeGroupbox.PerformLayout();
            flushesGroupbox.ResumeLayout(false);
            flushesGroupbox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox oilAndLubeGroupbox;
        private CheckBox lubeJobCheckbox;
        private CheckBox oilChangeCheckbox;
        private GroupBox flushesGroupbox;
        private CheckBox transmissionFlushCheckbox;
        private CheckBox radiatorFlushCheckbox;
        private GroupBox groupBox1;
        private CheckBox tireRotationCheckbox;
        private CheckBox replaceMufflerCheckbox;
        private CheckBox inspectionsCheckbox;
        private GroupBox groupBox2;
        private TextBox laborTextbox;
        private Label label2;
        private TextBox partsTextbox;
        private Label label1;
        private GroupBox groupBox3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label totalFeesLabel;
        private Label taxOnPartsLabel;
        private Label partsLabel;
        private Label serviceAndLaborLabel;
        private Label label3;
        private Button calculateButton;
        private Button clearButton;
        private Button exitButton;
    }
}
