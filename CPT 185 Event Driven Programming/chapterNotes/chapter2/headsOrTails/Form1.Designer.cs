namespace headsOrTails
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
            headsButton = new Button();
            tailsButton = new Button();
            exitButton = new Button();
            headsImage = new PictureBox();
            tailsImage = new PictureBox();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            randomButton = new Button();
            ((System.ComponentModel.ISupportInitialize)headsImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tailsImage).BeginInit();
            SuspendLayout();
            // 
            // headsButton
            // 
            headsButton.Location = new Point(169, 303);
            headsButton.Name = "headsButton";
            headsButton.Size = new Size(75, 48);
            headsButton.TabIndex = 0;
            headsButton.Text = "Show Heads";
            toolTip1.SetToolTip(headsButton, "Press to show heads");
            headsButton.UseVisualStyleBackColor = true;
            headsButton.Click += headsButton_Click;
            // 
            // tailsButton
            // 
            tailsButton.Location = new Point(254, 303);
            tailsButton.Name = "tailsButton";
            tailsButton.Size = new Size(75, 48);
            tailsButton.TabIndex = 0;
            tailsButton.Text = "Show Tails";
            toolTip1.SetToolTip(tailsButton, "Press to show tails");
            tailsButton.UseVisualStyleBackColor = true;
            tailsButton.Click += tailsButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(338, 303);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 48);
            exitButton.TabIndex = 0;
            exitButton.Text = "Exit";
            toolTip1.SetToolTip(exitButton, "Press to exit");
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // headsImage
            // 
            headsImage.Image = (Image)resources.GetObject("headsImage.Image");
            headsImage.Location = new Point(85, 70);
            headsImage.Name = "headsImage";
            headsImage.Size = new Size(179, 179);
            headsImage.SizeMode = PictureBoxSizeMode.StretchImage;
            headsImage.TabIndex = 1;
            headsImage.TabStop = false;
            toolTip1.SetToolTip(headsImage, "Heads Image");
            headsImage.Visible = false;
            // 
            // tailsImage
            // 
            tailsImage.Image = (Image)resources.GetObject("tailsImage.Image");
            tailsImage.Location = new Point(319, 70);
            tailsImage.Name = "tailsImage";
            tailsImage.Size = new Size(179, 179);
            tailsImage.SizeMode = PictureBoxSizeMode.StretchImage;
            tailsImage.TabIndex = 1;
            tailsImage.TabStop = false;
            toolTip1.SetToolTip(tailsImage, "Tails Image");
            tailsImage.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(169, 9);
            label1.Name = "label1";
            label1.Size = new Size(244, 32);
            label1.TabIndex = 2;
            label1.Text = "Select Heads or tails";
            // 
            // randomButton
            // 
            randomButton.Location = new Point(254, 371);
            randomButton.Name = "randomButton";
            randomButton.Size = new Size(75, 48);
            randomButton.TabIndex = 0;
            randomButton.Text = "Random";
            randomButton.UseVisualStyleBackColor = true;
            randomButton.Click += randomButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = exitButton;
            ClientSize = new Size(582, 450);
            Controls.Add(label1);
            Controls.Add(tailsImage);
            Controls.Add(headsImage);
            Controls.Add(exitButton);
            Controls.Add(tailsButton);
            Controls.Add(randomButton);
            Controls.Add(headsButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Heads or Tails";
            ((System.ComponentModel.ISupportInitialize)headsImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)tailsImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button headsButton;
        private Button tailsButton;
        private Button exitButton;
        private PictureBox headsImage;
        private PictureBox tailsImage;
        private Label label1;
        private ToolTip toolTip1;
        private Button randomButton;
    }
}
