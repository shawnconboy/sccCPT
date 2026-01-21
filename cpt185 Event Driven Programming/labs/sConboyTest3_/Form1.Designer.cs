namespace sConboyTest3_
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
            this.homeButton = new System.Windows.Forms.Button();
            this.membersButton = new System.Windows.Forms.Button();
            this.booksButton = new System.Windows.Forms.Button();
            this.checkoutButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.homeControl1 = new sConboyTest3_.HomeControl();
            this.addBookControl1 = new sConboyTest3_.AddBookControl();
            this.booksControl1 = new sConboyTest3_.BooksControl();
            this.members1 = new sConboyTest3_.Members();
            this.addMember1 = new sConboyTest3_.AddMember();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.Transparent;
            this.homeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.Location = new System.Drawing.Point(73, 36);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(232, 58);
            this.homeButton.TabIndex = 0;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // membersButton
            // 
            this.membersButton.BackColor = System.Drawing.Color.Transparent;
            this.membersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.membersButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membersButton.Location = new System.Drawing.Point(549, 36);
            this.membersButton.Name = "membersButton";
            this.membersButton.Size = new System.Drawing.Size(232, 58);
            this.membersButton.TabIndex = 2;
            this.membersButton.Text = "Members";
            this.membersButton.UseVisualStyleBackColor = false;
            this.membersButton.Click += new System.EventHandler(this.membersButton_Click);
            // 
            // booksButton
            // 
            this.booksButton.BackColor = System.Drawing.Color.Transparent;
            this.booksButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.booksButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksButton.Location = new System.Drawing.Point(311, 36);
            this.booksButton.Name = "booksButton";
            this.booksButton.Size = new System.Drawing.Size(232, 58);
            this.booksButton.TabIndex = 1;
            this.booksButton.Text = "Books";
            this.booksButton.UseVisualStyleBackColor = false;
            this.booksButton.Click += new System.EventHandler(this.booksButton_Click);
            // 
            // checkoutButton
            // 
            this.checkoutButton.BackColor = System.Drawing.Color.Transparent;
            this.checkoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkoutButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutButton.Location = new System.Drawing.Point(787, 36);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(232, 58);
            this.checkoutButton.TabIndex = 3;
            this.checkoutButton.Text = "Checkout";
            this.checkoutButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.checkoutButton);
            this.panel1.Controls.Add(this.booksButton);
            this.panel1.Controls.Add(this.membersButton);
            this.panel1.Controls.Add(this.homeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1092, 138);
            this.panel1.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(1059, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(30, 30);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeButton.TabIndex = 2;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.homeControl1);
            this.panel2.Controls.Add(this.addBookControl1);
            this.panel2.Controls.Add(this.booksControl1);
            this.panel2.Controls.Add(this.members1);
            this.panel2.Controls.Add(this.addMember1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 138);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1092, 500);
            this.panel2.TabIndex = 3;
            // 
            // homeControl1
            // 
            this.homeControl1.BackColor = System.Drawing.Color.Transparent;
            this.homeControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeControl1.Location = new System.Drawing.Point(0, 0);
            this.homeControl1.Name = "homeControl1";
            this.homeControl1.Size = new System.Drawing.Size(1092, 500);
            this.homeControl1.TabIndex = 0;
            // 
            // addBookControl1
            // 
            this.addBookControl1.BackColor = System.Drawing.Color.Transparent;
            this.addBookControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBookControl1.Location = new System.Drawing.Point(0, 0);
            this.addBookControl1.Name = "addBookControl1";
            this.addBookControl1.Size = new System.Drawing.Size(1092, 500);
            this.addBookControl1.TabIndex = 1;
            // 
            // booksControl1
            // 
            this.booksControl1.BackColor = System.Drawing.Color.Transparent;
            this.booksControl1.Location = new System.Drawing.Point(0, 0);
            this.booksControl1.Name = "booksControl1";
            this.booksControl1.Size = new System.Drawing.Size(1092, 500);
            this.booksControl1.TabIndex = 0;
            // 
            // members1
            // 
            this.members1.BackColor = System.Drawing.Color.Transparent;
            this.members1.Location = new System.Drawing.Point(0, 0);
            this.members1.Name = "members1";
            this.members1.Size = new System.Drawing.Size(1092, 500);
            this.members1.TabIndex = 3;
            // 
            // addMember1
            // 
            this.addMember1.BackColor = System.Drawing.Color.Transparent;
            this.addMember1.Location = new System.Drawing.Point(0, 0);
            this.addMember1.Name = "addMember1";
            this.addMember1.Size = new System.Drawing.Size(1092, 500);
            this.addMember1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1092, 638);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button membersButton;
        private System.Windows.Forms.Button booksButton;
        private System.Windows.Forms.Button checkoutButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private BooksControl booksControl1;
        private AddBookControl addBookControl1;
        private HomeControl homeControl1;
        private Members members1;
        private System.Windows.Forms.PictureBox closeButton;
        private AddMember addMember1;
    }
}

