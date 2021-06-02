
namespace SystemHR.UserInterface.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.General = new System.Windows.Forms.TabPage();
            this.BtnPosition = new System.Windows.Forms.Button();
            this.splitter5 = new System.Windows.Forms.Splitter();
            this.BtnDepartament = new System.Windows.Forms.Button();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.BtnSalaries = new System.Windows.Forms.Button();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.BtnOrganizationStructure = new System.Windows.Forms.Button();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.BtnContracts = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.BtnEmployees = new System.Windows.Forms.Button();
            this.Configuration = new System.Windows.Forms.TabPage();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.TsslVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.TsslDatabase = new System.Windows.Forms.ToolStripStatusLabel();
            this.TsslUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MainTab = new System.Windows.Forms.TabControl();
            this.tabControl1.SuspendLayout();
            this.General.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.General);
            this.tabControl1.Controls.Add(this.Configuration);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1165, 81);
            this.tabControl1.TabIndex = 0;
            // 
            // General
            // 
            this.General.BackColor = System.Drawing.SystemColors.Window;
            this.General.Controls.Add(this.BtnPosition);
            this.General.Controls.Add(this.splitter5);
            this.General.Controls.Add(this.BtnDepartament);
            this.General.Controls.Add(this.splitter4);
            this.General.Controls.Add(this.BtnSalaries);
            this.General.Controls.Add(this.splitter3);
            this.General.Controls.Add(this.BtnOrganizationStructure);
            this.General.Controls.Add(this.splitter2);
            this.General.Controls.Add(this.BtnContracts);
            this.General.Controls.Add(this.splitter1);
            this.General.Controls.Add(this.BtnEmployees);
            this.General.Location = new System.Drawing.Point(4, 26);
            this.General.Margin = new System.Windows.Forms.Padding(0);
            this.General.Name = "General";
            this.General.Padding = new System.Windows.Forms.Padding(5);
            this.General.Size = new System.Drawing.Size(1157, 51);
            this.General.TabIndex = 0;
            this.General.Text = "Ogólne";
            // 
            // BtnPosition
            // 
            this.BtnPosition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnPosition.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnPosition.Image = ((System.Drawing.Image)(resources.GetObject("BtnPosition.Image")));
            this.BtnPosition.Location = new System.Drawing.Point(971, 5);
            this.BtnPosition.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPosition.Name = "BtnPosition";
            this.BtnPosition.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.BtnPosition.Size = new System.Drawing.Size(179, 41);
            this.BtnPosition.TabIndex = 10;
            this.BtnPosition.Text = "Stanowiska";
            this.BtnPosition.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPosition.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPosition.UseVisualStyleBackColor = true;
            // 
            // splitter5
            // 
            this.splitter5.Enabled = false;
            this.splitter5.Location = new System.Drawing.Point(964, 5);
            this.splitter5.Margin = new System.Windows.Forms.Padding(4);
            this.splitter5.Name = "splitter5";
            this.splitter5.Size = new System.Drawing.Size(7, 41);
            this.splitter5.TabIndex = 9;
            this.splitter5.TabStop = false;
            // 
            // BtnDepartament
            // 
            this.BtnDepartament.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnDepartament.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnDepartament.Image = ((System.Drawing.Image)(resources.GetObject("BtnDepartament.Image")));
            this.BtnDepartament.Location = new System.Drawing.Point(822, 5);
            this.BtnDepartament.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDepartament.Name = "BtnDepartament";
            this.BtnDepartament.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.BtnDepartament.Size = new System.Drawing.Size(142, 41);
            this.BtnDepartament.TabIndex = 8;
            this.BtnDepartament.Text = "Działy";
            this.BtnDepartament.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDepartament.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDepartament.UseVisualStyleBackColor = true;
            // 
            // splitter4
            // 
            this.splitter4.Enabled = false;
            this.splitter4.Location = new System.Drawing.Point(815, 5);
            this.splitter4.Margin = new System.Windows.Forms.Padding(4);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(7, 41);
            this.splitter4.TabIndex = 7;
            this.splitter4.TabStop = false;
            // 
            // BtnSalaries
            // 
            this.BtnSalaries.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSalaries.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnSalaries.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalaries.Image")));
            this.BtnSalaries.Location = new System.Drawing.Point(610, 5);
            this.BtnSalaries.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSalaries.Name = "BtnSalaries";
            this.BtnSalaries.Padding = new System.Windows.Forms.Padding(28, 0, 25, 0);
            this.BtnSalaries.Size = new System.Drawing.Size(205, 41);
            this.BtnSalaries.TabIndex = 6;
            this.BtnSalaries.Text = "Wynagrodzenia";
            this.BtnSalaries.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSalaries.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSalaries.UseVisualStyleBackColor = true;
            // 
            // splitter3
            // 
            this.splitter3.Enabled = false;
            this.splitter3.Location = new System.Drawing.Point(603, 5);
            this.splitter3.Margin = new System.Windows.Forms.Padding(4);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(7, 41);
            this.splitter3.TabIndex = 5;
            this.splitter3.TabStop = false;
            // 
            // BtnOrganizationStructure
            // 
            this.BtnOrganizationStructure.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnOrganizationStructure.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnOrganizationStructure.Image = ((System.Drawing.Image)(resources.GetObject("BtnOrganizationStructure.Image")));
            this.BtnOrganizationStructure.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOrganizationStructure.Location = new System.Drawing.Point(347, 5);
            this.BtnOrganizationStructure.Margin = new System.Windows.Forms.Padding(4);
            this.BtnOrganizationStructure.Name = "BtnOrganizationStructure";
            this.BtnOrganizationStructure.Padding = new System.Windows.Forms.Padding(27, 0, 25, 0);
            this.BtnOrganizationStructure.Size = new System.Drawing.Size(256, 41);
            this.BtnOrganizationStructure.TabIndex = 4;
            this.BtnOrganizationStructure.Text = "Struktura organizacyjna";
            this.BtnOrganizationStructure.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnOrganizationStructure.UseVisualStyleBackColor = true;
            this.BtnOrganizationStructure.Click += new System.EventHandler(this.BtnOrganizationStructure_Click);
            // 
            // splitter2
            // 
            this.splitter2.CausesValidation = false;
            this.splitter2.Enabled = false;
            this.splitter2.Location = new System.Drawing.Point(340, 5);
            this.splitter2.Margin = new System.Windows.Forms.Padding(4);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(7, 41);
            this.splitter2.TabIndex = 3;
            this.splitter2.TabStop = false;
            // 
            // BtnContracts
            // 
            this.BtnContracts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnContracts.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnContracts.Image = ((System.Drawing.Image)(resources.GetObject("BtnContracts.Image")));
            this.BtnContracts.Location = new System.Drawing.Point(188, 5);
            this.BtnContracts.Margin = new System.Windows.Forms.Padding(4);
            this.BtnContracts.Name = "BtnContracts";
            this.BtnContracts.Padding = new System.Windows.Forms.Padding(30, 0, 25, 0);
            this.BtnContracts.Size = new System.Drawing.Size(152, 41);
            this.BtnContracts.TabIndex = 2;
            this.BtnContracts.Text = "Umowy";
            this.BtnContracts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnContracts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnContracts.UseVisualStyleBackColor = true;
            this.BtnContracts.Click += new System.EventHandler(this.BtnContracts_Click);
            // 
            // splitter1
            // 
            this.splitter1.Enabled = false;
            this.splitter1.Location = new System.Drawing.Point(181, 5);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(7, 41);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // BtnEmployees
            // 
            this.BtnEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnEmployees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnEmployees.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnEmployees.Image = ((System.Drawing.Image)(resources.GetObject("BtnEmployees.Image")));
            this.BtnEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEmployees.Location = new System.Drawing.Point(5, 5);
            this.BtnEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEmployees.Name = "BtnEmployees";
            this.BtnEmployees.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.BtnEmployees.Size = new System.Drawing.Size(176, 41);
            this.BtnEmployees.TabIndex = 0;
            this.BtnEmployees.Text = "Pracownicy";
            this.BtnEmployees.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEmployees.UseCompatibleTextRendering = true;
            this.BtnEmployees.UseVisualStyleBackColor = false;
            this.BtnEmployees.Click += new System.EventHandler(this.BtnEmployees_Click);
            // 
            // Configuration
            // 
            this.Configuration.Location = new System.Drawing.Point(4, 26);
            this.Configuration.Margin = new System.Windows.Forms.Padding(4);
            this.Configuration.Name = "Configuration";
            this.Configuration.Padding = new System.Windows.Forms.Padding(4);
            this.Configuration.Size = new System.Drawing.Size(1157, 51);
            this.Configuration.TabIndex = 1;
            this.Configuration.Text = "Konfiguracja";
            this.Configuration.UseVisualStyleBackColor = true;
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsslVersion,
            this.TsslDatabase,
            this.TsslUser});
            this.ssMain.Location = new System.Drawing.Point(0, 712);
            this.ssMain.Name = "ssMain";
            this.ssMain.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.ssMain.Size = new System.Drawing.Size(1165, 22);
            this.ssMain.TabIndex = 1;
            this.ssMain.Text = "statusStrip1";
            // 
            // TsslVersion
            // 
            this.TsslVersion.Name = "TsslVersion";
            this.TsslVersion.Size = new System.Drawing.Size(81, 17);
            this.TsslVersion.Text = "Wersja: 1.0.0.0";
            // 
            // TsslDatabase
            // 
            this.TsslDatabase.Image = ((System.Drawing.Image)(resources.GetObject("TsslDatabase.Image")));
            this.TsslDatabase.Name = "TsslDatabase";
            this.TsslDatabase.Size = new System.Drawing.Size(141, 17);
            this.TsslDatabase.Text = "Baza: HumanResource";
            // 
            // TsslUser
            // 
            this.TsslUser.Image = ((System.Drawing.Image)(resources.GetObject("TsslUser.Image")));
            this.TsslUser.Name = "TsslUser";
            this.TsslUser.Size = new System.Drawing.Size(142, 17);
            this.TsslUser.Text = "Użytkownik: eskeemos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panel1.Controls.Add(this.MainTab);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 81);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1165, 631);
            this.panel1.TabIndex = 2;
            // 
            // MainTab
            // 
            this.MainTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTab.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.MainTab.ItemSize = new System.Drawing.Size(100, 22);
            this.MainTab.Location = new System.Drawing.Point(0, 0);
            this.MainTab.Name = "MainTab";
            this.MainTab.Padding = new System.Drawing.Point(20, 20);
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(1165, 631);
            this.MainTab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.MainTab.TabIndex = 0;
            this.MainTab.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.MainTab_DrawItem);
            this.MainTab.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainTab_MouseDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 734);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SystemHR";
            this.tabControl1.ResumeLayout(false);
            this.General.ResumeLayout(false);
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage General;
        private System.Windows.Forms.TabPage Configuration;
        private System.Windows.Forms.Button BtnContracts;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button BtnEmployees;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnPosition;
        private System.Windows.Forms.Splitter splitter5;
        private System.Windows.Forms.Button BtnDepartament;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.Button BtnSalaries;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Button BtnOrganizationStructure;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.ToolStripStatusLabel TsslVersion;
        private System.Windows.Forms.ToolStripStatusLabel TsslDatabase;
        private System.Windows.Forms.ToolStripStatusLabel TsslUser;
        private System.Windows.Forms.TabControl MainTab;
    }
}