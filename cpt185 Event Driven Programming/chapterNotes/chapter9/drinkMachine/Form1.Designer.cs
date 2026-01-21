namespace drinkMachine
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            colaCostLabel = new Label();
            colaInventory = new Label();
            label2 = new Label();
            label1 = new Label();
            exitButton = new Button();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            rootBeerCostLabel = new Label();
            rootBeerInventory = new Label();
            label6 = new Label();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            spriteCostLabel = new Label();
            spriteInventory = new Label();
            label9 = new Label();
            panel4 = new Panel();
            pictureBox4 = new PictureBox();
            monsterCostLabel = new Label();
            monsterInventory = new Label();
            label12 = new Label();
            totalLabel = new Label();
            clearButton = new Button();
            confirmButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(colaCostLabel);
            panel1.Controls.Add(colaInventory);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(60, 96);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 150);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(16, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // colaCostLabel
            // 
            colaCostLabel.AutoSize = true;
            colaCostLabel.Location = new Point(150, 26);
            colaCostLabel.Name = "colaCostLabel";
            colaCostLabel.Size = new Size(56, 25);
            colaCostLabel.TabIndex = 2;
            colaCostLabel.Text = "$1.00";
            // 
            // colaInventory
            // 
            colaInventory.Location = new Point(150, 102);
            colaInventory.Name = "colaInventory";
            colaInventory.Size = new Size(88, 38);
            colaInventory.TabIndex = 1;
            colaInventory.Text = "10";
            colaInventory.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(150, 63);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 0;
            label2.Text = "Drinks Left :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(304, 30);
            label1.Name = "label1";
            label1.Size = new Size(192, 38);
            label1.TabIndex = 1;
            label1.Text = "Select A Drink";
            // 
            // exitButton
            // 
            exitButton.Location = new Point(484, 582);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(112, 34);
            exitButton.TabIndex = 2;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(rootBeerCostLabel);
            panel2.Controls.Add(rootBeerInventory);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(440, 96);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 150);
            panel2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(16, 15);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(111, 122);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // rootBeerCostLabel
            // 
            rootBeerCostLabel.AutoSize = true;
            rootBeerCostLabel.Location = new Point(150, 26);
            rootBeerCostLabel.Name = "rootBeerCostLabel";
            rootBeerCostLabel.Size = new Size(56, 25);
            rootBeerCostLabel.TabIndex = 2;
            rootBeerCostLabel.Text = "$1.00";
            // 
            // rootBeerInventory
            // 
            rootBeerInventory.Location = new Point(150, 102);
            rootBeerInventory.Name = "rootBeerInventory";
            rootBeerInventory.Size = new Size(88, 38);
            rootBeerInventory.TabIndex = 1;
            rootBeerInventory.Text = "10";
            rootBeerInventory.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(150, 63);
            label6.Name = "label6";
            label6.Size = new Size(105, 25);
            label6.TabIndex = 0;
            label6.Text = "Drinks Left :";
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(spriteCostLabel);
            panel3.Controls.Add(spriteInventory);
            panel3.Controls.Add(label9);
            panel3.Location = new Point(60, 285);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 150);
            panel3.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(16, 15);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(111, 122);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // spriteCostLabel
            // 
            spriteCostLabel.AutoSize = true;
            spriteCostLabel.Location = new Point(150, 26);
            spriteCostLabel.Name = "spriteCostLabel";
            spriteCostLabel.Size = new Size(56, 25);
            spriteCostLabel.TabIndex = 2;
            spriteCostLabel.Text = "$1.00";
            // 
            // spriteInventory
            // 
            spriteInventory.Location = new Point(150, 102);
            spriteInventory.Name = "spriteInventory";
            spriteInventory.Size = new Size(88, 38);
            spriteInventory.TabIndex = 1;
            spriteInventory.Text = "10";
            spriteInventory.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(150, 63);
            label9.Name = "label9";
            label9.Size = new Size(105, 25);
            label9.TabIndex = 0;
            label9.Text = "Drinks Left :";
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(monsterCostLabel);
            panel4.Controls.Add(monsterInventory);
            panel4.Controls.Add(label12);
            panel4.Location = new Point(440, 285);
            panel4.Name = "panel4";
            panel4.Size = new Size(300, 150);
            panel4.TabIndex = 0;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(16, 15);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(111, 122);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // monsterCostLabel
            // 
            monsterCostLabel.AutoSize = true;
            monsterCostLabel.Location = new Point(150, 26);
            monsterCostLabel.Name = "monsterCostLabel";
            monsterCostLabel.Size = new Size(56, 25);
            monsterCostLabel.TabIndex = 2;
            monsterCostLabel.Text = "$1.00";
            // 
            // monsterInventory
            // 
            monsterInventory.Location = new Point(150, 102);
            monsterInventory.Name = "monsterInventory";
            monsterInventory.Size = new Size(88, 38);
            monsterInventory.TabIndex = 1;
            monsterInventory.Text = "10";
            monsterInventory.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(150, 63);
            label12.Name = "label12";
            label12.Size = new Size(105, 25);
            label12.TabIndex = 0;
            label12.Text = "Drinks Left :";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new Point(347, 506);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(107, 25);
            totalLabel.TabIndex = 3;
            totalLabel.Text = "Total : $0.00";
            // 
            // clearButton
            // 
            clearButton.Location = new Point(344, 582);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(112, 34);
            clearButton.TabIndex = 4;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // confirmButton
            // 
            confirmButton.Location = new Point(202, 582);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(112, 34);
            confirmButton.TabIndex = 5;
            confirmButton.Text = "Confirm";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += confirmButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 688);
            Controls.Add(confirmButton);
            Controls.Add(clearButton);
            Controls.Add(totalLabel);
            Controls.Add(exitButton);
            Controls.Add(label1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Drink Machine";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label colaInventory;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label colaCostLabel;
        private Button exitButton;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label rootBeerCostLabel;
        private Label rootBeerInventory;
        private Label label6;
        private Panel panel3;
        private PictureBox pictureBox3;
        private Label spriteCostLabel;
        private Label spriteInventory;
        private Label label9;
        private Panel panel4;
        private PictureBox pictureBox4;
        private Label monsterCostLabel;
        private Label monsterInventory;
        private Label label12;
        private Label totalLabel;
        private Button clearButton;
        private Button confirmButton;
    }
}
