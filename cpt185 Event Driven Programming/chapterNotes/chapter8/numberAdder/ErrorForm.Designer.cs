namespace numberAdder
{
    partial class ErrorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            showButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // showButton
            // 
            showButton.Location = new Point(171, 205);
            showButton.Name = "showButton";
            showButton.Size = new Size(150, 46);
            showButton.TabIndex = 0;
            showButton.Text = "Click Me.";
            showButton.UseVisualStyleBackColor = true;
            showButton.Click += showButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(185, 104);
            label1.Name = "label1";
            label1.Size = new Size(298, 32);
            label1.TabIndex = 1;
            label1.Text = "Welcome to my error form";
            // 
            // ErrorForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(showButton);
            Name = "ErrorForm";
            Text = "ErrorForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button showButton;
        public Label label1;
    }
}