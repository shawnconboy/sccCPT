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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            rockPicture = new PictureBox();
            rockLabel = new Label();
            paperPicture = new PictureBox();
            paperLabel = new Label();
            scissorsPicture = new PictureBox();
            scissorsLabel = new Label();
            exitButton = new Button();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)rockPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)paperPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)scissorsPicture).BeginInit();
            SuspendLayout();
            // 
            // rockPicture
            // 
            rockPicture.Image = (Image)resources.GetObject("rockPicture.Image");
            rockPicture.Location = new Point(129, 75);
            rockPicture.Margin = new Padding(3, 2, 3, 2);
            rockPicture.Name = "rockPicture";
            rockPicture.Size = new Size(120, 102);
            rockPicture.SizeMode = PictureBoxSizeMode.Zoom;
            rockPicture.TabIndex = 0;
            rockPicture.TabStop = false;
            toolTip1.SetToolTip(rockPicture, "press for rock");
            rockPicture.Click += rockPicture_Click;
            // 
            // rockLabel
            // 
            rockLabel.AutoSize = true;
            rockLabel.Location = new Point(171, 197);
            rockLabel.Name = "rockLabel";
            rockLabel.Size = new Size(33, 15);
            rockLabel.TabIndex = 0;
            rockLabel.Text = "Rock";
            // 
            // paperPicture
            // 
            paperPicture.Image = (Image)resources.GetObject("paperPicture.Image");
            paperPicture.Location = new Point(290, 75);
            paperPicture.Margin = new Padding(3, 2, 3, 2);
            paperPicture.Name = "paperPicture";
            paperPicture.Size = new Size(120, 102);
            paperPicture.SizeMode = PictureBoxSizeMode.Zoom;
            paperPicture.TabIndex = 0;
            paperPicture.TabStop = false;
            toolTip1.SetToolTip(paperPicture, "press for paper");
            paperPicture.Click += paperPicture_Click;
            // 
            // paperLabel
            // 
            paperLabel.AutoSize = true;
            paperLabel.Location = new Point(326, 197);
            paperLabel.Name = "paperLabel";
            paperLabel.Size = new Size(37, 15);
            paperLabel.TabIndex = 1;
            paperLabel.Text = "Paper";
            // 
            // scissorsPicture
            // 
            scissorsPicture.Image = (Image)resources.GetObject("scissorsPicture.Image");
            scissorsPicture.Location = new Point(430, 75);
            scissorsPicture.Margin = new Padding(3, 2, 3, 2);
            scissorsPicture.Name = "scissorsPicture";
            scissorsPicture.Size = new Size(120, 102);
            scissorsPicture.SizeMode = PictureBoxSizeMode.Zoom;
            scissorsPicture.TabIndex = 0;
            scissorsPicture.TabStop = false;
            toolTip1.SetToolTip(scissorsPicture, "press for scissors");
            scissorsPicture.Click += scissorsPicture_Click;
            // 
            // scissorsLabel
            // 
            scissorsLabel.AutoSize = true;
            scissorsLabel.Location = new Point(469, 197);
            scissorsLabel.Name = "scissorsLabel";
            scissorsLabel.Size = new Size(48, 15);
            scissorsLabel.TabIndex = 2;
            scissorsLabel.Text = "Scissors";
            // 
            // exitButton
            // 
            exitButton.Location = new Point(452, 286);
            exitButton.Margin = new Padding(3, 2, 3, 2);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(82, 22);
            exitButton.TabIndex = 3;
            exitButton.Text = "Exit";
            toolTip1.SetToolTip(exitButton, "Press to exit");
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = exitButton;
            ClientSize = new Size(700, 338);
            Controls.Add(exitButton);
            Controls.Add(scissorsLabel);
            Controls.Add(paperLabel);
            Controls.Add(rockLabel);
            Controls.Add(scissorsPicture);
            Controls.Add(paperPicture);
            Controls.Add(rockPicture);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "sConboyRockPaperScissors";
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
        private ToolTip toolTip1;
    }
}
