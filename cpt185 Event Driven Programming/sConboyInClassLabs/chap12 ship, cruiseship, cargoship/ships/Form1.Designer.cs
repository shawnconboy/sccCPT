namespace ships
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
            shipListbox = new ListBox();
            label1 = new Label();
            addShipButton = new Button();
            addCruiserButton = new Button();
            addCargoButton = new Button();
            viewShipsButton = new Button();
            exitButton = new Button();
            label2 = new Label();
            shipNameTextbox = new TextBox();
            label3 = new Label();
            yearBuiltTextbox = new TextBox();
            label4 = new Label();
            cargoCapacityTextbox = new TextBox();
            label5 = new Label();
            occupantCapacityTextbox = new TextBox();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // shipListbox
            // 
            shipListbox.Font = new Font("JetBrains Mono", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            shipListbox.FormattingEnabled = true;
            shipListbox.Location = new Point(26, 112);
            shipListbox.Name = "shipListbox";
            shipListbox.Size = new Size(585, 132);
            shipListbox.TabIndex = 9;
            shipListbox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 39);
            label1.Name = "label1";
            label1.Size = new Size(66, 30);
            label1.TabIndex = 1;
            label1.Text = "Ships";
            // 
            // addShipButton
            // 
            addShipButton.Location = new Point(112, 289);
            addShipButton.Name = "addShipButton";
            addShipButton.Size = new Size(133, 42);
            addShipButton.TabIndex = 4;
            addShipButton.Text = "Add Ship";
            toolTip1.SetToolTip(addShipButton, "press to add ship");
            addShipButton.UseVisualStyleBackColor = true;
            addShipButton.Click += addShipButton_Click;
            // 
            // addCruiserButton
            // 
            addCruiserButton.Location = new Point(258, 289);
            addCruiserButton.Name = "addCruiserButton";
            addCruiserButton.Size = new Size(133, 42);
            addCruiserButton.TabIndex = 5;
            addCruiserButton.Text = "Add Cruiser";
            toolTip1.SetToolTip(addCruiserButton, "press to add cruiser");
            addCruiserButton.UseVisualStyleBackColor = true;
            addCruiserButton.Click += addCruiserButton_Click;
            // 
            // addCargoButton
            // 
            addCargoButton.Location = new Point(404, 289);
            addCargoButton.Name = "addCargoButton";
            addCargoButton.Size = new Size(133, 42);
            addCargoButton.TabIndex = 6;
            addCargoButton.Text = "Add Cargo";
            toolTip1.SetToolTip(addCargoButton, "press to add cargo");
            addCargoButton.UseVisualStyleBackColor = true;
            addCargoButton.Click += addCargoButton_Click;
            // 
            // viewShipsButton
            // 
            viewShipsButton.Location = new Point(183, 349);
            viewShipsButton.Name = "viewShipsButton";
            viewShipsButton.Size = new Size(133, 42);
            viewShipsButton.TabIndex = 7;
            viewShipsButton.Text = "View Ships";
            toolTip1.SetToolTip(viewShipsButton, "press to view ships");
            viewShipsButton.UseVisualStyleBackColor = true;
            viewShipsButton.Click += viewShipsButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(339, 349);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(133, 42);
            exitButton.TabIndex = 8;
            exitButton.Text = "Exit";
            toolTip1.SetToolTip(exitButton, "press to exit");
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(644, 115);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 3;
            label2.Text = "Ship Name";
            // 
            // shipNameTextbox
            // 
            shipNameTextbox.Location = new Point(767, 112);
            shipNameTextbox.Name = "shipNameTextbox";
            shipNameTextbox.Size = new Size(150, 23);
            shipNameTextbox.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(644, 192);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 3;
            label3.Text = "Year Built";
            // 
            // yearBuiltTextbox
            // 
            yearBuiltTextbox.Location = new Point(767, 189);
            yearBuiltTextbox.Name = "yearBuiltTextbox";
            yearBuiltTextbox.Size = new Size(150, 23);
            yearBuiltTextbox.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(644, 269);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 3;
            label4.Text = "Cargo Capacity";
            // 
            // cargoCapacityTextbox
            // 
            cargoCapacityTextbox.Location = new Point(767, 266);
            cargoCapacityTextbox.Name = "cargoCapacityTextbox";
            cargoCapacityTextbox.Size = new Size(150, 23);
            cargoCapacityTextbox.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(644, 346);
            label5.Name = "label5";
            label5.Size = new Size(108, 15);
            label5.TabIndex = 3;
            label5.Text = "Occupant Capacity";
            // 
            // occupantCapacityTextbox
            // 
            occupantCapacityTextbox.Location = new Point(767, 343);
            occupantCapacityTextbox.Name = "occupantCapacityTextbox";
            occupantCapacityTextbox.Size = new Size(150, 23);
            occupantCapacityTextbox.TabIndex = 3;
            // 
            // Form1
            // 
            AcceptButton = viewShipsButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = exitButton;
            ClientSize = new Size(950, 450);
            Controls.Add(occupantCapacityTextbox);
            Controls.Add(label5);
            Controls.Add(cargoCapacityTextbox);
            Controls.Add(label4);
            Controls.Add(yearBuiltTextbox);
            Controls.Add(label3);
            Controls.Add(shipNameTextbox);
            Controls.Add(label2);
            Controls.Add(exitButton);
            Controls.Add(viewShipsButton);
            Controls.Add(addCargoButton);
            Controls.Add(addCruiserButton);
            Controls.Add(addShipButton);
            Controls.Add(label1);
            Controls.Add(shipListbox);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "sConboyShips";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox shipListbox;
        private Label label1;
        private Button addShipButton;
        private Button addCruiserButton;
        private Button addCargoButton;
        private Button viewShipsButton;
        private Button exitButton;
        private Label label2;
        private TextBox shipNameTextbox;
        private Label label3;
        private TextBox yearBuiltTextbox;
        private Label label4;
        private TextBox cargoCapacityTextbox;
        private Label label5;
        private TextBox occupantCapacityTextbox;
        private ToolTip toolTip1;
    }
}
