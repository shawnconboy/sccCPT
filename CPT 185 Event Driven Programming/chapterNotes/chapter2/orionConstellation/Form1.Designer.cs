namespace orionConstellation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            showNameButton = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(633, 609);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(315, 218);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 1;
            label1.Text = "Stardew Valley";
            label1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(407, 547);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 1;
            label2.Text = "Warzone";
            label2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(138, 273);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 1;
            label3.Text = "COD";
            label3.Visible = false;
            // 
            // showNameButton
            // 
            showNameButton.Location = new Point(75, 648);
            showNameButton.Name = "showNameButton";
            showNameButton.Size = new Size(105, 23);
            showNameButton.TabIndex = 2;
            showNameButton.Text = "Show Names";
            showNameButton.UseVisualStyleBackColor = true;
            showNameButton.Click += showNameButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(393, 648);
            button1.Name = "button1";
            button1.Size = new Size(105, 23);
            button1.TabIndex = 2;
            button1.Text = "Hide Names";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 709);
            Controls.Add(button1);
            Controls.Add(showNameButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Orion Constellation";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button showNameButton;
        private Button button1;
    }
}
