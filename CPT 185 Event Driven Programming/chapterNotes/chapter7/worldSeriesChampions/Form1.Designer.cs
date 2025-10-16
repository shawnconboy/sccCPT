namespace worldSeriesChampions
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
            teamsListbox = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            teamNameLabel = new Label();
            championshipsWonLabel = new Label();
            saveButton = new Button();
            SuspendLayout();
            // 
            // teamsListbox
            // 
            teamsListbox.FormattingEnabled = true;
            teamsListbox.Location = new Point(64, 173);
            teamsListbox.Margin = new Padding(3, 4, 3, 4);
            teamsListbox.Name = "teamsListbox";
            teamsListbox.Size = new Size(137, 364);
            teamsListbox.TabIndex = 0;
            teamsListbox.SelectedIndexChanged += teamsListbox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 131);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 1;
            label1.Text = "MLB Teams";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(125, 40);
            label2.Name = "label2";
            label2.Size = new Size(247, 40);
            label2.TabIndex = 1;
            label2.Text = "Click a team name to see how many\r\n times they've won a championship.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(277, 173);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 2;
            label3.Text = "Team Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(277, 276);
            label4.Name = "label4";
            label4.Size = new Size(144, 20);
            label4.TabIndex = 2;
            label4.Text = "Championships Won";
            // 
            // teamNameLabel
            // 
            teamNameLabel.BorderStyle = BorderStyle.FixedSingle;
            teamNameLabel.Location = new Point(277, 207);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(164, 33);
            teamNameLabel.TabIndex = 2;
            teamNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // championshipsWonLabel
            // 
            championshipsWonLabel.BorderStyle = BorderStyle.FixedSingle;
            championshipsWonLabel.Location = new Point(277, 309);
            championshipsWonLabel.Name = "championshipsWonLabel";
            championshipsWonLabel.Size = new Size(81, 33);
            championshipsWonLabel.TabIndex = 2;
            championshipsWonLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(277, 403);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(94, 29);
            saveButton.TabIndex = 3;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 600);
            Controls.Add(saveButton);
            Controls.Add(label4);
            Controls.Add(championshipsWonLabel);
            Controls.Add(teamNameLabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(teamsListbox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox teamsListbox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label teamNameLabel;
        private Label championshipsWonLabel;
        private Button saveButton;
    }
}
