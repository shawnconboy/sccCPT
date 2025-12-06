namespace sConboyTest3_
{
    partial class Members
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
            this.membersListbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.nameSortButton = new System.Windows.Forms.Button();
            this.deleteMemberButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // membersListbox
            // 
            this.membersListbox.FormattingEnabled = true;
            this.membersListbox.Location = new System.Drawing.Point(83, 167);
            this.membersListbox.Name = "membersListbox";
            this.membersListbox.Size = new System.Drawing.Size(929, 290);
            this.membersListbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(520, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "Members";
            // 
            // addMemberButton
            // 
            this.addMemberButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addMemberButton.Location = new System.Drawing.Point(83, 44);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(118, 38);
            this.addMemberButton.TabIndex = 0;
            this.addMemberButton.Text = "Add A Member";
            this.addMemberButton.UseVisualStyleBackColor = true;
            this.addMemberButton.Click += new System.EventHandler(this.addMemberButton_Click);
            // 
            // nameSortButton
            // 
            this.nameSortButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nameSortButton.Location = new System.Drawing.Point(83, 123);
            this.nameSortButton.Name = "nameSortButton";
            this.nameSortButton.Size = new System.Drawing.Size(118, 38);
            this.nameSortButton.TabIndex = 1;
            this.nameSortButton.Text = "Sort By Name";
            this.nameSortButton.UseMnemonic = false;
            this.nameSortButton.UseVisualStyleBackColor = true;
            this.nameSortButton.Click += new System.EventHandler(this.nameSortButton_Click);
            // 
            // deleteMemberButton
            // 
            this.deleteMemberButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteMemberButton.Location = new System.Drawing.Point(894, 123);
            this.deleteMemberButton.Name = "deleteMemberButton";
            this.deleteMemberButton.Size = new System.Drawing.Size(118, 38);
            this.deleteMemberButton.TabIndex = 2;
            this.deleteMemberButton.Text = "Delete Member";
            this.deleteMemberButton.UseMnemonic = false;
            this.deleteMemberButton.UseVisualStyleBackColor = true;
            this.deleteMemberButton.Click += new System.EventHandler(this.deleteMemberButton_Click);
            // 
            // Members
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.membersListbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteMemberButton);
            this.Controls.Add(this.nameSortButton);
            this.Controls.Add(this.addMemberButton);
            this.Name = "Members";
            this.Size = new System.Drawing.Size(1092, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox membersListbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.Button nameSortButton;
        private System.Windows.Forms.Button deleteMemberButton;
    }
}
