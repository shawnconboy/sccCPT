namespace petClass
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
            label1 = new Label();
            nameTextbox = new TextBox();
            label2 = new Label();
            typeTextbox = new TextBox();
            label3 = new Label();
            ageTextbox = new TextBox();
            button1 = new Button();
            petListbox = new ListBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            nameResultLabel = new Label();
            typeResultLabel = new Label();
            ageResultLabel = new Label();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(158, 120);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // nameTextbox
            // 
            nameTextbox.Location = new Point(252, 117);
            nameTextbox.Margin = new Padding(2);
            nameTextbox.Name = "nameTextbox";
            nameTextbox.Size = new Size(121, 27);
            nameTextbox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(162, 180);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 2;
            label2.Text = "Type";
            // 
            // typeTextbox
            // 
            typeTextbox.Location = new Point(252, 177);
            typeTextbox.Name = "typeTextbox";
            typeTextbox.Size = new Size(125, 27);
            typeTextbox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(162, 234);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 2;
            label3.Text = "Age";
            // 
            // ageTextbox
            // 
            ageTextbox.Location = new Point(252, 231);
            ageTextbox.Name = "ageTextbox";
            ageTextbox.Size = new Size(125, 27);
            ageTextbox.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(204, 302);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // petListbox
            // 
            petListbox.FormattingEnabled = true;
            petListbox.Location = new Point(479, 117);
            petListbox.Name = "petListbox";
            petListbox.Size = new Size(209, 144);
            petListbox.TabIndex = 5;
            petListbox.SelectedIndexChanged += petListbox_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(479, 73);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 6;
            label4.Text = "Click A Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(813, 117);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 7;
            label5.Text = "Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(813, 160);
            label6.Name = "label6";
            label6.Size = new Size(40, 20);
            label6.TabIndex = 8;
            label6.Text = "Type";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(813, 211);
            label7.Name = "label7";
            label7.Size = new Size(36, 20);
            label7.TabIndex = 9;
            label7.Text = "Age";
            // 
            // nameResultLabel
            // 
            nameResultLabel.AutoSize = true;
            nameResultLabel.Location = new Point(891, 117);
            nameResultLabel.Name = "nameResultLabel";
            nameResultLabel.Size = new Size(0, 20);
            nameResultLabel.TabIndex = 10;
            // 
            // typeResultLabel
            // 
            typeResultLabel.AutoSize = true;
            typeResultLabel.Location = new Point(891, 160);
            typeResultLabel.Name = "typeResultLabel";
            typeResultLabel.Size = new Size(0, 20);
            typeResultLabel.TabIndex = 10;
            // 
            // ageResultLabel
            // 
            ageResultLabel.AutoSize = true;
            ageResultLabel.Location = new Point(891, 211);
            ageResultLabel.Name = "ageResultLabel";
            ageResultLabel.Size = new Size(0, 20);
            ageResultLabel.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(813, 73);
            label8.Name = "label8";
            label8.Size = new Size(79, 20);
            label8.TabIndex = 11;
            label8.Text = "Pet Details";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(162, 73);
            label9.Name = "label9";
            label9.Size = new Size(149, 20);
            label9.TabIndex = 12;
            label9.Text = "Enter Pet Information";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1223, 360);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(ageResultLabel);
            Controls.Add(typeResultLabel);
            Controls.Add(nameResultLabel);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(petListbox);
            Controls.Add(button1);
            Controls.Add(ageTextbox);
            Controls.Add(label3);
            Controls.Add(typeTextbox);
            Controls.Add(label2);
            Controls.Add(nameTextbox);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox nameTextbox;
        private Label label2;
        private TextBox typeTextbox;
        private Label label3;
        private TextBox ageTextbox;
        private Button button1;
        private ListBox petListbox;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label nameResultLabel;
        private Label typeResultLabel;
        private Label ageResultLabel;
        private Label label8;
        private Label label9;
    }
}
