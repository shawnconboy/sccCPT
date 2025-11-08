namespace slotMachine
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            spinButton = new Button();
            exitButton = new Button();
            label1 = new Label();
            fruitImageList = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(136, 113);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 183);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(325, 113);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(150, 183);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(511, 113);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(150, 183);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // spinButton
            // 
            spinButton.Location = new Point(245, 357);
            spinButton.Name = "spinButton";
            spinButton.Size = new Size(112, 34);
            spinButton.TabIndex = 1;
            spinButton.Text = "Spin";
            spinButton.UseVisualStyleBackColor = true;
            spinButton.Click += spinButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(439, 357);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(112, 34);
            exitButton.TabIndex = 2;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(347, 34);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 3;
            label1.Text = "Spin To Win";
            // 
            // fruitImageList
            // 
            fruitImageList.ColorDepth = ColorDepth.Depth32Bit;
            fruitImageList.ImageStream = (ImageListStreamer)resources.GetObject("fruitImageList.ImageStream");
            fruitImageList.TransparentColor = Color.Transparent;
            fruitImageList.Images.SetKeyName(0, "Apple.bmp");
            fruitImageList.Images.SetKeyName(1, "Banana.bmp");
            fruitImageList.Images.SetKeyName(2, "Cherries.bmp");
            fruitImageList.Images.SetKeyName(3, "Grapes.bmp");
            fruitImageList.Images.SetKeyName(4, "Lemon.bmp");
            fruitImageList.Images.SetKeyName(5, "Lime.bmp");
            fruitImageList.Images.SetKeyName(6, "Orange.bmp");
            fruitImageList.Images.SetKeyName(7, "Pear.bmp");
            fruitImageList.Images.SetKeyName(8, "Strawberry.bmp");
            fruitImageList.Images.SetKeyName(9, "Watermelon.bmp");
            // 
            // Form1
            // 
            AcceptButton = spinButton;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = exitButton;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(exitButton);
            Controls.Add(spinButton);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Spin To Win";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button spinButton;
        private Button exitButton;
        private Label label1;
        private ImageList fruitImageList;
    }
}
