namespace sConboyTest3Resubmission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.addBookPicture = new System.Windows.Forms.PictureBox();
            this.addMemberPicture = new System.Windows.Forms.PictureBox();
            this.checkOutPicture = new System.Windows.Forms.PictureBox();
            this.returnPicture = new System.Windows.Forms.PictureBox();
            this.addBookLabel = new System.Windows.Forms.Label();
            this.addMemberLabel = new System.Windows.Forms.Label();
            this.returnLabel = new System.Windows.Forms.Label();
            this.checkOutLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.closePicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.addBookPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addMemberPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkOutPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // addBookPicture
            // 
            this.addBookPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBookPicture.Image = ((System.Drawing.Image)(resources.GetObject("addBookPicture.Image")));
            this.addBookPicture.Location = new System.Drawing.Point(19, 150);
            this.addBookPicture.Name = "addBookPicture";
            this.addBookPicture.Size = new System.Drawing.Size(150, 150);
            this.addBookPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addBookPicture.TabIndex = 0;
            this.addBookPicture.TabStop = false;
            this.addBookPicture.Click += new System.EventHandler(this.addBookPicture_Click);
            // 
            // addMemberPicture
            // 
            this.addMemberPicture.Image = ((System.Drawing.Image)(resources.GetObject("addMemberPicture.Image")));
            this.addMemberPicture.Location = new System.Drawing.Point(223, 150);
            this.addMemberPicture.Name = "addMemberPicture";
            this.addMemberPicture.Size = new System.Drawing.Size(150, 150);
            this.addMemberPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addMemberPicture.TabIndex = 0;
            this.addMemberPicture.TabStop = false;
            this.addMemberPicture.Click += new System.EventHandler(this.addMemberPicture_Click);
            // 
            // checkOutPicture
            // 
            this.checkOutPicture.Image = ((System.Drawing.Image)(resources.GetObject("checkOutPicture.Image")));
            this.checkOutPicture.Location = new System.Drawing.Point(427, 150);
            this.checkOutPicture.Name = "checkOutPicture";
            this.checkOutPicture.Size = new System.Drawing.Size(150, 150);
            this.checkOutPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.checkOutPicture.TabIndex = 0;
            this.checkOutPicture.TabStop = false;
            // 
            // returnPicture
            // 
            this.returnPicture.Image = ((System.Drawing.Image)(resources.GetObject("returnPicture.Image")));
            this.returnPicture.Location = new System.Drawing.Point(631, 150);
            this.returnPicture.Name = "returnPicture";
            this.returnPicture.Size = new System.Drawing.Size(150, 150);
            this.returnPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.returnPicture.TabIndex = 0;
            this.returnPicture.TabStop = false;
            // 
            // addBookLabel
            // 
            this.addBookLabel.AutoSize = true;
            this.addBookLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBookLabel.Location = new System.Drawing.Point(16, 335);
            this.addBookLabel.Name = "addBookLabel";
            this.addBookLabel.Size = new System.Drawing.Size(68, 13);
            this.addBookLabel.TabIndex = 1;
            this.addBookLabel.Text = "Add A Book";
            this.addBookLabel.Click += new System.EventHandler(this.addBookPicture_Click);
            // 
            // addMemberLabel
            // 
            this.addMemberLabel.AutoSize = true;
            this.addMemberLabel.Location = new System.Drawing.Point(220, 335);
            this.addMemberLabel.Name = "addMemberLabel";
            this.addMemberLabel.Size = new System.Drawing.Size(83, 13);
            this.addMemberLabel.TabIndex = 1;
            this.addMemberLabel.Text = "Add A Member";
            this.addMemberLabel.Click += new System.EventHandler(this.addMemberPicture_Click);
            // 
            // returnLabel
            // 
            this.returnLabel.AutoSize = true;
            this.returnLabel.Location = new System.Drawing.Point(628, 335);
            this.returnLabel.Name = "returnLabel";
            this.returnLabel.Size = new System.Drawing.Size(42, 13);
            this.returnLabel.TabIndex = 1;
            this.returnLabel.Text = "Return";
            // 
            // checkOutLabel
            // 
            this.checkOutLabel.AutoSize = true;
            this.checkOutLabel.Location = new System.Drawing.Point(424, 335);
            this.checkOutLabel.Name = "checkOutLabel";
            this.checkOutLabel.Size = new System.Drawing.Size(61, 13);
            this.checkOutLabel.TabIndex = 1;
            this.checkOutLabel.Text = "Check Out";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(308, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Library Manager";
            // 
            // closePicture
            // 
            this.closePicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closePicture.Image = ((System.Drawing.Image)(resources.GetObject("closePicture.Image")));
            this.closePicture.InitialImage = null;
            this.closePicture.Location = new System.Drawing.Point(759, 12);
            this.closePicture.Name = "closePicture";
            this.closePicture.Size = new System.Drawing.Size(29, 24);
            this.closePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closePicture.TabIndex = 3;
            this.closePicture.TabStop = false;
            this.closePicture.Click += new System.EventHandler(this.closePicture_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closePicture);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkOutLabel);
            this.Controls.Add(this.returnLabel);
            this.Controls.Add(this.addMemberLabel);
            this.Controls.Add(this.addBookLabel);
            this.Controls.Add(this.returnPicture);
            this.Controls.Add(this.checkOutPicture);
            this.Controls.Add(this.addMemberPicture);
            this.Controls.Add(this.addBookPicture);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.addBookPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addMemberPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkOutPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox addBookPicture;
        private System.Windows.Forms.PictureBox addMemberPicture;
        private System.Windows.Forms.PictureBox checkOutPicture;
        private System.Windows.Forms.PictureBox returnPicture;
        private System.Windows.Forms.Label addBookLabel;
        private System.Windows.Forms.Label addMemberLabel;
        private System.Windows.Forms.Label returnLabel;
        private System.Windows.Forms.Label checkOutLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox closePicture;
    }
}

