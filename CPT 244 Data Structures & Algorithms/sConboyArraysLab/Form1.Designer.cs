namespace sConboyArraysLab
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
            studentListbox = new ListBox();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            addStudentButton = new Button();
            gradeTextbox = new TextBox();
            nameTextbox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            aboveAverageListbox = new ListBox();
            label7 = new Label();
            label6 = new Label();
            groupBox3 = new GroupBox();
            belowAverageListbox = new ListBox();
            label8 = new Label();
            label9 = new Label();
            groupBox4 = new GroupBox();
            averageLabel = new Label();
            label10 = new Label();
            toolTip1 = new ToolTip(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // studentListbox
            // 
            studentListbox.FormattingEnabled = true;
            studentListbox.ItemHeight = 15;
            studentListbox.Location = new Point(176, 127);
            studentListbox.Name = "studentListbox";
            studentListbox.Size = new Size(223, 154);
            studentListbox.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(212, 54);
            label5.Name = "label5";
            label5.Size = new Size(140, 25);
            label5.TabIndex = 4;
            label5.Text = "Class Manager";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(286, 109);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 6;
            label2.Text = "Grade";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(176, 109);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 6;
            label1.Text = "Name";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(addStudentButton);
            groupBox1.Controls.Add(gradeTextbox);
            groupBox1.Controls.Add(nameTextbox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 289);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(551, 133);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Student";
            // 
            // addStudentButton
            // 
            addStudentButton.Location = new Point(238, 104);
            addStudentButton.Name = "addStudentButton";
            addStudentButton.Size = new Size(75, 23);
            addStudentButton.TabIndex = 2;
            addStudentButton.Text = "&Add";
            toolTip1.SetToolTip(addStudentButton, "Press to add student to array");
            addStudentButton.UseVisualStyleBackColor = true;
            addStudentButton.Click += addStudentButton_Click;
            // 
            // gradeTextbox
            // 
            gradeTextbox.Location = new Point(294, 61);
            gradeTextbox.Name = "gradeTextbox";
            gradeTextbox.Size = new Size(100, 23);
            gradeTextbox.TabIndex = 1;
            // 
            // nameTextbox
            // 
            nameTextbox.Location = new Point(294, 25);
            nameTextbox.Name = "nameTextbox";
            nameTextbox.Size = new Size(100, 23);
            nameTextbox.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(158, 64);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 0;
            label4.Text = "Student Grade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(157, 28);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 0;
            label3.Text = "Student Name";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(aboveAverageListbox);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(14, 79);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(246, 216);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Above Average";
            // 
            // aboveAverageListbox
            // 
            aboveAverageListbox.FormattingEnabled = true;
            aboveAverageListbox.ItemHeight = 15;
            aboveAverageListbox.Location = new Point(12, 49);
            aboveAverageListbox.Name = "aboveAverageListbox";
            aboveAverageListbox.Size = new Size(223, 154);
            aboveAverageListbox.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(122, 31);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 6;
            label7.Text = "Grade";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 31);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 6;
            label6.Text = "Name";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(belowAverageListbox);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(276, 79);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(246, 216);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Below Average";
            // 
            // belowAverageListbox
            // 
            belowAverageListbox.FormattingEnabled = true;
            belowAverageListbox.ItemHeight = 15;
            belowAverageListbox.Location = new Point(12, 49);
            belowAverageListbox.Name = "belowAverageListbox";
            belowAverageListbox.Size = new Size(223, 154);
            belowAverageListbox.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(122, 31);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 6;
            label8.Text = "Grade";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 31);
            label9.Name = "label9";
            label9.Size = new Size(39, 15);
            label9.TabIndex = 6;
            label9.Text = "Name";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(averageLabel);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(groupBox3);
            groupBox4.Controls.Add(groupBox2);
            groupBox4.Location = new Point(26, 439);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(537, 314);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            groupBox4.Text = "Averages";
            // 
            // averageLabel
            // 
            averageLabel.BorderStyle = BorderStyle.FixedSingle;
            averageLabel.Location = new Point(280, 37);
            averageLabel.Name = "averageLabel";
            averageLabel.Size = new Size(100, 23);
            averageLabel.TabIndex = 10;
            averageLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(157, 41);
            label10.Name = "label10";
            label10.Size = new Size(89, 15);
            label10.TabIndex = 9;
            label10.Text = "Class Average : ";
            // 
            // Form1
            // 
            AcceptButton = addStudentButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 778);
            Controls.Add(groupBox4);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(studentListbox);
            Controls.Add(label5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "sConboyArraysLab";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox studentListbox;
        private Label label5;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox gradeTextbox;
        private TextBox nameTextbox;
        private Label label4;
        private Label label3;
        private Button addStudentButton;
        private GroupBox groupBox2;
        private ListBox aboveAverageListbox;
        private Label label7;
        private Label label6;
        private GroupBox groupBox3;
        private ListBox belowAverageListbox;
        private Label label8;
        private Label label9;
        private GroupBox groupBox4;
        private Label averageLabel;
        private Label label10;
        private ToolTip toolTip1;
    }
}
