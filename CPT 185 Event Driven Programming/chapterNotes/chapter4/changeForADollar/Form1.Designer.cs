namespace changeForADollar
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
            startPanel = new Panel();
            instructionsButton = new Button();
            exitButton = new Button();
            startButton = new Button();
            label1 = new Label();
            gamePanel = new Panel();
            quarterLabel = new Label();
            dimeLabel = new Label();
            nickelLabel = new Label();
            pennyLabel = new Label();
            quarterImg = new PictureBox();
            dimeImg = new PictureBox();
            nickelImg = new PictureBox();
            pennyImg = new PictureBox();
            label2 = new Label();
            targetTextbox = new TextBox();
            checkButton = new Button();
            startPanel.SuspendLayout();
            gamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)quarterImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dimeImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nickelImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pennyImg).BeginInit();
            SuspendLayout();
            // 
            // startPanel
            // 
            startPanel.Controls.Add(instructionsButton);
            startPanel.Controls.Add(exitButton);
            startPanel.Controls.Add(startButton);
            startPanel.Location = new Point(30, 104);
            startPanel.Name = "startPanel";
            startPanel.Size = new Size(740, 324);
            startPanel.TabIndex = 0;
            // 
            // instructionsButton
            // 
            instructionsButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            instructionsButton.Location = new Point(249, 135);
            instructionsButton.Name = "instructionsButton";
            instructionsButton.Size = new Size(250, 56);
            instructionsButton.TabIndex = 1;
            instructionsButton.Text = "How To Play";
            instructionsButton.UseVisualStyleBackColor = true;
            instructionsButton.Click += instructionsButton_Click;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            exitButton.Location = new Point(249, 239);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(250, 56);
            exitButton.TabIndex = 2;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // startButton
            // 
            startButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            startButton.Location = new Point(249, 29);
            startButton.Name = "startButton";
            startButton.Size = new Size(250, 56);
            startButton.TabIndex = 0;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(302, 42);
            label1.Name = "label1";
            label1.Size = new Size(197, 38);
            label1.TabIndex = 0;
            label1.Text = "Spare Change";
            // 
            // gamePanel
            // 
            gamePanel.Controls.Add(checkButton);
            gamePanel.Controls.Add(quarterLabel);
            gamePanel.Controls.Add(dimeLabel);
            gamePanel.Controls.Add(nickelLabel);
            gamePanel.Controls.Add(pennyLabel);
            gamePanel.Controls.Add(quarterImg);
            gamePanel.Controls.Add(dimeImg);
            gamePanel.Controls.Add(nickelImg);
            gamePanel.Controls.Add(pennyImg);
            gamePanel.Controls.Add(label2);
            gamePanel.Controls.Add(targetTextbox);
            gamePanel.Location = new Point(30, 104);
            gamePanel.Name = "gamePanel";
            gamePanel.Size = new Size(740, 414);
            gamePanel.TabIndex = 3;
            // 
            // quarterLabel
            // 
            quarterLabel.AutoSize = true;
            quarterLabel.Location = new Point(543, 230);
            quarterLabel.Name = "quarterLabel";
            quarterLabel.Size = new Size(65, 20);
            quarterLabel.TabIndex = 3;
            quarterLabel.Text = "Quarters";
            quarterLabel.Click += quarterImg_Click;
            // 
            // dimeLabel
            // 
            dimeLabel.AutoSize = true;
            dimeLabel.Location = new Point(411, 230);
            dimeLabel.Name = "dimeLabel";
            dimeLabel.Size = new Size(51, 20);
            dimeLabel.TabIndex = 3;
            dimeLabel.Text = "Dimes";
            dimeLabel.Click += dimeImg_Click;
            // 
            // nickelLabel
            // 
            nickelLabel.AutoSize = true;
            nickelLabel.Location = new Point(272, 230);
            nickelLabel.Name = "nickelLabel";
            nickelLabel.Size = new Size(56, 20);
            nickelLabel.TabIndex = 3;
            nickelLabel.Text = "Nickels";
            nickelLabel.Click += nickelImg_Click;
            // 
            // pennyLabel
            // 
            pennyLabel.AutoSize = true;
            pennyLabel.Location = new Point(139, 230);
            pennyLabel.Name = "pennyLabel";
            pennyLabel.Size = new Size(58, 20);
            pennyLabel.TabIndex = 3;
            pennyLabel.Text = "Pennies";
            pennyLabel.Click += pennyImg_Click;
            // 
            // quarterImg
            // 
            quarterImg.Image = (Image)resources.GetObject("quarterImg.Image");
            quarterImg.Location = new Point(525, 135);
            quarterImg.Name = "quarterImg";
            quarterImg.Size = new Size(95, 84);
            quarterImg.SizeMode = PictureBoxSizeMode.Zoom;
            quarterImg.TabIndex = 2;
            quarterImg.TabStop = false;
            quarterImg.Click += quarterImg_Click;
            // 
            // dimeImg
            // 
            dimeImg.Image = (Image)resources.GetObject("dimeImg.Image");
            dimeImg.Location = new Point(394, 135);
            dimeImg.Name = "dimeImg";
            dimeImg.Size = new Size(95, 84);
            dimeImg.SizeMode = PictureBoxSizeMode.Zoom;
            dimeImg.TabIndex = 2;
            dimeImg.TabStop = false;
            dimeImg.Click += dimeImg_Click;
            // 
            // nickelImg
            // 
            nickelImg.Image = (Image)resources.GetObject("nickelImg.Image");
            nickelImg.Location = new Point(250, 135);
            nickelImg.Name = "nickelImg";
            nickelImg.Size = new Size(95, 84);
            nickelImg.SizeMode = PictureBoxSizeMode.Zoom;
            nickelImg.TabIndex = 2;
            nickelImg.TabStop = false;
            nickelImg.Click += nickelImg_Click;
            // 
            // pennyImg
            // 
            pennyImg.Image = (Image)resources.GetObject("pennyImg.Image");
            pennyImg.Location = new Point(119, 135);
            pennyImg.Name = "pennyImg";
            pennyImg.Size = new Size(95, 84);
            pennyImg.SizeMode = PictureBoxSizeMode.Zoom;
            pennyImg.TabIndex = 2;
            pennyImg.TabStop = false;
            pennyImg.Click += pennyImg_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(249, 88);
            label2.Name = "label2";
            label2.Size = new Size(233, 20);
            label2.TabIndex = 1;
            label2.Text = "Add what's needed to reach $1.00";
            // 
            // targetTextbox
            // 
            targetTextbox.BackColor = SystemColors.Window;
            targetTextbox.Enabled = false;
            targetTextbox.Location = new Point(327, 29);
            targetTextbox.Name = "targetTextbox";
            targetTextbox.ReadOnly = true;
            targetTextbox.Size = new Size(89, 27);
            targetTextbox.TabIndex = 0;
            targetTextbox.TextAlign = HorizontalAlignment.Center;
            // 
            // checkButton
            // 
            checkButton.Location = new Point(323, 366);
            checkButton.Name = "checkButton";
            checkButton.Size = new Size(94, 29);
            checkButton.TabIndex = 4;
            checkButton.Text = "Check";
            checkButton.UseVisualStyleBackColor = true;
            checkButton.Click += checkButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 548);
            Controls.Add(gamePanel);
            Controls.Add(label1);
            Controls.Add(startPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Spare Change";
            startPanel.ResumeLayout(false);
            gamePanel.ResumeLayout(false);
            gamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)quarterImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)dimeImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)nickelImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)pennyImg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel startPanel;
        private Label label1;
        private Button instructionsButton;
        private Button exitButton;
        private Button startButton;
        private Panel gamePanel;
        private Label quarterLabel;
        private Label dimeLabel;
        private Label nickelLabel;
        private Label pennyLabel;
        private PictureBox quarterImg;
        private PictureBox dimeImg;
        private PictureBox nickelImg;
        private PictureBox pennyImg;
        private Label label2;
        private TextBox targetTextbox;
        private Button checkButton;
    }
}
