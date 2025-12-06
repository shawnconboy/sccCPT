namespace sConboyTest3_
{
    partial class BooksControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.booksListbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addBookButton = new System.Windows.Forms.Button();
            this.titleSortButton = new System.Windows.Forms.Button();
            this.deleteSelectedButton = new System.Windows.Forms.Button();
            this.authorSortButton = new System.Windows.Forms.Button();
            this.genreSortButton = new System.Windows.Forms.Button();
            this.isbnSortButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // booksListbox
            // 
            this.booksListbox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksListbox.FormattingEnabled = true;
            this.booksListbox.Location = new System.Drawing.Point(83, 167);
            this.booksListbox.Name = "booksListbox";
            this.booksListbox.Size = new System.Drawing.Size(929, 290);
            this.booksListbox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(520, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Books";
            // 
            // addBookButton
            // 
            this.addBookButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBookButton.Location = new System.Drawing.Point(83, 44);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(118, 38);
            this.addBookButton.TabIndex = 0;
            this.addBookButton.Text = "Add A Book";
            this.addBookButton.UseVisualStyleBackColor = true;
            this.addBookButton.Click += new System.EventHandler(this.addBookButton_Click);
            // 
            // titleSortButton
            // 
            this.titleSortButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.titleSortButton.Location = new System.Drawing.Point(83, 123);
            this.titleSortButton.Name = "titleSortButton";
            this.titleSortButton.Size = new System.Drawing.Size(118, 38);
            this.titleSortButton.TabIndex = 1;
            this.titleSortButton.Text = "Sort By Title";
            this.titleSortButton.UseVisualStyleBackColor = true;
            this.titleSortButton.Click += new System.EventHandler(this.titleSortButton_Click);
            // 
            // deleteSelectedButton
            // 
            this.deleteSelectedButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteSelectedButton.Location = new System.Drawing.Point(891, 123);
            this.deleteSelectedButton.Name = "deleteSelectedButton";
            this.deleteSelectedButton.Size = new System.Drawing.Size(118, 38);
            this.deleteSelectedButton.TabIndex = 5;
            this.deleteSelectedButton.Text = "Delete Selected";
            this.deleteSelectedButton.UseVisualStyleBackColor = true;
            this.deleteSelectedButton.Click += new System.EventHandler(this.deleteSelectedButton_Click);
            // 
            // authorSortButton
            // 
            this.authorSortButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.authorSortButton.Location = new System.Drawing.Point(285, 123);
            this.authorSortButton.Name = "authorSortButton";
            this.authorSortButton.Size = new System.Drawing.Size(118, 38);
            this.authorSortButton.TabIndex = 2;
            this.authorSortButton.Text = "Sort By Author";
            this.authorSortButton.UseVisualStyleBackColor = true;
            this.authorSortButton.Click += new System.EventHandler(this.authorSortButton_Click);
            // 
            // genreSortButton
            // 
            this.genreSortButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.genreSortButton.Location = new System.Drawing.Point(487, 123);
            this.genreSortButton.Name = "genreSortButton";
            this.genreSortButton.Size = new System.Drawing.Size(118, 38);
            this.genreSortButton.TabIndex = 3;
            this.genreSortButton.Text = "Sort By Genre";
            this.genreSortButton.UseVisualStyleBackColor = true;
            this.genreSortButton.Click += new System.EventHandler(this.genreSortButton_Click);
            // 
            // isbnSortButton
            // 
            this.isbnSortButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.isbnSortButton.Location = new System.Drawing.Point(689, 123);
            this.isbnSortButton.Name = "isbnSortButton";
            this.isbnSortButton.Size = new System.Drawing.Size(118, 38);
            this.isbnSortButton.TabIndex = 4;
            this.isbnSortButton.Text = "Sort By ISBN";
            this.isbnSortButton.UseVisualStyleBackColor = true;
            this.isbnSortButton.Click += new System.EventHandler(this.isbnSortButton_Click);
            // 
            // BooksControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.booksListbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteSelectedButton);
            this.Controls.Add(this.isbnSortButton);
            this.Controls.Add(this.genreSortButton);
            this.Controls.Add(this.authorSortButton);
            this.Controls.Add(this.titleSortButton);
            this.Controls.Add(this.addBookButton);
            this.Name = "BooksControl";
            this.Size = new System.Drawing.Size(1092, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox booksListbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.Button titleSortButton;
        private System.Windows.Forms.Button deleteSelectedButton;
        private System.Windows.Forms.Button authorSortButton;
        private System.Windows.Forms.Button genreSortButton;
        private System.Windows.Forms.Button isbnSortButton;
    }
}
