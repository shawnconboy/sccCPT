namespace randomNumberFileReaderWriter
{
    partial class Write
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
            label1 = new Label();
            numbersTextbox = new TextBox();
            createFileButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(342, 84);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 0;
            label1.Text = "Number of Numbers";
            // 
            // numbersTextbox
            // 
            numbersTextbox.Location = new Point(350, 161);
            numbersTextbox.Name = "numbersTextbox";
            numbersTextbox.Size = new Size(100, 23);
            numbersTextbox.TabIndex = 1;
            // 
            // createFileButton
            // 
            createFileButton.Location = new Point(363, 246);
            createFileButton.Name = "createFileButton";
            createFileButton.Size = new Size(75, 23);
            createFileButton.TabIndex = 2;
            createFileButton.Text = "Create File";
            createFileButton.UseVisualStyleBackColor = true;
            createFileButton.Click += createFileButton_Click;
            // 
            // Write
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(createFileButton);
            Controls.Add(numbersTextbox);
            Controls.Add(label1);
            Name = "Write";
            Size = new Size(800, 352);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox numbersTextbox;
        private Button createFileButton;
    }
}
