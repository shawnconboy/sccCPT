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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            urlTextbox = new TextBox();
            searchButton = new Button();
            historyButton = new Button();
            searchPicturebox = new PictureBox();
            historyListbox = new ListBox();
            backPicturebox = new PictureBox();
            clearButton = new Button();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchPicturebox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backPicturebox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(322, 66);
            pictureBox1.Margin = new Padding(5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(656, 198);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // urlTextbox
            // 
            urlTextbox.Location = new Point(369, 331);
            urlTextbox.Margin = new Padding(5);
            urlTextbox.Name = "urlTextbox";
            urlTextbox.PlaceholderText = "Search or type a URL";
            urlTextbox.Size = new Size(563, 39);
            urlTextbox.TabIndex = 0;
            // 
            // searchButton
            // 
            searchButton.Cursor = Cursors.Hand;
            searchButton.Location = new Point(322, 426);
            searchButton.Margin = new Padding(5);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(214, 46);
            searchButton.TabIndex = 1;
            searchButton.Text = "&Google Search";
            toolTip1.SetToolTip(searchButton, "Press to search url");
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchPicturebox_Click;
            // 
            // historyButton
            // 
            historyButton.Cursor = Cursors.Hand;
            historyButton.Location = new Point(764, 426);
            historyButton.Margin = new Padding(5);
            historyButton.Name = "historyButton";
            historyButton.Size = new Size(214, 46);
            historyButton.TabIndex = 2;
            historyButton.Text = "See &History";
            toolTip1.SetToolTip(historyButton, "Press to see site history");
            historyButton.UseVisualStyleBackColor = true;
            historyButton.Click += historyButton_Click;
            // 
            // searchPicturebox
            // 
            searchPicturebox.Cursor = Cursors.Hand;
            searchPicturebox.Image = (Image)resources.GetObject("searchPicturebox.Image");
            searchPicturebox.Location = new Point(322, 334);
            searchPicturebox.Margin = new Padding(5);
            searchPicturebox.Name = "searchPicturebox";
            searchPicturebox.Size = new Size(37, 37);
            searchPicturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            searchPicturebox.TabIndex = 4;
            searchPicturebox.TabStop = false;
            searchPicturebox.Click += searchPicturebox_Click;
            // 
            // historyListbox
            // 
            historyListbox.FormattingEnabled = true;
            historyListbox.Location = new Point(369, 506);
            historyListbox.Margin = new Padding(5);
            historyListbox.Name = "historyListbox";
            historyListbox.Size = new Size(563, 100);
            historyListbox.TabIndex = 3;
            historyListbox.Visible = false;
            // 
            // backPicturebox
            // 
            backPicturebox.Cursor = Cursors.Hand;
            backPicturebox.Image = (Image)resources.GetObject("backPicturebox.Image");
            backPicturebox.Location = new Point(941, 334);
            backPicturebox.Margin = new Padding(5);
            backPicturebox.Name = "backPicturebox";
            backPicturebox.Size = new Size(37, 37);
            backPicturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            backPicturebox.TabIndex = 6;
            backPicturebox.TabStop = false;
            backPicturebox.Click += backPicturebox_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(563, 426);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(179, 46);
            clearButton.TabIndex = 7;
            clearButton.Text = "&Clear History";
            toolTip1.SetToolTip(clearButton, "Press to clear history");
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // Form1
            // 
            AcceptButton = searchButton;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 682);
            Controls.Add(clearButton);
            Controls.Add(backPicturebox);
            Controls.Add(historyListbox);
            Controls.Add(searchPicturebox);
            Controls.Add(historyButton);
            Controls.Add(searchButton);
            Controls.Add(urlTextbox);
            Controls.Add(pictureBox1);
            Margin = new Padding(5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "sConboy 244 Stack Lab";
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
        private Button clearButton;
        private ToolTip toolTip1;
    }
}
