
namespace TrackerUI
{
    partial class TournamentViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewer));
            this.lTournamentName = new System.Windows.Forms.Label();
            this.lRound = new System.Windows.Forms.Label();
            this.cbRounds = new System.Windows.Forms.ComboBox();
            this.cbUnplayedOnly = new System.Windows.Forms.CheckBox();
            this.lbRounds = new System.Windows.Forms.ListBox();
            this.lteamOne = new System.Windows.Forms.Label();
            this.lTeamTwo = new System.Windows.Forms.Label();
            this.lVersus = new System.Windows.Forms.Label();
            this.tbTeamTwo = new System.Windows.Forms.TextBox();
            this.tbTeamOne = new System.Windows.Forms.TextBox();
            this.bScore = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lNoneSelected = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lTournamentName
            // 
            this.lTournamentName.AutoSize = true;
            this.lTournamentName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic);
            this.lTournamentName.Location = new System.Drawing.Point(149, 23);
            this.lTournamentName.Margin = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.lTournamentName.Name = "lTournamentName";
            this.lTournamentName.Size = new System.Drawing.Size(73, 22);
            this.lTournamentName.TabIndex = 1;
            this.lTournamentName.Text = "TName";
            // 
            // lRound
            // 
            this.lRound.AutoSize = true;
            this.lRound.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lRound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.lRound.Location = new System.Drawing.Point(33, 28);
            this.lRound.Margin = new System.Windows.Forms.Padding(10, 15, 10, 10);
            this.lRound.Name = "lRound";
            this.lRound.Size = new System.Drawing.Size(71, 22);
            this.lRound.TabIndex = 2;
            this.lRound.Text = "Round";
            // 
            // cbRounds
            // 
            this.cbRounds.FormattingEnabled = true;
            this.cbRounds.Location = new System.Drawing.Point(107, 27);
            this.cbRounds.Name = "cbRounds";
            this.cbRounds.Size = new System.Drawing.Size(130, 25);
            this.cbRounds.TabIndex = 3;
            this.cbRounds.SelectedIndexChanged += new System.EventHandler(this.cbRounds_SelectedIndexChanged);
            // 
            // cbUnplayedOnly
            // 
            this.cbUnplayedOnly.AutoSize = true;
            this.cbUnplayedOnly.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.cbUnplayedOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cbUnplayedOnly.Location = new System.Drawing.Point(107, 60);
            this.cbUnplayedOnly.Margin = new System.Windows.Forms.Padding(5);
            this.cbUnplayedOnly.Name = "cbUnplayedOnly";
            this.cbUnplayedOnly.Size = new System.Drawing.Size(136, 24);
            this.cbUnplayedOnly.TabIndex = 4;
            this.cbUnplayedOnly.Text = "Unplayed Only";
            this.cbUnplayedOnly.UseVisualStyleBackColor = true;
            this.cbUnplayedOnly.CheckedChanged += new System.EventHandler(this.cbUnplayedOnly_CheckedChanged);
            // 
            // lbRounds
            // 
            this.lbRounds.FormattingEnabled = true;
            this.lbRounds.ItemHeight = 17;
            this.lbRounds.Location = new System.Drawing.Point(33, 99);
            this.lbRounds.Margin = new System.Windows.Forms.Padding(10);
            this.lbRounds.Name = "lbRounds";
            this.lbRounds.Size = new System.Drawing.Size(209, 140);
            this.lbRounds.TabIndex = 5;
            this.lbRounds.SelectedIndexChanged += new System.EventHandler(this.lbRounds_SelectedIndexChanged);
            // 
            // lteamOne
            // 
            this.lteamOne.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lteamOne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.lteamOne.Location = new System.Drawing.Point(257, 169);
            this.lteamOne.Margin = new System.Windows.Forms.Padding(5);
            this.lteamOne.Name = "lteamOne";
            this.lteamOne.Size = new System.Drawing.Size(125, 25);
            this.lteamOne.TabIndex = 8;
            this.lteamOne.Text = "<bot>";
            this.lteamOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lTeamTwo
            // 
            this.lTeamTwo.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lTeamTwo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.lTeamTwo.Location = new System.Drawing.Point(395, 169);
            this.lTeamTwo.Margin = new System.Windows.Forms.Padding(5);
            this.lTeamTwo.Name = "lTeamTwo";
            this.lTeamTwo.Size = new System.Drawing.Size(125, 25);
            this.lTeamTwo.TabIndex = 9;
            this.lTeamTwo.Text = "<bot>";
            this.lTeamTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lVersus
            // 
            this.lVersus.AutoSize = true;
            this.lVersus.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lVersus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.lVersus.Location = new System.Drawing.Point(363, 137);
            this.lVersus.Margin = new System.Windows.Forms.Padding(5);
            this.lVersus.Name = "lVersus";
            this.lVersus.Size = new System.Drawing.Size(46, 22);
            this.lVersus.TabIndex = 10;
            this.lVersus.Text = "-VS-";
            // 
            // tbTeamTwo
            // 
            this.tbTeamTwo.Location = new System.Drawing.Point(418, 99);
            this.tbTeamTwo.Name = "tbTeamTwo";
            this.tbTeamTwo.Size = new System.Drawing.Size(64, 23);
            this.tbTeamTwo.TabIndex = 12;
            this.tbTeamTwo.Text = "0";
            this.tbTeamTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbTeamOne
            // 
            this.tbTeamOne.Location = new System.Drawing.Point(288, 99);
            this.tbTeamOne.Name = "tbTeamOne";
            this.tbTeamOne.Size = new System.Drawing.Size(64, 23);
            this.tbTeamOne.TabIndex = 13;
            this.tbTeamOne.Text = "0";
            this.tbTeamOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bScore
            // 
            this.bScore.Location = new System.Drawing.Point(335, 209);
            this.bScore.Name = "bScore";
            this.bScore.Size = new System.Drawing.Size(101, 30);
            this.bScore.TabIndex = 14;
            this.bScore.Text = "Score";
            this.bScore.UseVisualStyleBackColor = true;
            this.bScore.Click += new System.EventHandler(this.bScore_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(418, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(288, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lTournamentName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 68);
            this.panel1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label2.Location = new System.Drawing.Point(23, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tournament :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.panel2.Controls.Add(this.lNoneSelected);
            this.panel2.Controls.Add(this.lRound);
            this.panel2.Controls.Add(this.cbRounds);
            this.panel2.Controls.Add(this.bScore);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.tbTeamTwo);
            this.panel2.Controls.Add(this.tbTeamOne);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.cbUnplayedOnly);
            this.panel2.Controls.Add(this.lVersus);
            this.panel2.Controls.Add(this.lbRounds);
            this.panel2.Controls.Add(this.lteamOne);
            this.panel2.Controls.Add(this.lTeamTwo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(534, 273);
            this.panel2.TabIndex = 18;
            // 
            // lNoneSelected
            // 
            this.lNoneSelected.AutoSize = true;
            this.lNoneSelected.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lNoneSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.lNoneSelected.Location = new System.Drawing.Point(281, 137);
            this.lNoneSelected.Margin = new System.Windows.Forms.Padding(5);
            this.lNoneSelected.Name = "lNoneSelected";
            this.lNoneSelected.Size = new System.Drawing.Size(212, 22);
            this.lNoneSelected.TabIndex = 17;
            this.lNoneSelected.Text = "No Matchup Selected";
            this.lNoneSelected.Visible = false;
            // 
            // TournamentViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(534, 341);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TournamentViewer";
            this.Text = "Tournament Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lTournamentName;
        private System.Windows.Forms.Label lRound;
        private System.Windows.Forms.ComboBox cbRounds;
        private System.Windows.Forms.CheckBox cbUnplayedOnly;
        private System.Windows.Forms.ListBox lbRounds;
        private System.Windows.Forms.Label lteamOne;
        private System.Windows.Forms.Label lTeamTwo;
        private System.Windows.Forms.Label lVersus;
        private System.Windows.Forms.TextBox tbTeamTwo;
        private System.Windows.Forms.TextBox tbTeamOne;
        private System.Windows.Forms.Button bScore;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lNoneSelected;
    }
}