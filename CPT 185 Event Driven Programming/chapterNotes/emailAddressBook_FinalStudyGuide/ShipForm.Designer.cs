namespace emailAddressBook_FinalStudyGuide
{
    partial class ShipForm
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
            this.addShipButton = new System.Windows.Forms.Button();
            this.addCruiseButton = new System.Windows.Forms.Button();
            this.addCargoButton = new System.Windows.Forms.Button();
            this.viewAllButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.capacityTextbox = new System.Windows.Forms.TextBox();
            this.yearBuiltTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tonnageTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addShipButton
            // 
            this.addShipButton.Location = new System.Drawing.Point(90, 220);
            this.addShipButton.Name = "addShipButton";
            this.addShipButton.Size = new System.Drawing.Size(75, 23);
            this.addShipButton.TabIndex = 0;
            this.addShipButton.Text = "Add Ship";
            this.addShipButton.UseVisualStyleBackColor = true;
            this.addShipButton.Click += new System.EventHandler(this.addShipButton_Click);
            // 
            // addCruiseButton
            // 
            this.addCruiseButton.Location = new System.Drawing.Point(201, 220);
            this.addCruiseButton.Name = "addCruiseButton";
            this.addCruiseButton.Size = new System.Drawing.Size(75, 23);
            this.addCruiseButton.TabIndex = 0;
            this.addCruiseButton.Text = "Add  Cruise Ship";
            this.addCruiseButton.UseVisualStyleBackColor = true;
            this.addCruiseButton.Click += new System.EventHandler(this.addCruiseButton_Click);
            // 
            // addCargoButton
            // 
            this.addCargoButton.Location = new System.Drawing.Point(307, 220);
            this.addCargoButton.Name = "addCargoButton";
            this.addCargoButton.Size = new System.Drawing.Size(75, 23);
            this.addCargoButton.TabIndex = 0;
            this.addCargoButton.Text = "Add Cargo Ship";
            this.addCargoButton.UseVisualStyleBackColor = true;
            this.addCargoButton.Click += new System.EventHandler(this.addCargoButton_Click);
            // 
            // viewAllButton
            // 
            this.viewAllButton.Location = new System.Drawing.Point(162, 302);
            this.viewAllButton.Name = "viewAllButton";
            this.viewAllButton.Size = new System.Drawing.Size(75, 23);
            this.viewAllButton.TabIndex = 0;
            this.viewAllButton.Text = "View Ships";
            this.viewAllButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(256, 302);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(489, 220);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(143, 20);
            this.nameTextbox.TabIndex = 1;
            // 
            // capacityTextbox
            // 
            this.capacityTextbox.Location = new System.Drawing.Point(489, 263);
            this.capacityTextbox.Name = "capacityTextbox";
            this.capacityTextbox.Size = new System.Drawing.Size(143, 20);
            this.capacityTextbox.TabIndex = 1;
            // 
            // yearBuiltTextbox
            // 
            this.yearBuiltTextbox.Location = new System.Drawing.Point(489, 318);
            this.yearBuiltTextbox.Name = "yearBuiltTextbox";
            this.yearBuiltTextbox.Size = new System.Drawing.Size(143, 20);
            this.yearBuiltTextbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(409, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Capacity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(409, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Year Built";
            // 
            // tonnageTextbox
            // 
            this.tonnageTextbox.Location = new System.Drawing.Point(489, 360);
            this.tonnageTextbox.Name = "tonnageTextbox";
            this.tonnageTextbox.Size = new System.Drawing.Size(143, 20);
            this.tonnageTextbox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(409, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tonnage";
            // 
            // ShipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tonnageTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yearBuiltTextbox);
            this.Controls.Add(this.capacityTextbox);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.viewAllButton);
            this.Controls.Add(this.addCargoButton);
            this.Controls.Add(this.addCruiseButton);
            this.Controls.Add(this.addShipButton);
            this.Name = "ShipForm";
            this.Text = "ShipForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addShipButton;
        private System.Windows.Forms.Button addCruiseButton;
        private System.Windows.Forms.Button addCargoButton;
        private System.Windows.Forms.Button viewAllButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.TextBox capacityTextbox;
        private System.Windows.Forms.TextBox yearBuiltTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tonnageTextbox;
        private System.Windows.Forms.Label label4;
    }
}