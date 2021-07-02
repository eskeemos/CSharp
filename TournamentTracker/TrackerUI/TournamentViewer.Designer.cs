
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
            this.lheader = new System.Windows.Forms.Label();
            this.lTName = new System.Windows.Forms.Label();
            this.lRound = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cbUnplayedOnly = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lteamOne = new System.Windows.Forms.Label();
            this.lTeamTwo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTeamOne = new System.Windows.Forms.TextBox();
            this.tbTeamTwo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lheader
            // 
            this.lheader.AutoSize = true;
            this.lheader.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lheader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.lheader.Location = new System.Drawing.Point(19, 19);
            this.lheader.Margin = new System.Windows.Forms.Padding(10);
            this.lheader.Name = "lheader";
            this.lheader.Size = new System.Drawing.Size(123, 24);
            this.lheader.TabIndex = 0;
            this.lheader.Text = "Tournament :";
            // 
            // lTName
            // 
            this.lTName.AutoSize = true;
            this.lTName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lTName.Location = new System.Drawing.Point(150, 19);
            this.lTName.Margin = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.lTName.Name = "lTName";
            this.lTName.Size = new System.Drawing.Size(73, 22);
            this.lTName.TabIndex = 1;
            this.lTName.Text = "TName";
            // 
            // lRound
            // 
            this.lRound.AutoSize = true;
            this.lRound.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lRound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.lRound.Location = new System.Drawing.Point(19, 66);
            this.lRound.Margin = new System.Windows.Forms.Padding(10, 15, 10, 10);
            this.lRound.Name = "lRound";
            this.lRound.Size = new System.Drawing.Size(71, 22);
            this.lRound.TabIndex = 2;
            this.lRound.Text = "Round";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(93, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(130, 25);
            this.comboBox1.TabIndex = 3;
            // 
            // cbUnplayedOnly
            // 
            this.cbUnplayedOnly.AutoSize = true;
            this.cbUnplayedOnly.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbUnplayedOnly.Location = new System.Drawing.Point(93, 97);
            this.cbUnplayedOnly.Margin = new System.Windows.Forms.Padding(5);
            this.cbUnplayedOnly.Name = "cbUnplayedOnly";
            this.cbUnplayedOnly.Size = new System.Drawing.Size(136, 24);
            this.cbUnplayedOnly.TabIndex = 4;
            this.cbUnplayedOnly.Text = "Unplayed Only";
            this.cbUnplayedOnly.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(19, 126);
            this.listBox1.Margin = new System.Windows.Forms.Padding(10);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(209, 140);
            this.listBox1.TabIndex = 5;
            // 
            // lteamOne
            // 
            this.lteamOne.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lteamOne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.lteamOne.Location = new System.Drawing.Point(243, 126);
            this.lteamOne.Margin = new System.Windows.Forms.Padding(5);
            this.lteamOne.Name = "lteamOne";
            this.lteamOne.Size = new System.Drawing.Size(125, 25);
            this.lteamOne.TabIndex = 8;
            this.lteamOne.Text = "<team one>";
            this.lteamOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lTeamTwo
            // 
            this.lTeamTwo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lTeamTwo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.lTeamTwo.Location = new System.Drawing.Point(243, 193);
            this.lTeamTwo.Margin = new System.Windows.Forms.Padding(5);
            this.lTeamTwo.Name = "lTeamTwo";
            this.lTeamTwo.Size = new System.Drawing.Size(125, 25);
            this.lTeamTwo.TabIndex = 9;
            this.lTeamTwo.Text = "<team two>";
            this.lTeamTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.label1.Location = new System.Drawing.Point(283, 161);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "-VS-";
            // 
            // tbTeamOne
            // 
            this.tbTeamOne.Location = new System.Drawing.Point(376, 195);
            this.tbTeamOne.Name = "tbTeamOne";
            this.tbTeamOne.Size = new System.Drawing.Size(60, 23);
            this.tbTeamOne.TabIndex = 12;
            // 
            // tbTeamTwo
            // 
            this.tbTeamTwo.Location = new System.Drawing.Point(376, 128);
            this.tbTeamTwo.Name = "tbTeamTwo";
            this.tbTeamTwo.Size = new System.Drawing.Size(60, 23);
            this.tbTeamTwo.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 30);
            this.button1.TabIndex = 14;
            this.button1.Text = "Score";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(372, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(265, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // TournamentViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(464, 285);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbTeamTwo);
            this.Controls.Add(this.tbTeamOne);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lTeamTwo);
            this.Controls.Add(this.lteamOne);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cbUnplayedOnly);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lRound);
            this.Controls.Add(this.lTName);
            this.Controls.Add(this.lheader);
            this.Name = "TournamentViewer";
            this.Text = "Tournament Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lheader;
        private System.Windows.Forms.Label lTName;
        private System.Windows.Forms.Label lRound;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox cbUnplayedOnly;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lteamOne;
        private System.Windows.Forms.Label lTeamTwo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTeamOne;
        private System.Windows.Forms.TextBox tbTeamTwo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}