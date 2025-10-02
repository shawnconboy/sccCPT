namespace listOfClasses
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
            classNameTextbox = new TextBox();
            addClassButton = new Button();
            clearButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 78);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter Class Name";
            // 
            // classNameTextbox
            // 
            classNameTextbox.Location = new Point(218, 75);
            classNameTextbox.Name = "classNameTextbox";
            classNameTextbox.Size = new Size(100, 23);
            classNameTextbox.TabIndex = 0;
            // 
            // addClassButton
            // 
            addClassButton.Location = new Point(90, 151);
            addClassButton.Name = "addClassButton";
            addClassButton.Size = new Size(75, 23);
            addClassButton.TabIndex = 1;
            addClassButton.Text = "Add Class";
            addClassButton.UseVisualStyleBackColor = true;
            addClassButton.Click += button1_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(171, 151);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 2;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += button2_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(252, 151);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 3;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += button3_Click;
            // 
            // Form1
            // 
            AcceptButton = addClassButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = exitButton;
            ClientSize = new Size(417, 248);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(addClassButton);
            Controls.Add(classNameTextbox);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Class Adder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox classNameTextbox;
        private Button addClassButton;
        private Button clearButton;
        private Button exitButton;
    }
}
