namespace sConboyStacksLab
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
            pictureBox1 = new PictureBox();
            urlTextbox = new TextBox();
            searchButton = new Button();
            historyButton = new Button();
            searchPicturebox = new PictureBox();
            historyListbox = new ListBox();
            backPicturebox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchPicturebox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backPicturebox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(198, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(404, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // urlTextbox
            // 
            urlTextbox.Location = new Point(227, 207);
            urlTextbox.Name = "urlTextbox";
            urlTextbox.PlaceholderText = "Search or type a URL";
            urlTextbox.Size = new Size(348, 27);
            urlTextbox.TabIndex = 0;
            // 
            // searchButton
            // 
            searchButton.Cursor = Cursors.Hand;
            searchButton.Location = new Point(198, 266);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(132, 29);
            searchButton.TabIndex = 1;
            searchButton.Text = "Google Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchPicturebox_Click;
            // 
            // historyButton
            // 
            historyButton.Cursor = Cursors.Hand;
            historyButton.Location = new Point(470, 266);
            historyButton.Name = "historyButton";
            historyButton.Size = new Size(132, 29);
            historyButton.TabIndex = 2;
            historyButton.Text = "See History";
            historyButton.UseVisualStyleBackColor = true;
            historyButton.Click += historyButton_Click;
            // 
            // searchPicturebox
            // 
            searchPicturebox.Cursor = Cursors.Hand;
            searchPicturebox.Image = (Image)resources.GetObject("searchPicturebox.Image");
            searchPicturebox.Location = new Point(198, 209);
            searchPicturebox.Name = "searchPicturebox";
            searchPicturebox.Size = new Size(23, 23);
            searchPicturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            searchPicturebox.TabIndex = 4;
            searchPicturebox.TabStop = false;
            searchPicturebox.Click += searchPicturebox_Click;
            // 
            // historyListbox
            // 
            historyListbox.FormattingEnabled = true;
            historyListbox.Location = new Point(227, 316);
            historyListbox.Name = "historyListbox";
            historyListbox.Size = new Size(348, 64);
            historyListbox.TabIndex = 3;
            historyListbox.Visible = false;
            // 
            // backPicturebox
            // 
            backPicturebox.Cursor = Cursors.Hand;
            backPicturebox.Image = (Image)resources.GetObject("backPicturebox.Image");
            backPicturebox.Location = new Point(579, 209);
            backPicturebox.Name = "backPicturebox";
            backPicturebox.Size = new Size(23, 23);
            backPicturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            backPicturebox.TabIndex = 6;
            backPicturebox.TabStop = false;
            backPicturebox.Click += backPicturebox_Click;
            // 
            // Form1
            // 
            AcceptButton = searchButton;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 426);
            Controls.Add(backPicturebox);
            Controls.Add(historyListbox);
            Controls.Add(searchPicturebox);
            Controls.Add(historyButton);
            Controls.Add(searchButton);
            Controls.Add(urlTextbox);
            Controls.Add(pictureBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Google";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchPicturebox).EndInit();
            ((System.ComponentModel.ISupportInitialize)backPicturebox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox urlTextbox;
        private Button searchButton;
        private Button historyButton;
        private PictureBox searchPicturebox;
        private ListBox historyListbox;
        private PictureBox backPicturebox;
    }
}
