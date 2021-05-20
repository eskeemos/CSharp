
namespace HotelSystemManagement
{
    partial class StaffInfo
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffInfo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.StaffID = new System.Windows.Forms.TextBox();
            this.ClientID = new System.Windows.Forms.TextBox();
            this.DateHms = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StaffPhone = new System.Windows.Forms.TextBox();
            this.StaffName = new System.Windows.Forms.TextBox();
            this.StaffGender = new System.Windows.Forms.ComboBox();
            this.StaffGridView = new System.Windows.Forms.DataGridView();
            this.Reset = new System.Windows.Forms.PictureBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.StaffSearch = new System.Windows.Forms.TextBox();
            this.EditBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.StaffPassword = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.BackBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reset)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.StaffID);
            this.panel1.Controls.Add(this.ClientID);
            this.panel1.Controls.Add(this.DateHms);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(13)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 106);
            this.panel1.TabIndex = 1;
            // 
            // StaffID
            // 
            this.StaffID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.StaffID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StaffID.CausesValidation = false;
            this.StaffID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StaffID.ForeColor = System.Drawing.SystemColors.Window;
            this.StaffID.Location = new System.Drawing.Point(1, 1);
            this.StaffID.Margin = new System.Windows.Forms.Padding(10);
            this.StaffID.Multiline = true;
            this.StaffID.Name = "StaffID";
            this.StaffID.PlaceholderText = "StaffName";
            this.StaffID.Size = new System.Drawing.Size(1, 1);
            this.StaffID.TabIndex = 22;
            // 
            // ClientID
            // 
            this.ClientID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.ClientID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClientID.CausesValidation = false;
            this.ClientID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClientID.ForeColor = System.Drawing.SystemColors.Window;
            this.ClientID.Location = new System.Drawing.Point(1, 1);
            this.ClientID.Margin = new System.Windows.Forms.Padding(10);
            this.ClientID.Multiline = true;
            this.ClientID.Name = "ClientID";
            this.ClientID.Size = new System.Drawing.Size(1, 1);
            this.ClientID.TabIndex = 1;
            this.ClientID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DateHms
            // 
            this.DateHms.AutoSize = true;
            this.DateHms.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DateHms.Location = new System.Drawing.Point(789, 73);
            this.DateHms.Name = "DateHms";
            this.DateHms.Size = new System.Drawing.Size(52, 24);
            this.DateHms.TabIndex = 1;
            this.DateHms.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(333, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staff Information";
            // 
            // StaffPhone
            // 
            this.StaffPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.StaffPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StaffPhone.CausesValidation = false;
            this.StaffPhone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StaffPhone.ForeColor = System.Drawing.SystemColors.Window;
            this.StaffPhone.Location = new System.Drawing.Point(39, 197);
            this.StaffPhone.Margin = new System.Windows.Forms.Padding(10);
            this.StaffPhone.Multiline = true;
            this.StaffPhone.Name = "StaffPhone";
            this.StaffPhone.PlaceholderText = "StaffPhone";
            this.StaffPhone.Size = new System.Drawing.Size(222, 25);
            this.StaffPhone.TabIndex = 5;
            // 
            // StaffName
            // 
            this.StaffName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.StaffName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StaffName.CausesValidation = false;
            this.StaffName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StaffName.ForeColor = System.Drawing.SystemColors.Window;
            this.StaffName.Location = new System.Drawing.Point(39, 152);
            this.StaffName.Margin = new System.Windows.Forms.Padding(10);
            this.StaffName.Multiline = true;
            this.StaffName.Name = "StaffName";
            this.StaffName.PlaceholderText = "StaffName";
            this.StaffName.Size = new System.Drawing.Size(222, 25);
            this.StaffName.TabIndex = 6;
            // 
            // StaffGender
            // 
            this.StaffGender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.StaffGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.StaffGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StaffGender.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StaffGender.ForeColor = System.Drawing.SystemColors.Window;
            this.StaffGender.FormattingEnabled = true;
            this.StaffGender.Items.AddRange(new object[] {
            "Man",
            "Women"});
            this.StaffGender.Location = new System.Drawing.Point(39, 287);
            this.StaffGender.Margin = new System.Windows.Forms.Padding(10);
            this.StaffGender.Name = "StaffGender";
            this.StaffGender.Size = new System.Drawing.Size(222, 29);
            this.StaffGender.TabIndex = 8;
            this.StaffGender.Text = "Chose gender";
            // 
            // StaffGridView
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Orange;
            this.StaffGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.StaffGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.StaffGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StaffGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.StaffGridView.Location = new System.Drawing.Point(292, 152);
            this.StaffGridView.Margin = new System.Windows.Forms.Padding(30);
            this.StaffGridView.Name = "StaffGridView";
            this.StaffGridView.RowTemplate.Height = 25;
            this.StaffGridView.Size = new System.Drawing.Size(543, 341);
            this.StaffGridView.TabIndex = 9;
            this.StaffGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StaffGridView_CellContentClick);
            // 
            // Reset
            // 
            this.Reset.Image = ((System.Drawing.Image)(resources.GetObject("Reset.Image")));
            this.Reset.Location = new System.Drawing.Point(803, 119);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(32, 25);
            this.Reset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Reset.TabIndex = 17;
            this.Reset.TabStop = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchBtn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(13)))));
            this.SearchBtn.Location = new System.Drawing.Point(723, 119);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(74, 25);
            this.SearchBtn.TabIndex = 16;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // StaffSearch
            // 
            this.StaffSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.StaffSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StaffSearch.CausesValidation = false;
            this.StaffSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StaffSearch.ForeColor = System.Drawing.SystemColors.Window;
            this.StaffSearch.Location = new System.Drawing.Point(488, 119);
            this.StaffSearch.Margin = new System.Windows.Forms.Padding(10);
            this.StaffSearch.Multiline = true;
            this.StaffSearch.Name = "StaffSearch";
            this.StaffSearch.PlaceholderText = "StaffName";
            this.StaffSearch.Size = new System.Drawing.Size(222, 25);
            this.StaffSearch.TabIndex = 15;
            this.StaffSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(13)))));
            this.EditBtn.Location = new System.Drawing.Point(114, 329);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(68, 41);
            this.EditBtn.TabIndex = 20;
            this.EditBtn.Text = "EDIT";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(13)))));
            this.DeleteBtn.Location = new System.Drawing.Point(188, 329);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(74, 41);
            this.DeleteBtn.TabIndex = 19;
            this.DeleteBtn.Text = "DELETE";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(13)))));
            this.AddBtn.Location = new System.Drawing.Point(40, 329);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(68, 41);
            this.AddBtn.TabIndex = 18;
            this.AddBtn.Text = "ADD";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // StaffPassword
            // 
            this.StaffPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.StaffPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StaffPassword.CausesValidation = false;
            this.StaffPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StaffPassword.ForeColor = System.Drawing.SystemColors.Window;
            this.StaffPassword.Location = new System.Drawing.Point(39, 242);
            this.StaffPassword.Margin = new System.Windows.Forms.Padding(10);
            this.StaffPassword.Multiline = true;
            this.StaffPassword.Name = "StaffPassword";
            this.StaffPassword.PlaceholderText = "StaffPassword";
            this.StaffPassword.Size = new System.Drawing.Size(222, 25);
            this.StaffPassword.TabIndex = 21;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BackBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(13)))));
            this.BackBtn.Location = new System.Drawing.Point(12, 479);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(68, 41);
            this.BackBtn.TabIndex = 22;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // StaffInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(871, 532);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.StaffPassword);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.StaffSearch);
            this.Controls.Add(this.StaffGridView);
            this.Controls.Add(this.StaffGender);
            this.Controls.Add(this.StaffPhone);
            this.Controls.Add(this.StaffName);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gender";
            this.Load += new System.EventHandler(this.StaffInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ClientID;
        private System.Windows.Forms.Label DateHms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StaffName;
        private System.Windows.Forms.DataGridView StaffGridView;
        private System.Windows.Forms.PictureBox Reset;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox StaffSearch;
        private System.Windows.Forms.TextBox StaffPhone;
        private System.Windows.Forms.ComboBox StaffGender;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox StaffPassword;
        private System.Windows.Forms.TextBox StaffID;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button BackBtn;
    }
}