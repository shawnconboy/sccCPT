namespace randomNumberFileReaderWriter
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
            readButton = new Button();
            writeButton = new Button();
            exitButton = new Button();
            panel1 = new Panel();
            read1 = new Read();
            write1 = new Write();
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // readButton
            // 
            readButton.Location = new Point(133, 36);
            readButton.Name = "readButton";
            readButton.Size = new Size(75, 23);
            readButton.TabIndex = 0;
            readButton.Text = "Read";
            toolTip1.SetToolTip(readButton, "Press to read files");
            readButton.UseVisualStyleBackColor = true;
            readButton.Click += readButton_Click;
            // 
            // writeButton
            // 
            writeButton.Location = new Point(363, 36);
            writeButton.Name = "writeButton";
            writeButton.Size = new Size(75, 23);
            writeButton.TabIndex = 1;
            writeButton.Text = "Write";
            toolTip1.SetToolTip(writeButton, "Press to write files");
            writeButton.UseVisualStyleBackColor = true;
            writeButton.Click += writeButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(593, 36);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 2;
            exitButton.Text = "Exit";
            toolTip1.SetToolTip(exitButton, "Press to exit");
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(read1);
            panel1.Controls.Add(write1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 98);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 352);
            panel1.TabIndex = 3;
            // 
            // read1
            // 
            read1.Location = new Point(0, 0);
            read1.Name = "read1";
            read1.Size = new Size(800, 352);
            read1.TabIndex = 0;
            // 
            // write1
            // 
            write1.Location = new Point(0, -2);
            write1.Name = "write1";
            write1.Size = new Size(800, 352);
            write1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(exitButton);
            Controls.Add(writeButton);
            Controls.Add(readButton);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "sConboyRead/WriteNumbers";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button readButton;
        private Button writeButton;
        private Button exitButton;
        private Panel panel1;
        private Read read1;
        private Write write1;
        private ToolTip toolTip1;
    }
}
