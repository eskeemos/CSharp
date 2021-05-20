
namespace HotelSystemManagement
{
    partial class RoomInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomInfo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.YesRadio = new System.Windows.Forms.RadioButton();
            this.NoRadio = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.StaffID = new System.Windows.Forms.TextBox();
            this.ClientID = new System.Windows.Forms.TextBox();
            this.DateHms = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RoomPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RoomNumber = new System.Windows.Forms.TextBox();
            this.EditBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.PictureBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.RoomSearch = new System.Windows.Forms.TextBox();
            this.RoomGridView = new System.Windows.Forms.DataGridView();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.BackBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Reset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // YesRadio
            // 
            this.YesRadio.AutoSize = true;
            this.YesRadio.Checked = true;
            this.YesRadio.Location = new System.Drawing.Point(102, 235);
            this.YesRadio.Name = "YesRadio";
            this.YesRadio.Size = new System.Drawing.Size(14, 13);
            this.YesRadio.TabIndex = 10;
            this.YesRadio.TabStop = true;
            this.YesRadio.UseVisualStyleBackColor = true;
            // 
            // NoRadio
            // 
            this.NoRadio.AutoSize = true;
            this.NoRadio.Location = new System.Drawing.Point(168, 235);
            this.NoRadio.Name = "NoRadio";
            this.NoRadio.Size = new System.Drawing.Size(14, 13);
            this.NoRadio.TabIndex = 12;
            this.NoRadio.UseVisualStyleBackColor = true;
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
            this.panel1.TabIndex = 2;
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
            this.label1.Location = new System.Drawing.Point(321, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Information";
            // 
            // RoomPhone
            // 
            this.RoomPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.RoomPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RoomPhone.CausesValidation = false;
            this.RoomPhone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RoomPhone.ForeColor = System.Drawing.SystemColors.Window;
            this.RoomPhone.Location = new System.Drawing.Point(39, 194);
            this.RoomPhone.Margin = new System.Windows.Forms.Padding(10);
            this.RoomPhone.Multiline = true;
            this.RoomPhone.Name = "RoomPhone";
            this.RoomPhone.PlaceholderText = "Enter Room Phone";
            this.RoomPhone.Size = new System.Drawing.Size(222, 25);
            this.RoomPhone.TabIndex = 7;
            this.RoomPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(39, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Free:";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl1.Location = new System.Drawing.Point(117, 229);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(40, 24);
            this.lbl1.TabIndex = 11;
            this.lbl1.Text = "Yes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(183, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "No";
            // 
            // RoomNumber
            // 
            this.RoomNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.RoomNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RoomNumber.CausesValidation = false;
            this.RoomNumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RoomNumber.ForeColor = System.Drawing.SystemColors.Window;
            this.RoomNumber.Location = new System.Drawing.Point(39, 149);
            this.RoomNumber.Margin = new System.Windows.Forms.Padding(10);
            this.RoomNumber.Multiline = true;
            this.RoomNumber.Name = "RoomNumber";
            this.RoomNumber.PlaceholderText = "Enter Room Number";
            this.RoomNumber.Size = new System.Drawing.Size(222, 25);
            this.RoomNumber.TabIndex = 14;
            this.RoomNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(13)))));
            this.EditBtn.Location = new System.Drawing.Point(113, 271);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(68, 41);
            this.EditBtn.TabIndex = 23;
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
            this.DeleteBtn.Location = new System.Drawing.Point(187, 271);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(74, 41);
            this.DeleteBtn.TabIndex = 22;
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
            this.AddBtn.Location = new System.Drawing.Point(39, 271);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(68, 41);
            this.AddBtn.TabIndex = 21;
            this.AddBtn.Text = "ADD";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // Reset
            // 
            this.Reset.Image = ((System.Drawing.Image)(resources.GetObject("Reset.Image")));
            this.Reset.Location = new System.Drawing.Point(800, 116);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(32, 25);
            this.Reset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Reset.TabIndex = 27;
            this.Reset.TabStop = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchBtn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(13)))));
            this.SearchBtn.Location = new System.Drawing.Point(720, 116);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(74, 25);
            this.SearchBtn.TabIndex = 26;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // RoomSearch
            // 
            this.RoomSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.RoomSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RoomSearch.CausesValidation = false;
            this.RoomSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RoomSearch.ForeColor = System.Drawing.SystemColors.Window;
            this.RoomSearch.Location = new System.Drawing.Point(485, 116);
            this.RoomSearch.Margin = new System.Windows.Forms.Padding(10);
            this.RoomSearch.Multiline = true;
            this.RoomSearch.Name = "RoomSearch";
            this.RoomSearch.PlaceholderText = "Room Search";
            this.RoomSearch.Size = new System.Drawing.Size(222, 25);
            this.RoomSearch.TabIndex = 25;
            this.RoomSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RoomGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Orange;
            this.RoomGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.RoomGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RoomGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.RoomGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RoomGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.RoomGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.RoomGridView.Location = new System.Drawing.Point(289, 149);
            this.RoomGridView.Margin = new System.Windows.Forms.Padding(30);
            this.RoomGridView.Name = "RoomGridView";
            this.RoomGridView.ReadOnly = true;
            this.RoomGridView.RowTemplate.Height = 25;
            this.RoomGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RoomGridView.Size = new System.Drawing.Size(543, 341);
            this.RoomGridView.TabIndex = 24;
            this.RoomGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RoomGridView_CellContentClick);
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
            this.BackBtn.TabIndex = 28;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // RoomInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(871, 532);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.RoomSearch);
            this.Controls.Add(this.RoomGridView);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.RoomNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NoRadio);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.YesRadio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RoomPhone);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoomInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.RoomInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Reset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox StaffID;
        private System.Windows.Forms.TextBox ClientID;
        private System.Windows.Forms.Label DateHms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RoomPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton YesRadio;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton NoRadio;
        private System.Windows.Forms.TextBox RoomNumber;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.PictureBox Reset;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox RoomSearch;
        private System.Windows.Forms.DataGridView RoomGridView;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button BackBtn;
    }
}