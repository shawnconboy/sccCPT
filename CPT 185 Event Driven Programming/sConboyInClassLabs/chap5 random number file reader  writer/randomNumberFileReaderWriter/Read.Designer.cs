namespace randomNumberFileReaderWriter
{
    partial class Read
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
            selectFileButton = new Button();
            readNumberListbox = new ListBox();
            openFileDialog = new FolderBrowserDialog();
            totalNumsTextbox = new TextBox();
            sumOfNumsTextbox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // selectFileButton
            // 
            selectFileButton.Location = new Point(170, 26);
            selectFileButton.Name = "selectFileButton";
            selectFileButton.Size = new Size(113, 23);
            selectFileButton.TabIndex = 0;
            selectFileButton.Text = "Select A File";
            selectFileButton.UseVisualStyleBackColor = true;
            selectFileButton.Click += selectFileButton_Click;
            // 
            // readNumberListbox
            // 
            readNumberListbox.FormattingEnabled = true;
            readNumberListbox.ItemHeight = 15;
            readNumberListbox.Location = new Point(170, 80);
            readNumberListbox.Name = "readNumberListbox";
            readNumberListbox.Size = new Size(120, 199);
            readNumberListbox.TabIndex = 1;
            // 
            // totalNumsTextbox
            // 
            totalNumsTextbox.Location = new Point(530, 94);
            totalNumsTextbox.Name = "totalNumsTextbox";
            totalNumsTextbox.Size = new Size(100, 23);
            totalNumsTextbox.TabIndex = 2;
            // 
            // sumOfNumsTextbox
            // 
            sumOfNumsTextbox.Location = new Point(530, 162);
            sumOfNumsTextbox.Name = "sumOfNumsTextbox";
            sumOfNumsTextbox.Size = new Size(100, 23);
            sumOfNumsTextbox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(389, 97);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 3;
            label1.Text = "Total Numbers in File";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(389, 165);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 3;
            label2.Text = "Sum Of All Numbers";
            // 
            // Read
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(sumOfNumsTextbox);
            Controls.Add(totalNumsTextbox);
            Controls.Add(readNumberListbox);
            Controls.Add(selectFileButton);
            Name = "Read";
            Size = new Size(800, 352);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button selectFileButton;
        private ListBox readNumberListbox;
        private FolderBrowserDialog openFileDialog;
        private TextBox totalNumsTextbox;
        private TextBox sumOfNumsTextbox;
        private Label label1;
        private Label label2;
    }
}
