
namespace SystemHR.UserInterface.Forms.Employees
{
    partial class EmployeesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesForm));
            this.tabEmployees = new System.Windows.Forms.TableLayoutPanel();
            this.panelEmployees = new System.Windows.Forms.Panel();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnDismiss = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.DGVEmployees = new System.Windows.Forms.DataGridView();
            this.BSEmployees = new System.Windows.Forms.BindingSource(this.components);
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabEmployees.SuspendLayout();
            this.panelEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // tabEmployees
            // 
            this.tabEmployees.ColumnCount = 1;
            this.tabEmployees.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabEmployees.Controls.Add(this.panelEmployees, 0, 0);
            this.tabEmployees.Controls.Add(this.DGVEmployees, 0, 1);
            this.tabEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabEmployees.Location = new System.Drawing.Point(0, 0);
            this.tabEmployees.Name = "tabEmployees";
            this.tabEmployees.RowCount = 2;
            this.tabEmployees.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tabEmployees.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabEmployees.Size = new System.Drawing.Size(800, 450);
            this.tabEmployees.TabIndex = 0;
            // 
            // panelEmployees
            // 
            this.panelEmployees.Controls.Add(this.btnSendEmail);
            this.panelEmployees.Controls.Add(this.btnRefresh);
            this.panelEmployees.Controls.Add(this.btnRemove);
            this.panelEmployees.Controls.Add(this.btnDismiss);
            this.panelEmployees.Controls.Add(this.btnModify);
            this.panelEmployees.Controls.Add(this.btnCreate);
            this.panelEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEmployees.Location = new System.Drawing.Point(3, 3);
            this.panelEmployees.Name = "panelEmployees";
            this.panelEmployees.Size = new System.Drawing.Size(794, 31);
            this.panelEmployees.TabIndex = 0;
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSendEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSendEmail.Image = ((System.Drawing.Image)(resources.GetObject("btnSendEmail.Image")));
            this.btnSendEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSendEmail.Location = new System.Drawing.Point(671, 0);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(123, 31);
            this.btnSendEmail.TabIndex = 5;
            this.btnSendEmail.Text = "Wyślij E-mail";
            this.btnSendEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSendEmail.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRefresh.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(344, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(95, 31);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Odswież";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRemove.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(273, 0);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(71, 31);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Usuń";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnDismiss
            // 
            this.btnDismiss.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDismiss.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDismiss.Image = ((System.Drawing.Image)(resources.GetObject("btnDismiss.Image")));
            this.btnDismiss.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDismiss.Location = new System.Drawing.Point(185, 0);
            this.btnDismiss.Name = "btnDismiss";
            this.btnDismiss.Size = new System.Drawing.Size(88, 31);
            this.btnDismiss.TabIndex = 2;
            this.btnDismiss.Text = "Zwolnij";
            this.btnDismiss.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDismiss.UseVisualStyleBackColor = true;
            // 
            // btnModify
            // 
            this.btnModify.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnModify.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnModify.Image = ((System.Drawing.Image)(resources.GetObject("btnModify.Image")));
            this.btnModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModify.Location = new System.Drawing.Point(83, 0);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(102, 31);
            this.btnModify.TabIndex = 1;
            this.btnModify.Text = "Modyfikuj";
            this.btnModify.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModify.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCreate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCreate.Image = ((System.Drawing.Image)(resources.GetObject("btnCreate.Image")));
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreate.Location = new System.Drawing.Point(0, 0);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(83, 31);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Dodaj";
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // DGVEmployees
            // 
            this.DGVEmployees.AllowUserToAddRows = false;
            this.DGVEmployees.AllowUserToDeleteRows = false;
            this.DGVEmployees.AutoGenerateColumns = false;
            this.DGVEmployees.BackgroundColor = System.Drawing.Color.White;
            this.DGVEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colLastName,
            this.colFirstName,
            this.colCode,
            this.colPosition,
            this.colStatus});
            this.DGVEmployees.DataSource = this.BSEmployees;
            this.DGVEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVEmployees.Location = new System.Drawing.Point(3, 40);
            this.DGVEmployees.Name = "DGVEmployees";
            this.DGVEmployees.ReadOnly = true;
            this.DGVEmployees.RowHeadersVisible = false;
            this.DGVEmployees.Size = new System.Drawing.Size(794, 407);
            this.DGVEmployees.TabIndex = 1;
            // 
            // BSEmployees
            // 
            this.BSEmployees.DataSource = typeof(SysetemHR.DataAccessLayer.ViewModel.EmployeeViewModel);
            // 
            // colID
            // 
            this.colID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colID.DataPropertyName = "ID";
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Visible = false;
            // 
            // colLastName
            // 
            this.colLastName.DataPropertyName = "LastName";
            this.colLastName.HeaderText = "Nazwisko";
            this.colLastName.Name = "colLastName";
            this.colLastName.ReadOnly = true;
            // 
            // colFirstName
            // 
            this.colFirstName.DataPropertyName = "FirstName";
            this.colFirstName.HeaderText = "Imię";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.ReadOnly = true;
            // 
            // colCode
            // 
            this.colCode.DataPropertyName = "Code";
            this.colCode.HeaderText = "Kod";
            this.colCode.Name = "colCode";
            this.colCode.ReadOnly = true;
            // 
            // colPosition
            // 
            this.colPosition.DataPropertyName = "Position";
            this.colPosition.HeaderText = "Stanowisko";
            this.colPosition.Name = "colPosition";
            this.colPosition.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStatus.DataPropertyName = "Status";
            this.colStatus.HeaderText = "Status Pracownika";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabEmployees);
            this.Name = "EmployeesForm";
            this.Text = "Pracownicy";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmployeesForm_FormClosed);
            this.tabEmployees.ResumeLayout(false);
            this.panelEmployees.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tabEmployees;
        private System.Windows.Forms.Panel panelEmployees;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnDismiss;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.DataGridView DGVEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource BSEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}