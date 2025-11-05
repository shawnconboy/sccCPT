namespace sConboyLab9Dorm
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
            dormGroupbox = new GroupBox();
            suitesButton = new RadioButton();
            farthingButton = new RadioButton();
            pikeButton = new RadioButton();
            allenButton = new RadioButton();
            mealGroupbox = new GroupBox();
            unlimitedMealOption = new RadioButton();
            mealOption2Button = new RadioButton();
            mealOption1Buton = new RadioButton();
            displayTotalButton = new Button();
            clearButton = new Button();
            exitButton = new Button();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            dormGroupbox.SuspendLayout();
            mealGroupbox.SuspendLayout();
            SuspendLayout();
            // 
            // dormGroupbox
            // 
            dormGroupbox.Controls.Add(suitesButton);
            dormGroupbox.Controls.Add(farthingButton);
            dormGroupbox.Controls.Add(pikeButton);
            dormGroupbox.Controls.Add(allenButton);
            dormGroupbox.Location = new Point(154, 99);
            dormGroupbox.Margin = new Padding(2, 2, 2, 2);
            dormGroupbox.Name = "dormGroupbox";
            dormGroupbox.Padding = new Padding(2, 2, 2, 2);
            dormGroupbox.Size = new Size(240, 162);
            dormGroupbox.TabIndex = 0;
            dormGroupbox.TabStop = false;
            dormGroupbox.Text = "Dormitory";
            // 
            // suitesButton
            // 
            suitesButton.AutoSize = true;
            suitesButton.Location = new Point(18, 119);
            suitesButton.Margin = new Padding(2, 2, 2, 2);
            suitesButton.Name = "suitesButton";
            suitesButton.Size = new Size(137, 24);
            suitesButton.TabIndex = 3;
            suitesButton.TabStop = true;
            suitesButton.Text = "University Suites";
            suitesButton.UseVisualStyleBackColor = true;
            // 
            // farthingButton
            // 
            farthingButton.AutoSize = true;
            farthingButton.Location = new Point(18, 91);
            farthingButton.Margin = new Padding(2, 2, 2, 2);
            farthingButton.Name = "farthingButton";
            farthingButton.Size = new Size(114, 24);
            farthingButton.TabIndex = 2;
            farthingButton.TabStop = true;
            farthingButton.Text = "Farthing Hall";
            farthingButton.UseVisualStyleBackColor = true;
            // 
            // pikeButton
            // 
            pikeButton.AutoSize = true;
            pikeButton.Location = new Point(18, 63);
            pikeButton.Margin = new Padding(2, 2, 2, 2);
            pikeButton.Name = "pikeButton";
            pikeButton.Size = new Size(88, 24);
            pikeButton.TabIndex = 1;
            pikeButton.TabStop = true;
            pikeButton.Text = "Pike Hall";
            pikeButton.UseVisualStyleBackColor = true;
            // 
            // allenButton
            // 
            allenButton.AutoSize = true;
            allenButton.Location = new Point(18, 35);
            allenButton.Margin = new Padding(2, 2, 2, 2);
            allenButton.Name = "allenButton";
            allenButton.Size = new Size(95, 24);
            allenButton.TabIndex = 0;
            allenButton.TabStop = true;
            allenButton.Text = "Allen Hall";
            allenButton.UseVisualStyleBackColor = true;
            // 
            // mealGroupbox
            // 
            mealGroupbox.Controls.Add(unlimitedMealOption);
            mealGroupbox.Controls.Add(mealOption2Button);
            mealGroupbox.Controls.Add(mealOption1Buton);
            mealGroupbox.Location = new Point(492, 99);
            mealGroupbox.Margin = new Padding(2, 2, 2, 2);
            mealGroupbox.Name = "mealGroupbox";
            mealGroupbox.Padding = new Padding(2, 2, 2, 2);
            mealGroupbox.Size = new Size(240, 162);
            mealGroupbox.TabIndex = 1;
            mealGroupbox.TabStop = false;
            mealGroupbox.Text = "Meal Plans";
            // 
            // unlimitedMealOption
            // 
            unlimitedMealOption.AutoSize = true;
            unlimitedMealOption.Location = new Point(24, 119);
            unlimitedMealOption.Margin = new Padding(2, 2, 2, 2);
            unlimitedMealOption.Name = "unlimitedMealOption";
            unlimitedMealOption.Size = new Size(138, 24);
            unlimitedMealOption.TabIndex = 2;
            unlimitedMealOption.TabStop = true;
            unlimitedMealOption.Text = "Unlimited Meals";
            unlimitedMealOption.UseVisualStyleBackColor = true;
            // 
            // mealOption2Button
            // 
            mealOption2Button.AutoSize = true;
            mealOption2Button.Location = new Point(24, 78);
            mealOption2Button.Margin = new Padding(2, 2, 2, 2);
            mealOption2Button.Name = "mealOption2Button";
            mealOption2Button.Size = new Size(153, 24);
            mealOption2Button.TabIndex = 1;
            mealOption2Button.TabStop = true;
            mealOption2Button.Text = "14 Meals Per Week";
            mealOption2Button.UseVisualStyleBackColor = true;
            // 
            // mealOption1Buton
            // 
            mealOption1Buton.AutoSize = true;
            mealOption1Buton.Location = new Point(24, 35);
            mealOption1Buton.Margin = new Padding(2, 2, 2, 2);
            mealOption1Buton.Name = "mealOption1Buton";
            mealOption1Buton.Size = new Size(145, 24);
            mealOption1Buton.TabIndex = 0;
            mealOption1Buton.TabStop = true;
            mealOption1Buton.Text = "7 Meals Per Week";
            mealOption1Buton.UseVisualStyleBackColor = true;
            // 
            // displayTotalButton
            // 
            displayTotalButton.Location = new Point(154, 318);
            displayTotalButton.Margin = new Padding(2, 2, 2, 2);
            displayTotalButton.Name = "displayTotalButton";
            displayTotalButton.Size = new Size(106, 27);
            displayTotalButton.TabIndex = 2;
            displayTotalButton.Text = "&Display Total";
            toolTip1.SetToolTip(displayTotalButton, "Press to display total");
            displayTotalButton.UseVisualStyleBackColor = true;
            displayTotalButton.Click += displayTotalButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(362, 318);
            clearButton.Margin = new Padding(2, 2, 2, 2);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(106, 27);
            clearButton.TabIndex = 3;
            clearButton.Text = "&Clear";
            toolTip1.SetToolTip(clearButton, "Press to clear");
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(606, 318);
            exitButton.Margin = new Padding(2, 2, 2, 2);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(106, 27);
            exitButton.TabIndex = 4;
            exitButton.Text = "&Exit";
            toolTip1.SetToolTip(exitButton, "Press to exit");
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(338, 33);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(221, 20);
            label1.TabIndex = 3;
            label1.Text = "Student Dorm and Meal Planner";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 418);
            Controls.Add(label1);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(displayTotalButton);
            Controls.Add(mealGroupbox);
            Controls.Add(dormGroupbox);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            dormGroupbox.ResumeLayout(false);
            dormGroupbox.PerformLayout();
            mealGroupbox.ResumeLayout(false);
            mealGroupbox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox dormGroupbox;
        private RadioButton suitesButton;
        private RadioButton farthingButton;
        private RadioButton pikeButton;
        private RadioButton allenButton;
        private GroupBox mealGroupbox;
        private RadioButton mealOption2Button;
        private RadioButton mealOption1Buton;
        private RadioButton unlimitedMealOption;
        private Button displayTotalButton;
        private Button clearButton;
        private Button exitButton;
        private Label label1;
        private ToolTip toolTip1;
    }
}
