
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
            this.lheader = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEntryFee = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTeams = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.bAddTeam = new System.Windows.Forms.Button();
            this.bCreatePrize = new System.Windows.Forms.Button();
            this.lbPlayers = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbPrizes = new System.Windows.Forms.ListBox();
            this.dDeletePrize = new System.Windows.Forms.Button();
            this.bDeletePlayers = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lheader
            // 
            this.lheader.AutoSize = true;
            this.lheader.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lheader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.lheader.Location = new System.Drawing.Point(22, 22);
            this.lheader.Margin = new System.Windows.Forms.Padding(11);
            this.lheader.Name = "lheader";
            this.lheader.Size = new System.Drawing.Size(175, 24);
            this.lheader.TabIndex = 1;
            this.lheader.Text = "Create Tournament";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.label1.Location = new System.Drawing.Point(22, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tournament Name :";
            // 
            // tbTName
            // 
            this.tbTName.Location = new System.Drawing.Point(22, 109);
            this.tbTName.Name = "tbTName";
            this.tbTName.Size = new System.Drawing.Size(218, 23);
            this.tbTName.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.label2.Location = new System.Drawing.Point(22, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Entry Fee";
            // 
            // tbEntryFee
            // 
            this.tbEntryFee.Location = new System.Drawing.Point(145, 150);
            this.tbEntryFee.Name = "tbEntryFee";
            this.tbEntryFee.Size = new System.Drawing.Size(95, 23);
            this.tbEntryFee.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.label3.Location = new System.Drawing.Point(22, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Select Team  /";
            // 
            // cbTeams
            // 
            this.cbTeams.FormattingEnabled = true;
            this.cbTeams.Location = new System.Drawing.Point(23, 237);
            this.cbTeams.Name = "cbTeams";
            this.cbTeams.Size = new System.Drawing.Size(219, 25);
            this.cbTeams.TabIndex = 18;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.Location = new System.Drawing.Point(137, 203);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(92, 17);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Create Team";
            // 
            // bAddTeam
            // 
            this.bAddTeam.Location = new System.Drawing.Point(23, 283);
            this.bAddTeam.Name = "bAddTeam";
            this.bAddTeam.Size = new System.Drawing.Size(106, 42);
            this.bAddTeam.TabIndex = 20;
            this.bAddTeam.Text = "Add Team";
            this.bAddTeam.UseVisualStyleBackColor = true;
            // 
            // bCreatePrize
            // 
            this.bCreatePrize.Location = new System.Drawing.Point(136, 283);
            this.bCreatePrize.Name = "bCreatePrize";
            this.bCreatePrize.Size = new System.Drawing.Size(106, 42);
            this.bCreatePrize.TabIndex = 21;
            this.bCreatePrize.Text = "Create Prize";
            this.bCreatePrize.UseVisualStyleBackColor = true;
            // 
            // lbPlayers
            // 
            this.lbPlayers.FormattingEnabled = true;
            this.lbPlayers.ItemHeight = 17;
            this.lbPlayers.Location = new System.Drawing.Point(260, 69);
            this.lbPlayers.Name = "lbPlayers";
            this.lbPlayers.Size = new System.Drawing.Size(169, 89);
            this.lbPlayers.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.label4.Location = new System.Drawing.Point(260, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 22);
            this.label4.TabIndex = 24;
            this.label4.Text = "Teams / Players";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.label5.Location = new System.Drawing.Point(260, 228);
            this.label5.Margin = new System.Windows.Forms.Padding(11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 22);
            this.label5.TabIndex = 26;
            this.label5.Text = "Teams / Players";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPrizes
            // 
            this.lbPrizes.FormattingEnabled = true;
            this.lbPrizes.ItemHeight = 17;
            this.lbPrizes.Location = new System.Drawing.Point(260, 264);
            this.lbPrizes.Name = "lbPrizes";
            this.lbPrizes.Size = new System.Drawing.Size(169, 89);
            this.lbPrizes.TabIndex = 25;
            // 
            // dDeletePrize
            // 
            this.dDeletePrize.Location = new System.Drawing.Point(260, 368);
            this.dDeletePrize.Name = "dDeletePrize";
            this.dDeletePrize.Size = new System.Drawing.Size(169, 42);
            this.dDeletePrize.TabIndex = 27;
            this.dDeletePrize.Text = "Delete Selected";
            this.dDeletePrize.UseVisualStyleBackColor = true;
            // 
            // bDeletePlayers
            // 
            this.bDeletePlayers.Location = new System.Drawing.Point(260, 172);
            this.bDeletePlayers.Name = "bDeletePlayers";
            this.bDeletePlayers.Size = new System.Drawing.Size(169, 42);
            this.bDeletePlayers.TabIndex = 28;
            this.bDeletePlayers.Text = "Delete Selected";
            this.bDeletePlayers.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 69);
            this.button1.TabIndex = 29;
            this.button1.Text = "Create Tournament ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TournamentCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(448, 423);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bDeletePlayers);
            this.Controls.Add(this.dDeletePrize);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbPrizes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbPlayers);
            this.Controls.Add(this.bCreatePrize);
            this.Controls.Add(this.bAddTeam);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.cbTeams);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbEntryFee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lheader);
            this.Name = "TournamentCreate";
            this.Text = "Tournament Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lheader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEntryFee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTeams;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button bAddTeam;
        private System.Windows.Forms.Button bCreatePrize;
        private System.Windows.Forms.ListBox lbPlayers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbPrizes;
        private System.Windows.Forms.Button dDeletePrize;
        private System.Windows.Forms.Button bDeletePlayers;
        private System.Windows.Forms.Button button1;
    }
}