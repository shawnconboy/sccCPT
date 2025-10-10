namespace joesAutomotive
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
            groupBox1 = new GroupBox();
            lubeJobCheckbox = new CheckBox();
            oilChangeCheckbox = new CheckBox();
            groupBox2 = new GroupBox();
            transmissionCheckbox = new CheckBox();
            radiatorCheckbox = new CheckBox();
            groupBox3 = new GroupBox();
            tireRotationCheckbox = new CheckBox();
            replaceMufflerCheckbox = new CheckBox();
            inspectionCheckbox = new CheckBox();
            groupBox4 = new GroupBox();
            laborTextbox = new TextBox();
            label2 = new Label();
            partsTextbox = new TextBox();
            label1 = new Label();
            groupBox5 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            totalFeesLabel = new Label();
            taxOnPartsLabel = new Label();
            partsLabel = new Label();
            serviceAndLaborlabel = new Label();
            label3 = new Label();
            calculateButton = new Button();
            clearButton = new Button();
            exitButton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lubeJobCheckbox);
            groupBox1.Controls.Add(oilChangeCheckbox);
            groupBox1.Location = new Point(65, 92);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Oil and Lube";
            // 
            // lubeJobCheckbox
            // 
            lubeJobCheckbox.AutoSize = true;
            lubeJobCheckbox.Location = new Point(6, 47);
            lubeJobCheckbox.Name = "lubeJobCheckbox";
            lubeJobCheckbox.Size = new Size(117, 19);
            lubeJobCheckbox.TabIndex = 1;
            lubeJobCheckbox.Text = "Lube Job ($18.00)";
            lubeJobCheckbox.UseVisualStyleBackColor = true;
            // 
            // oilChangeCheckbox
            // 
            oilChangeCheckbox.AutoSize = true;
            oilChangeCheckbox.Location = new Point(6, 22);
            oilChangeCheckbox.Name = "oilChangeCheckbox";
            oilChangeCheckbox.Size = new Size(129, 19);
            oilChangeCheckbox.TabIndex = 0;
            oilChangeCheckbox.Text = "Oil Change ($26.00)";
            oilChangeCheckbox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(transmissionCheckbox);
            groupBox2.Controls.Add(radiatorCheckbox);
            groupBox2.Location = new Point(298, 92);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 100);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Flushes";
            // 
            // transmissionCheckbox
            // 
            transmissionCheckbox.AutoSize = true;
            transmissionCheckbox.Location = new Point(6, 47);
            transmissionCheckbox.Name = "transmissionCheckbox";
            transmissionCheckbox.Size = new Size(170, 19);
            transmissionCheckbox.TabIndex = 1;
            transmissionCheckbox.Text = "Transmission Flush ($80.00)";
            transmissionCheckbox.UseVisualStyleBackColor = true;
            // 
            // radiatorCheckbox
            // 
            radiatorCheckbox.AutoSize = true;
            radiatorCheckbox.Location = new Point(6, 22);
            radiatorCheckbox.Name = "radiatorCheckbox";
            radiatorCheckbox.Size = new Size(145, 19);
            radiatorCheckbox.TabIndex = 0;
            radiatorCheckbox.Text = "Radiator Flush ($30.00)";
            radiatorCheckbox.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tireRotationCheckbox);
            groupBox3.Controls.Add(replaceMufflerCheckbox);
            groupBox3.Controls.Add(inspectionCheckbox);
            groupBox3.Location = new Point(65, 212);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 100);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Misc";
            // 
            // tireRotationCheckbox
            // 
            tireRotationCheckbox.AutoSize = true;
            tireRotationCheckbox.Location = new Point(6, 72);
            tireRotationCheckbox.Name = "tireRotationCheckbox";
            tireRotationCheckbox.Size = new Size(138, 19);
            tireRotationCheckbox.TabIndex = 2;
            tireRotationCheckbox.Text = "Tire Rotation ($20.00)";
            tireRotationCheckbox.UseVisualStyleBackColor = true;
            // 
            // replaceMufflerCheckbox
            // 
            replaceMufflerCheckbox.AutoSize = true;
            replaceMufflerCheckbox.Location = new Point(6, 47);
            replaceMufflerCheckbox.Name = "replaceMufflerCheckbox";
            replaceMufflerCheckbox.Size = new Size(159, 19);
            replaceMufflerCheckbox.TabIndex = 1;
            replaceMufflerCheckbox.Text = "Replace Muffler ($100.00)";
            replaceMufflerCheckbox.UseVisualStyleBackColor = true;
            // 
            // inspectionCheckbox
            // 
            inspectionCheckbox.AutoSize = true;
            inspectionCheckbox.Location = new Point(6, 22);
            inspectionCheckbox.Name = "inspectionCheckbox";
            inspectionCheckbox.Size = new Size(125, 19);
            inspectionCheckbox.TabIndex = 0;
            inspectionCheckbox.Text = "Inspection ($15.00)";
            inspectionCheckbox.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(laborTextbox);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(partsTextbox);
            groupBox4.Controls.Add(label1);
            groupBox4.Location = new Point(298, 212);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(200, 100);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Parts and Labor";
            // 
            // laborTextbox
            // 
            laborTextbox.Location = new Point(112, 51);
            laborTextbox.Name = "laborTextbox";
            laborTextbox.Size = new Size(64, 23);
            laborTextbox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 54);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 0;
            label2.Text = "Labor (Hours)";
            // 
            // partsTextbox
            // 
            partsTextbox.Location = new Point(112, 22);
            partsTextbox.Name = "partsTextbox";
            partsTextbox.Size = new Size(64, 23);
            partsTextbox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 25);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 0;
            label1.Text = "Parts";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label6);
            groupBox5.Controls.Add(label5);
            groupBox5.Controls.Add(label4);
            groupBox5.Controls.Add(totalFeesLabel);
            groupBox5.Controls.Add(taxOnPartsLabel);
            groupBox5.Controls.Add(partsLabel);
            groupBox5.Controls.Add(serviceAndLaborlabel);
            groupBox5.Controls.Add(label3);
            groupBox5.Location = new Point(65, 343);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(433, 164);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "Summary";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(141, 123);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 0;
            label6.Text = "Total Fees";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(122, 94);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 0;
            label5.Text = "Tax (on parts)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(167, 64);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 0;
            label4.Text = "Parts";
            // 
            // totalFeesLabel
            // 
            totalFeesLabel.BorderStyle = BorderStyle.FixedSingle;
            totalFeesLabel.Location = new Point(232, 118);
            totalFeesLabel.Name = "totalFeesLabel";
            totalFeesLabel.Size = new Size(98, 24);
            totalFeesLabel.TabIndex = 0;
            totalFeesLabel.Text = "$0.00";
            totalFeesLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // taxOnPartsLabel
            // 
            taxOnPartsLabel.BorderStyle = BorderStyle.FixedSingle;
            taxOnPartsLabel.Location = new Point(232, 89);
            taxOnPartsLabel.Name = "taxOnPartsLabel";
            taxOnPartsLabel.Size = new Size(98, 24);
            taxOnPartsLabel.TabIndex = 0;
            taxOnPartsLabel.Text = "$0.00";
            taxOnPartsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // partsLabel
            // 
            partsLabel.BorderStyle = BorderStyle.FixedSingle;
            partsLabel.Location = new Point(232, 59);
            partsLabel.Name = "partsLabel";
            partsLabel.Size = new Size(98, 24);
            partsLabel.TabIndex = 0;
            partsLabel.Text = "$0.00";
            partsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // serviceAndLaborlabel
            // 
            serviceAndLaborlabel.BorderStyle = BorderStyle.FixedSingle;
            serviceAndLaborlabel.Location = new Point(232, 30);
            serviceAndLaborlabel.Name = "serviceAndLaborlabel";
            serviceAndLaborlabel.Size = new Size(98, 24);
            serviceAndLaborlabel.TabIndex = 0;
            serviceAndLaborlabel.Text = "$0.00";
            serviceAndLaborlabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 35);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 0;
            label3.Text = "Service and Labor";
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(163, 561);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(75, 23);
            calculateButton.TabIndex = 4;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(244, 561);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 5;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(325, 561);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 6;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 685);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(calculateButton);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Joes Automotive";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox lubeJobCheckbox;
        private CheckBox oilChangeCheckbox;
        private GroupBox groupBox2;
        private CheckBox transmissionCheckbox;
        private CheckBox radiatorCheckbox;
        private GroupBox groupBox3;
        private CheckBox tireRotationCheckbox;
        private CheckBox replaceMufflerCheckbox;
        private CheckBox inspectionCheckbox;
        private GroupBox groupBox4;
        private TextBox laborTextbox;
        private Label label2;
        private TextBox partsTextbox;
        private Label label1;
        private GroupBox groupBox5;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label totalFeesLabel;
        private Label taxOnPartsLabel;
        private Label partsLabel;
        private Label serviceAndLaborlabel;
        private Label label3;
        private Button calculateButton;
        private Button clearButton;
        private Button exitButton;
    }
}
