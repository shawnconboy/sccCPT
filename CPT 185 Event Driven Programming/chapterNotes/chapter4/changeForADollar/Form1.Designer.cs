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
            penniesSelectedLabel = new Label();
            checkButton = new Button();
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
            nickelsSelectedLabel = new Label();
            dimesSelectedLabel = new Label();
            quartersSelectedLabel = new Label();
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
            startPanel.Location = new Point(26, 78);
            startPanel.Margin = new Padding(3, 2, 3, 2);
            startPanel.Name = "startPanel";
            startPanel.Size = new Size(648, 243);
            startPanel.TabIndex = 0;
            // 
            // instructionsButton
            // 
            instructionsButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            instructionsButton.Location = new Point(218, 101);
            instructionsButton.Margin = new Padding(3, 2, 3, 2);
            instructionsButton.Name = "instructionsButton";
            instructionsButton.Size = new Size(219, 42);
            instructionsButton.TabIndex = 1;
            instructionsButton.Text = "How To Play";
            instructionsButton.UseVisualStyleBackColor = true;
            instructionsButton.Click += instructionsButton_Click;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            exitButton.Location = new Point(218, 179);
            exitButton.Margin = new Padding(3, 2, 3, 2);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(219, 42);
            exitButton.TabIndex = 2;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // startButton
            // 
            startButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            startButton.Location = new Point(218, 22);
            startButton.Margin = new Padding(3, 2, 3, 2);
            startButton.Name = "startButton";
            startButton.Size = new Size(219, 42);
            startButton.TabIndex = 0;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(264, 32);
            label1.Name = "label1";
            label1.Size = new Size(156, 30);
            label1.TabIndex = 0;
            label1.Text = "Spare Change";
            // 
            // gamePanel
            // 
            gamePanel.Controls.Add(quartersSelectedLabel);
            gamePanel.Controls.Add(dimesSelectedLabel);
            gamePanel.Controls.Add(nickelsSelectedLabel);
            gamePanel.Controls.Add(penniesSelectedLabel);
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
            gamePanel.Location = new Point(26, 78);
            gamePanel.Margin = new Padding(3, 2, 3, 2);
            gamePanel.Name = "gamePanel";
            gamePanel.Size = new Size(648, 374);
            gamePanel.TabIndex = 3;
            // 
            // penniesSelectedLabel
            // 
            penniesSelectedLabel.AutoSize = true;
            penniesSelectedLabel.Location = new Point(245, 223);
            penniesSelectedLabel.Name = "penniesSelectedLabel";
            penniesSelectedLabel.Size = new Size(54, 15);
            penniesSelectedLabel.TabIndex = 5;
            penniesSelectedLabel.Text = "Pennies :";
            // 
            // checkButton
            // 
            checkButton.Location = new Point(282, 317);
            checkButton.Margin = new Padding(3, 2, 3, 2);
            checkButton.Name = "checkButton";
            checkButton.Size = new Size(82, 22);
            checkButton.TabIndex = 4;
            checkButton.Text = "Check";
            checkButton.UseVisualStyleBackColor = true;
            checkButton.Click += checkButton_Click;
            // 
            // quarterLabel
            // 
            quarterLabel.AutoSize = true;
            quarterLabel.Location = new Point(475, 172);
            quarterLabel.Name = "quarterLabel";
            quarterLabel.Size = new Size(52, 15);
            quarterLabel.TabIndex = 3;
            quarterLabel.Text = "Quarters";
            quarterLabel.Click += quarterImg_Click;
            // 
            // dimeLabel
            // 
            dimeLabel.AutoSize = true;
            dimeLabel.Location = new Point(360, 172);
            dimeLabel.Name = "dimeLabel";
            dimeLabel.Size = new Size(40, 15);
            dimeLabel.TabIndex = 3;
            dimeLabel.Text = "Dimes";
            dimeLabel.Click += dimeImg_Click;
            // 
            // nickelLabel
            // 
            nickelLabel.AutoSize = true;
            nickelLabel.Location = new Point(238, 172);
            nickelLabel.Name = "nickelLabel";
            nickelLabel.Size = new Size(45, 15);
            nickelLabel.TabIndex = 3;
            nickelLabel.Text = "Nickels";
            nickelLabel.Click += nickelImg_Click;
            // 
            // pennyLabel
            // 
            pennyLabel.AutoSize = true;
            pennyLabel.Location = new Point(122, 172);
            pennyLabel.Name = "pennyLabel";
            pennyLabel.Size = new Size(48, 15);
            pennyLabel.TabIndex = 3;
            pennyLabel.Text = "Pennies";
            pennyLabel.Click += pennyImg_Click;
            // 
            // quarterImg
            // 
            quarterImg.Image = (Image)resources.GetObject("quarterImg.Image");
            quarterImg.Location = new Point(459, 101);
            quarterImg.Margin = new Padding(3, 2, 3, 2);
            quarterImg.Name = "quarterImg";
            quarterImg.Size = new Size(83, 63);
            quarterImg.SizeMode = PictureBoxSizeMode.Zoom;
            quarterImg.TabIndex = 2;
            quarterImg.TabStop = false;
            quarterImg.Click += quarterImg_Click;
            // 
            // dimeImg
            // 
            dimeImg.Image = (Image)resources.GetObject("dimeImg.Image");
            dimeImg.Location = new Point(345, 101);
            dimeImg.Margin = new Padding(3, 2, 3, 2);
            dimeImg.Name = "dimeImg";
            dimeImg.Size = new Size(83, 63);
            dimeImg.SizeMode = PictureBoxSizeMode.Zoom;
            dimeImg.TabIndex = 2;
            dimeImg.TabStop = false;
            dimeImg.Click += dimeImg_Click;
            // 
            // nickelImg
            // 
            nickelImg.Image = (Image)resources.GetObject("nickelImg.Image");
            nickelImg.Location = new Point(219, 101);
            nickelImg.Margin = new Padding(3, 2, 3, 2);
            nickelImg.Name = "nickelImg";
            nickelImg.Size = new Size(83, 63);
            nickelImg.SizeMode = PictureBoxSizeMode.Zoom;
            nickelImg.TabIndex = 2;
            nickelImg.TabStop = false;
            nickelImg.Click += nickelImg_Click;
            // 
            // pennyImg
            // 
            pennyImg.Image = (Image)resources.GetObject("pennyImg.Image");
            pennyImg.Location = new Point(104, 101);
            pennyImg.Margin = new Padding(3, 2, 3, 2);
            pennyImg.Name = "pennyImg";
            pennyImg.Size = new Size(83, 63);
            pennyImg.SizeMode = PictureBoxSizeMode.Zoom;
            pennyImg.TabIndex = 2;
            pennyImg.TabStop = false;
            pennyImg.Click += pennyImg_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(218, 66);
            label2.Name = "label2";
            label2.Size = new Size(184, 15);
            label2.TabIndex = 1;
            label2.Text = "Add what's needed to reach $1.00";
            // 
            // targetTextbox
            // 
            targetTextbox.BackColor = SystemColors.Window;
            targetTextbox.Enabled = false;
            targetTextbox.Location = new Point(286, 22);
            targetTextbox.Margin = new Padding(3, 2, 3, 2);
            targetTextbox.Name = "targetTextbox";
            targetTextbox.ReadOnly = true;
            targetTextbox.Size = new Size(78, 23);
            targetTextbox.TabIndex = 0;
            targetTextbox.TextAlign = HorizontalAlignment.Center;
            // 
            // nickelsSelectedLabel
            // 
            nickelsSelectedLabel.AutoSize = true;
            nickelsSelectedLabel.Location = new Point(245, 238);
            nickelsSelectedLabel.Name = "nickelsSelectedLabel";
            nickelsSelectedLabel.Size = new Size(51, 15);
            nickelsSelectedLabel.TabIndex = 5;
            nickelsSelectedLabel.Text = "Nickels :";
            // 
            // dimesSelectedLabel
            // 
            dimesSelectedLabel.AutoSize = true;
            dimesSelectedLabel.Location = new Point(245, 253);
            dimesSelectedLabel.Name = "dimesSelectedLabel";
            dimesSelectedLabel.Size = new Size(46, 15);
            dimesSelectedLabel.TabIndex = 5;
            dimesSelectedLabel.Text = "Dimes :";
            // 
            // quartersSelectedLabel
            // 
            quartersSelectedLabel.AutoSize = true;
            quartersSelectedLabel.Location = new Point(245, 268);
            quartersSelectedLabel.Name = "quartersSelectedLabel";
            quartersSelectedLabel.Size = new Size(58, 15);
            quartersSelectedLabel.TabIndex = 5;
            quartersSelectedLabel.Text = "Quarters :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 472);
            Controls.Add(gamePanel);
            Controls.Add(label1);
            Controls.Add(startPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
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
        private Label penniesSelectedLabel;
        private Label quartersSelectedLabel;
        private Label dimesSelectedLabel;
        private Label nickelsSelectedLabel;
    }
}
