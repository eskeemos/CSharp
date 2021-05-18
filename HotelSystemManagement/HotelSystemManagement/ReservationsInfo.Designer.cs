
namespace HotelSystemManagement
{
    partial class ReservationsInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationsInfo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.StaffID = new System.Windows.Forms.TextBox();
            this.ClientID = new System.Windows.Forms.TextBox();
            this.DateHms = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.DateIn = new System.Windows.Forms.DateTimePicker();
            this.ResevationID = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Reset = new System.Windows.Forms.PictureBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.ReservationSearch = new System.Windows.Forms.TextBox();
            this.ReservationGridView = new System.Windows.Forms.DataGridView();
            this.ClientName = new System.Windows.Forms.TextBox();
            this.RoomNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DateOut = new System.Windows.Forms.DateTimePicker();
            this.EditBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationGridView)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(900, 100);
            this.panel1.TabIndex = 3;
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
            this.DateHms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DateHms.AutoSize = true;
            this.DateHms.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DateHms.Location = new System.Drawing.Point(809, 64);
            this.DateHms.Margin = new System.Windows.Forms.Padding(0, 55, 30, 0);
            this.DateHms.Name = "DateHms";
            this.DateHms.Size = new System.Drawing.Size(52, 24);
            this.DateHms.TabIndex = 1;
            this.DateHms.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(296, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservation Information";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // DateIn
            // 
            this.DateIn.CalendarFont = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.DateIn.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.DateIn.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.DateIn.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.DateIn.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.DateIn.Location = new System.Drawing.Point(39, 299);
            this.DateIn.Name = "DateIn";
            this.DateIn.Size = new System.Drawing.Size(247, 22);
            this.DateIn.TabIndex = 4;
            this.DateIn.ValueChanged += new System.EventHandler(this.DateIn_ValueChanged);
            // 
            // ResevationID
            // 
            this.ResevationID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.ResevationID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResevationID.CausesValidation = false;
            this.ResevationID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResevationID.ForeColor = System.Drawing.SystemColors.Window;
            this.ResevationID.Location = new System.Drawing.Point(39, 149);
            this.ResevationID.Margin = new System.Windows.Forms.Padding(30, 10, 25, 10);
            this.ResevationID.Multiline = true;
            this.ResevationID.Name = "ResevationID";
            this.ResevationID.PlaceholderText = "Reservation ID";
            this.ResevationID.Size = new System.Drawing.Size(247, 25);
            this.ResevationID.TabIndex = 15;
            this.ResevationID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.CausesValidation = false;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(473, 87);
            this.textBox1.Margin = new System.Windows.Forms.Padding(10);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Room Search";
            this.textBox1.Size = new System.Drawing.Size(222, 25);
            this.textBox1.TabIndex = 29;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(13)))));
            this.button1.Location = new System.Drawing.Point(708, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 25);
            this.button1.TabIndex = 30;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(788, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // Reset
            // 
            this.Reset.Image = ((System.Drawing.Image)(resources.GetObject("Reset.Image")));
            this.Reset.Location = new System.Drawing.Point(844, 112);
            this.Reset.Margin = new System.Windows.Forms.Padding(10, 15, 15, 15);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(32, 25);
            this.Reset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Reset.TabIndex = 31;
            this.Reset.TabStop = false;
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchBtn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(13)))));
            this.SearchBtn.Location = new System.Drawing.Point(757, 113);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(74, 25);
            this.SearchBtn.TabIndex = 30;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = false;
            // 
            // ReservationSearch
            // 
            this.ReservationSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.ReservationSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReservationSearch.CausesValidation = false;
            this.ReservationSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReservationSearch.ForeColor = System.Drawing.SystemColors.Window;
            this.ReservationSearch.Location = new System.Drawing.Point(515, 113);
            this.ReservationSearch.Margin = new System.Windows.Forms.Padding(10);
            this.ReservationSearch.Multiline = true;
            this.ReservationSearch.Name = "ReservationSearch";
            this.ReservationSearch.PlaceholderText = "Reservation Search";
            this.ReservationSearch.Size = new System.Drawing.Size(222, 25);
            this.ReservationSearch.TabIndex = 29;
            this.ReservationSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ReservationGridView
            // 
            this.ReservationGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReservationGridView.Location = new System.Drawing.Point(326, 149);
            this.ReservationGridView.Margin = new System.Windows.Forms.Padding(15, 3, 15, 10);
            this.ReservationGridView.Name = "ReservationGridView";
            this.ReservationGridView.RowTemplate.Height = 25;
            this.ReservationGridView.Size = new System.Drawing.Size(550, 350);
            this.ReservationGridView.TabIndex = 32;
            this.ReservationGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReservationGridView_CellContentClick);
            // 
            // ClientName
            // 
            this.ClientName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.ClientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClientName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClientName.ForeColor = System.Drawing.SystemColors.Window;
            this.ClientName.Location = new System.Drawing.Point(39, 194);
            this.ClientName.Margin = new System.Windows.Forms.Padding(30, 10, 25, 10);
            this.ClientName.Name = "ClientName";
            this.ClientName.PlaceholderText = "Client Name";
            this.ClientName.Size = new System.Drawing.Size(247, 27);
            this.ClientName.TabIndex = 33;
            this.ClientName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RoomNumber
            // 
            this.RoomNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.RoomNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RoomNumber.CausesValidation = false;
            this.RoomNumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RoomNumber.ForeColor = System.Drawing.SystemColors.Window;
            this.RoomNumber.Location = new System.Drawing.Point(39, 239);
            this.RoomNumber.Margin = new System.Windows.Forms.Padding(30, 10, 25, 10);
            this.RoomNumber.Multiline = true;
            this.RoomNumber.Name = "RoomNumber";
            this.RoomNumber.PlaceholderText = "Room Number";
            this.RoomNumber.Size = new System.Drawing.Size(247, 25);
            this.RoomNumber.TabIndex = 34;
            this.RoomNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(39, 275);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 21);
            this.label2.TabIndex = 35;
            this.label2.Text = "DateIn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(39, 334);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 36;
            this.label3.Text = "DateOut";
            // 
            // DateOut
            // 
            this.DateOut.CalendarFont = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.DateOut.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.DateOut.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.DateOut.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.DateOut.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.DateOut.Location = new System.Drawing.Point(39, 358);
            this.DateOut.Name = "DateOut";
            this.DateOut.Size = new System.Drawing.Size(247, 22);
            this.DateOut.TabIndex = 37;
            this.DateOut.ValueChanged += new System.EventHandler(this.DateOut_ValueChanged);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(13)))));
            this.EditBtn.Location = new System.Drawing.Point(126, 397);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(10);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(68, 41);
            this.EditBtn.TabIndex = 41;
            this.EditBtn.Text = "EDIT";
            this.EditBtn.UseVisualStyleBackColor = false;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(13)))));
            this.DeleteBtn.Location = new System.Drawing.Point(212, 397);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(10);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(74, 41);
            this.DeleteBtn.TabIndex = 40;
            this.DeleteBtn.Text = "DELETE";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(13)))));
            this.AddBtn.Location = new System.Drawing.Point(39, 397);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(10);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(68, 41);
            this.AddBtn.TabIndex = 39;
            this.AddBtn.Text = "ADD";
            this.AddBtn.UseVisualStyleBackColor = false;
            // 
            // ReservationsInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(900, 515);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.DateOut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RoomNumber);
            this.Controls.Add(this.ClientName);
            this.Controls.Add(this.ReservationGridView);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.ReservationSearch);
            this.Controls.Add(this.ResevationID);
            this.Controls.Add(this.DateIn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReservationsInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ReservationsInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox StaffID;
        private System.Windows.Forms.TextBox ClientID;
        private System.Windows.Forms.Label DateHms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.DateTimePicker DateIn;
        private System.Windows.Forms.TextBox ResevationID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Reset;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox ReservationSearch;
        private System.Windows.Forms.DataGridView ReservationGridView;
        private System.Windows.Forms.TextBox ClientName;
        private System.Windows.Forms.TextBox RoomNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DateOut;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button AddBtn;
    }
}