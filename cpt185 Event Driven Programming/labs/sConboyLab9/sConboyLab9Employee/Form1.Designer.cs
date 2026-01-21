namespace sConboyLab9Employee
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
            employeeListbox = new ListBox();
            label1 = new Label();
            clearButton = new Button();
            exitButton = new Button();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            SuspendLayout();
            // 
            // employeeListbox
            // 
            employeeListbox.FormattingEnabled = true;
            employeeListbox.ItemHeight = 25;
            employeeListbox.Location = new Point(53, 157);
            employeeListbox.Name = "employeeListbox";
            employeeListbox.Size = new Size(694, 204);
            employeeListbox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 89);
            label1.Name = "label1";
            label1.Size = new Size(189, 25);
            label1.TabIndex = 1;
            label1.Text = "Employee Information";
            // 
            // clearButton
            // 
            clearButton.Location = new Point(216, 383);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(112, 34);
            clearButton.TabIndex = 1;
            clearButton.Text = "Clear";
            toolTip1.SetToolTip(clearButton, "Press to clear listbox");
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(412, 383);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(112, 34);
            exitButton.TabIndex = 2;
            exitButton.Text = "Exit";
            toolTip1.SetToolTip(exitButton, "Press to exit form");
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AcceptButton = clearButton;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = exitButton;
            ClientSize = new Size(800, 450);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(label1);
            Controls.Add(employeeListbox);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "sConboyLab9 Employee Class";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox employeeListbox;
        private Label label1;
        private Button clearButton;
        private Button exitButton;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
    }
}
