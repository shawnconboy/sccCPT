namespace rockPaperScissors
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
            rockPicture = new PictureBox();
            rockLabel = new Label();
            paperPicture = new PictureBox();
            paperLabel = new Label();
            scissorsPicture = new PictureBox();
            scissorsLabel = new Label();
            exitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)rockPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)paperPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)scissorsPicture).BeginInit();
            SuspendLayout();
            // 
            // rockPicture
            // 
            rockPicture.Image = (Image)resources.GetObject("rockPicture.Image");
            rockPicture.Location = new Point(147, 100);
            rockPicture.Name = "rockPicture";
            rockPicture.Size = new Size(137, 136);
            rockPicture.SizeMode = PictureBoxSizeMode.Zoom;
            rockPicture.TabIndex = 0;
            rockPicture.TabStop = false;
            rockPicture.Click += rockPicture_Click;
            // 
            // rockLabel
            // 
            rockLabel.AutoSize = true;
            rockLabel.Location = new Point(195, 263);
            rockLabel.Name = "rockLabel";
            rockLabel.Size = new Size(41, 20);
            rockLabel.TabIndex = 1;
            rockLabel.Text = "Rock";
            // 
            // paperPicture
            // 
            paperPicture.Image = (Image)resources.GetObject("paperPicture.Image");
            paperPicture.Location = new Point(332, 100);
            paperPicture.Name = "paperPicture";
            paperPicture.Size = new Size(137, 136);
            paperPicture.SizeMode = PictureBoxSizeMode.Zoom;
            paperPicture.TabIndex = 0;
            paperPicture.TabStop = false;
            paperPicture.Click += paperPicture_Click;
            // 
            // paperLabel
            // 
            paperLabel.AutoSize = true;
            paperLabel.Location = new Point(373, 263);
            paperLabel.Name = "paperLabel";
            paperLabel.Size = new Size(46, 20);
            paperLabel.TabIndex = 1;
            paperLabel.Text = "Paper";
            // 
            // scissorsPicture
            // 
            scissorsPicture.Image = (Image)resources.GetObject("scissorsPicture.Image");
            scissorsPicture.Location = new Point(492, 100);
            scissorsPicture.Name = "scissorsPicture";
            scissorsPicture.Size = new Size(137, 136);
            scissorsPicture.SizeMode = PictureBoxSizeMode.Zoom;
            scissorsPicture.TabIndex = 0;
            scissorsPicture.TabStop = false;
            scissorsPicture.Click += scissorsPicture_Click;
            // 
            // scissorsLabel
            // 
            scissorsLabel.AutoSize = true;
            scissorsLabel.Location = new Point(536, 263);
            scissorsLabel.Name = "scissorsLabel";
            scissorsLabel.Size = new Size(60, 20);
            scissorsLabel.TabIndex = 1;
            scissorsLabel.Text = "Scissors";
            // 
            // exitButton
            // 
            exitButton.Location = new Point(516, 382);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(94, 29);
            exitButton.TabIndex = 2;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exitButton);
            Controls.Add(scissorsLabel);
            Controls.Add(paperLabel);
            Controls.Add(rockLabel);
            Controls.Add(scissorsPicture);
            Controls.Add(paperPicture);
            Controls.Add(rockPicture);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)rockPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)paperPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)scissorsPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox rockPicture;
        private Label rockLabel;
        private PictureBox paperPicture;
        private Label paperLabel;
        private PictureBox scissorsPicture;
        private Label scissorsLabel;
        private Button exitButton;
    }
}
