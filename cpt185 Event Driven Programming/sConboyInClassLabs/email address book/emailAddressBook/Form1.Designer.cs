namespace emailAddressBook
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
            label1 = new Label();
            personListbox = new ListBox();
            toolTip1 = new ToolTip(components);
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(351, 76);
            label1.Name = "label1";
            label1.Size = new Size(98, 30);
            label1.TabIndex = 0;
            label1.Text = "Contacts";
            // 
            // personListbox
            // 
            personListbox.FormattingEnabled = true;
            personListbox.ItemHeight = 15;
            personListbox.Location = new Point(319, 121);
            personListbox.Name = "personListbox";
            personListbox.Size = new Size(162, 199);
            personListbox.TabIndex = 1;
            personListbox.SelectedIndexChanged += personListbox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(313, 373);
            label2.Name = "label2";
            label2.Size = new Size(175, 15);
            label2.TabIndex = 2;
            label2.Text = "Press a contact to see more info";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(personListbox);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "sConboy EmailAddressBook";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox personListbox;
        private ToolTip toolTip1;
        private Label label2;
    }
}
