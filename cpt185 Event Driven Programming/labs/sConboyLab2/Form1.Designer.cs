namespace sConboyLab2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            cardNameLabel = new Label();
            clearButton = new Button();
            exitButton = new Button();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(314, 72);
            label1.Name = "label1";
            label1.Size = new Size(172, 15);
            label1.TabIndex = 0;
            label1.Text = "Click A Card To See It's Name";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(109, 148);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 168);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(229, 148);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 168);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(591, 148);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(100, 168);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(350, 148);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 168);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(471, 148);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 168);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // cardNameLabel
            // 
            cardNameLabel.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            cardNameLabel.Location = new Point(269, 386);
            cardNameLabel.Name = "cardNameLabel";
            cardNameLabel.Size = new Size(262, 51);
            cardNameLabel.TabIndex = 2;
            cardNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // clearButton
            // 
            clearButton.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            clearButton.Location = new Point(285, 472);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 0;
            clearButton.Text = "&Clear";
            toolTip1.SetToolTip(clearButton, "Press to clear card label");
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += button1_Click;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            exitButton.Location = new Point(441, 472);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 1;
            exitButton.Text = "&Exit";
            toolTip1.SetToolTip(exitButton, "Press to close application");
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += button2_Click;
            // 
            // Form1
            // 
            AcceptButton = clearButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            CancelButton = exitButton;
            ClientSize = new Size(800, 571);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(cardNameLabel);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "sConboy Lab2 Card Identifier";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label cardNameLabel;
        private Button clearButton;
        private Button exitButton;
        private ToolTip toolTip1;
    }
}
