namespace retailItem
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
            itemsListbox = new ListBox();
            showItemsButton = new Button();
            label1 = new Label();
            descriptionTextbox = new TextBox();
            label2 = new Label();
            priceTextbox = new TextBox();
            label3 = new Label();
            onHandTextbox = new TextBox();
            addItemButton = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // itemsListbox
            // 
            itemsListbox.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            itemsListbox.FormattingEnabled = true;
            itemsListbox.ItemHeight = 14;
            itemsListbox.Location = new Point(101, 59);
            itemsListbox.Name = "itemsListbox";
            itemsListbox.Size = new Size(538, 144);
            itemsListbox.TabIndex = 0;
            // 
            // showItemsButton
            // 
            showItemsButton.Location = new Point(101, 257);
            showItemsButton.Name = "showItemsButton";
            showItemsButton.Size = new Size(96, 23);
            showItemsButton.TabIndex = 4;
            showItemsButton.Text = "Show Items";
            toolTip1.SetToolTip(showItemsButton, "Press to show items");
            showItemsButton.UseVisualStyleBackColor = true;
            showItemsButton.Click += showItemsButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(456, 265);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 2;
            label1.Text = "Description";
            // 
            // descriptionTextbox
            // 
            descriptionTextbox.Location = new Point(539, 262);
            descriptionTextbox.Name = "descriptionTextbox";
            descriptionTextbox.Size = new Size(100, 23);
            descriptionTextbox.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(456, 294);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 2;
            label2.Text = "Price";
            // 
            // priceTextbox
            // 
            priceTextbox.Location = new Point(539, 291);
            priceTextbox.Name = "priceTextbox";
            priceTextbox.Size = new Size(100, 23);
            priceTextbox.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(456, 323);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 2;
            label3.Text = "On Hand";
            // 
            // onHandTextbox
            // 
            onHandTextbox.Location = new Point(539, 320);
            onHandTextbox.Name = "onHandTextbox";
            onHandTextbox.Size = new Size(100, 23);
            onHandTextbox.TabIndex = 2;
            // 
            // addItemButton
            // 
            addItemButton.Location = new Point(519, 364);
            addItemButton.Name = "addItemButton";
            addItemButton.Size = new Size(75, 23);
            addItemButton.TabIndex = 3;
            addItemButton.Text = "Add Item";
            toolTip1.SetToolTip(addItemButton, "Press to add an item");
            addItemButton.UseVisualStyleBackColor = true;
            addItemButton.Click += addItemButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(104, 27);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 4;
            label4.Text = "Item";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(321, 27);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 4;
            label5.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(485, 27);
            label6.Name = "label6";
            label6.Size = new Size(26, 15);
            label6.TabIndex = 4;
            label6.Text = "Qty";
            // 
            // Form1
            // 
            AcceptButton = showItemsButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(onHandTextbox);
            Controls.Add(label3);
            Controls.Add(priceTextbox);
            Controls.Add(label2);
            Controls.Add(descriptionTextbox);
            Controls.Add(label1);
            Controls.Add(addItemButton);
            Controls.Add(showItemsButton);
            Controls.Add(itemsListbox);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "sConboyRetailItem";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox itemsListbox;
        private Button showItemsButton;
        private Label label1;
        private TextBox descriptionTextbox;
        private Label label2;
        private TextBox priceTextbox;
        private Label label3;
        private TextBox onHandTextbox;
        private Button addItemButton;
        private Label label4;
        private Label label5;
        private Label label6;
        private ToolTip toolTip1;
    }
}
