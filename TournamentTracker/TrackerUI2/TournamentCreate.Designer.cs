﻿
namespace TrackerUI
{
    partial class TournamentCreate
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbTournamentName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEntryFee = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTeams = new System.Windows.Forms.ComboBox();
            this.llCreateTeam = new System.Windows.Forms.LinkLabel();
            this.bAddTeam = new System.Windows.Forms.Button();
            this.bCreatePrize = new System.Windows.Forms.Button();
            this.lbTeams = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbPrizes = new System.Windows.Forms.ListBox();
            this.bDeletePlayers = new System.Windows.Forms.Button();
            this.bCreateTournament = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bDeletePrizes = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tournament Name :";
            // 
            // tbTournamentName
            // 
            this.tbTournamentName.Location = new System.Drawing.Point(20, 63);
            this.tbTournamentName.Name = "tbTournamentName";
            this.tbTournamentName.Size = new System.Drawing.Size(218, 23);
            this.tbTournamentName.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label2.Location = new System.Drawing.Point(22, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Entry Fee";
            // 
            // tbEntryFee
            // 
            this.tbEntryFee.Location = new System.Drawing.Point(128, 100);
            this.tbEntryFee.Name = "tbEntryFee";
            this.tbEntryFee.Size = new System.Drawing.Size(110, 23);
            this.tbEntryFee.TabIndex = 16;
            this.tbEntryFee.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label3.Location = new System.Drawing.Point(30, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Select Team  /";
            // 
            // cbTeams
            // 
            this.cbTeams.FormattingEnabled = true;
            this.cbTeams.Location = new System.Drawing.Point(20, 166);
            this.cbTeams.Name = "cbTeams";
            this.cbTeams.Size = new System.Drawing.Size(218, 25);
            this.cbTeams.TabIndex = 18;
            // 
            // llCreateTeam
            // 
            this.llCreateTeam.AutoSize = true;
            this.llCreateTeam.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.llCreateTeam.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.llCreateTeam.Location = new System.Drawing.Point(137, 139);
            this.llCreateTeam.Name = "llCreateTeam";
            this.llCreateTeam.Size = new System.Drawing.Size(92, 17);
            this.llCreateTeam.TabIndex = 19;
            this.llCreateTeam.TabStop = true;
            this.llCreateTeam.Text = "Create Team";
            this.llCreateTeam.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llCreateTeam_LinkClicked);
            // 
            // bAddTeam
            // 
            this.bAddTeam.Location = new System.Drawing.Point(20, 224);
            this.bAddTeam.Name = "bAddTeam";
            this.bAddTeam.Size = new System.Drawing.Size(106, 42);
            this.bAddTeam.TabIndex = 20;
            this.bAddTeam.Text = "Add Team";
            this.bAddTeam.UseVisualStyleBackColor = true;
            this.bAddTeam.Click += new System.EventHandler(this.bAddTeam_Click);
            // 
            // bCreatePrize
            // 
            this.bCreatePrize.Location = new System.Drawing.Point(132, 224);
            this.bCreatePrize.Name = "bCreatePrize";
            this.bCreatePrize.Size = new System.Drawing.Size(106, 42);
            this.bCreatePrize.TabIndex = 21;
            this.bCreatePrize.Text = "Create Prize";
            this.bCreatePrize.UseVisualStyleBackColor = true;
            this.bCreatePrize.Click += new System.EventHandler(this.bCreatePrize_Click);
            // 
            // lbTeams
            // 
            this.lbTeams.FormattingEnabled = true;
            this.lbTeams.ItemHeight = 17;
            this.lbTeams.Location = new System.Drawing.Point(307, 63);
            this.lbTeams.Name = "lbTeams";
            this.lbTeams.Size = new System.Drawing.Size(169, 89);
            this.lbTeams.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label4.Location = new System.Drawing.Point(307, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 22);
            this.label4.TabIndex = 24;
            this.label4.Text = "Teams / Players";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label5.Location = new System.Drawing.Point(307, 208);
            this.label5.Margin = new System.Windows.Forms.Padding(11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 22);
            this.label5.TabIndex = 26;
            this.label5.Text = "Prizes";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPrizes
            // 
            this.lbPrizes.FormattingEnabled = true;
            this.lbPrizes.ItemHeight = 17;
            this.lbPrizes.Location = new System.Drawing.Point(307, 244);
            this.lbPrizes.Name = "lbPrizes";
            this.lbPrizes.Size = new System.Drawing.Size(169, 89);
            this.lbPrizes.TabIndex = 25;
            // 
            // bDeletePlayers
            // 
            this.bDeletePlayers.Location = new System.Drawing.Point(307, 161);
            this.bDeletePlayers.Name = "bDeletePlayers";
            this.bDeletePlayers.Size = new System.Drawing.Size(169, 33);
            this.bDeletePlayers.TabIndex = 28;
            this.bDeletePlayers.Text = "Delete Selected";
            this.bDeletePlayers.UseVisualStyleBackColor = true;
            this.bDeletePlayers.Click += new System.EventHandler(this.bDeletePlayers_Click);
            // 
            // bCreateTournament
            // 
            this.bCreateTournament.Location = new System.Drawing.Point(20, 308);
            this.bCreateTournament.Name = "bCreateTournament";
            this.bCreateTournament.Size = new System.Drawing.Size(218, 64);
            this.bCreateTournament.TabIndex = 29;
            this.bCreateTournament.Text = "Create Tournament ";
            this.bCreateTournament.UseVisualStyleBackColor = true;
            this.bCreateTournament.Click += new System.EventHandler(this.bCreateTournament_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 68);
            this.panel1.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label6.Location = new System.Drawing.Point(177, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "Create Tournament";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.panel2.Controls.Add(this.bDeletePrizes);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbTournamentName);
            this.panel2.Controls.Add(this.bCreateTournament);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.bDeletePlayers);
            this.panel2.Controls.Add(this.bCreatePrize);
            this.panel2.Controls.Add(this.lbPrizes);
            this.panel2.Controls.Add(this.bAddTeam);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lbTeams);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tbEntryFee);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.llCreateTeam);
            this.panel2.Controls.Add(this.cbTeams);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(533, 403);
            this.panel2.TabIndex = 31;
            // 
            // bDeletePrizes
            // 
            this.bDeletePrizes.Location = new System.Drawing.Point(307, 339);
            this.bDeletePrizes.Name = "bDeletePrizes";
            this.bDeletePrizes.Size = new System.Drawing.Size(169, 33);
            this.bDeletePrizes.TabIndex = 30;
            this.bDeletePrizes.Text = "Delete Selected";
            this.bDeletePrizes.UseVisualStyleBackColor = true;
            this.bDeletePrizes.Click += new System.EventHandler(this.bDeletePrizes_Click);
            // 
            // TournamentCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(533, 471);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TournamentCreate";
            this.Text = "Tournament Creator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTournamentName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEntryFee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTeams;
        private System.Windows.Forms.LinkLabel llCreateTeam;
        private System.Windows.Forms.Button bAddTeam;
        private System.Windows.Forms.Button bCreatePrize;
        private System.Windows.Forms.ListBox lbTeams;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbPrizes;
        private System.Windows.Forms.Button bDeletePlayers;
        private System.Windows.Forms.Button bCreateTournament;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bDeletePrizes;
    }
}