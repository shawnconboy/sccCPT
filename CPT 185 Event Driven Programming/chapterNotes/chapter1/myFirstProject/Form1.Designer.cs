namespace myFirstProject
{
    partial class Form1
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
            this.messageButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.message_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // messageButton
            // 
            this.messageButton.Location = new System.Drawing.Point(159, 175);
            this.messageButton.Name = "messageButton";
            this.messageButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.messageButton.Size = new System.Drawing.Size(145, 49);
            this.messageButton.TabIndex = 0;
            this.messageButton.Text = "Display Message";
            this.messageButton.UseVisualStyleBackColor = true;
            this.messageButton.Click += new System.EventHandler(this.messageButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(159, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Uncle Roger\'s Fried Rice!";
            // 
            // message_label
            // 
            this.message_label.AutoSize = true;
            this.message_label.Location = new System.Drawing.Point(156, 105);
            this.message_label.Name = "message_label";
            this.message_label.Size = new System.Drawing.Size(0, 13);
            this.message_label.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::myFirstProject.Properties.Resources.Screenshot_2023_09_10_230824;
            this.pictureBox1.Location = new System.Drawing.Point(383, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 252);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.message_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.messageButton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My First Program";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button messageButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label message_label;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

