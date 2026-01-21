namespace emailAddressBook_FinalStudyGuide
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
            this.personListbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.shipsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // personListbox
            // 
            this.personListbox.FormattingEnabled = true;
            this.personListbox.Location = new System.Drawing.Point(77, 99);
            this.personListbox.Name = "personListbox";
            this.personListbox.Size = new System.Drawing.Size(120, 95);
            this.personListbox.TabIndex = 0;
            this.personListbox.SelectedIndexChanged += new System.EventHandler(this.personListbox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please click a name";
            // 
            // shipsButton
            // 
            this.shipsButton.Location = new System.Drawing.Point(77, 281);
            this.shipsButton.Name = "shipsButton";
            this.shipsButton.Size = new System.Drawing.Size(133, 48);
            this.shipsButton.TabIndex = 2;
            this.shipsButton.Text = "Go to ships";
            this.shipsButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.shipsButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.personListbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox personListbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button shipsButton;
    }
}

