namespace emailAddressBook
{
    partial class Details
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
            label1 = new Label();
            nameTextbox = new TextBox();
            label2 = new Label();
            emailTextbox = new TextBox();
            label3 = new Label();
            phoneTextbox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(272, 136);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // nameTextbox
            // 
            nameTextbox.Location = new Point(374, 133);
            nameTextbox.Name = "nameTextbox";
            nameTextbox.Size = new Size(155, 23);
            nameTextbox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(272, 200);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 0;
            label2.Text = "Email";
            // 
            // emailTextbox
            // 
            emailTextbox.Location = new Point(374, 197);
            emailTextbox.Name = "emailTextbox";
            emailTextbox.Size = new Size(155, 23);
            emailTextbox.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(272, 264);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 0;
            label3.Text = "Phone";
            // 
            // phoneTextbox
            // 
            phoneTextbox.Location = new Point(374, 261);
            phoneTextbox.Name = "phoneTextbox";
            phoneTextbox.Size = new Size(155, 23);
            phoneTextbox.TabIndex = 1;
            // 
            // Details
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(phoneTextbox);
            Controls.Add(label3);
            Controls.Add(emailTextbox);
            Controls.Add(label2);
            Controls.Add(nameTextbox);
            Controls.Add(label1);
            Name = "Details";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Details";
            Load += Details_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox nameTextbox;
        private Label label2;
        private TextBox emailTextbox;
        private Label label3;
        private TextBox phoneTextbox;
    }
}