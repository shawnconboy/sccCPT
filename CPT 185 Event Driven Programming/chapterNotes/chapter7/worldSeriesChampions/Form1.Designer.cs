﻿namespace worldSeriesChampions
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
            SuspendLayout();
            // 
            // teamsListbox
            // 
            teamsListbox.FormattingEnabled = true;
            teamsListbox.ItemHeight = 15;
            teamsListbox.Location = new Point(56, 130);
            teamsListbox.Name = "teamsListbox";
            teamsListbox.Size = new Size(120, 274);
            teamsListbox.TabIndex = 0;
            teamsListbox.SelectedIndexChanged += teamsListbox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 98);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 1;
            label1.Text = "MLB Teams";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 30);
            label2.Name = "label2";
            label2.Size = new Size(198, 30);
            label2.TabIndex = 1;
            label2.Text = "Click a team name to see how many\r\n times they've won a championship.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(242, 130);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 2;
            label3.Text = "Team Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(242, 207);
            label4.Name = "label4";
            label4.Size = new Size(118, 15);
            label4.TabIndex = 2;
            label4.Text = "Championships Won";
            // 
            // teamNameLabel
            // 
            teamNameLabel.BorderStyle = BorderStyle.FixedSingle;
            teamNameLabel.Location = new Point(242, 155);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(144, 25);
            teamNameLabel.TabIndex = 2;
            teamNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // championshipsWonLabel
            // 
            championshipsWonLabel.BorderStyle = BorderStyle.FixedSingle;
            championshipsWonLabel.Location = new Point(242, 232);
            championshipsWonLabel.Name = "championshipsWonLabel";
            championshipsWonLabel.Size = new Size(71, 25);
            championshipsWonLabel.TabIndex = 2;
            championshipsWonLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 450);
            Controls.Add(label4);
            Controls.Add(championshipsWonLabel);
            Controls.Add(teamNameLabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(teamsListbox);
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
    }
}
