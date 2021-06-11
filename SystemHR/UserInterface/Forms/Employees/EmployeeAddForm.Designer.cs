
namespace SystemHR.UserInterface.Forms.Employees
{
    partial class EmployeeAddForm
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
            this.lDaneIdentyfikacyjne = new System.Windows.Forms.Label();
            this.gpDaneIdentyfikacyjne = new System.Windows.Forms.GroupBox();
            this.dtpDateBirth = new System.Windows.Forms.DateTimePicker();
            this.tbPesel = new System.Windows.Forms.TextBox();
            this.lPesel = new System.Windows.Forms.Label();
            this.lDateBirth = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.bsGender = new System.Windows.Forms.BindingSource(this.components);
            this.lGender = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lFirstName = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lLastName = new System.Windows.Forms.Label();
            this.gbContact = new System.Windows.Forms.GroupBox();
            this.tbEmailAdress = new System.Windows.Forms.TextBox();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.lTelephoneNumber = new System.Windows.Forms.Label();
            this.lEmailAdrress = new System.Windows.Forms.Label();
            this.gbIdentityCard = new System.Windows.Forms.GroupBox();
            this.dtpExpirationDateIdentity = new System.Windows.Forms.DateTimePicker();
            this.dtpIssueDateIdentity = new System.Windows.Forms.DateTimePicker();
            this.lExpirationDateIdentityCard = new System.Windows.Forms.Label();
            this.lIssueDateIdentityCard = new System.Windows.Forms.Label();
            this.tbIdentityCardNumber = new System.Windows.Forms.TextBox();
            this.lIdentityCardNumber = new System.Windows.Forms.Label();
            this.gbPassport = new System.Windows.Forms.GroupBox();
            this.dtpExpirationDatePassport = new System.Windows.Forms.DateTimePicker();
            this.dtpIssueDatePassport = new System.Windows.Forms.DateTimePicker();
            this.lExpirationDatePassport = new System.Windows.Forms.Label();
            this.lIssueDatePassport = new System.Windows.Forms.Label();
            this.tbPassportNumber = new System.Windows.Forms.TextBox();
            this.lPassportNumber = new System.Windows.Forms.Label();
            this.bSave = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.epLastName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epFirstName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPesel = new System.Windows.Forms.ErrorProvider(this.components);
            this.gpDaneIdentyfikacyjne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsGender)).BeginInit();
            this.gbContact.SuspendLayout();
            this.gbIdentityCard.SuspendLayout();
            this.gbPassport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPesel)).BeginInit();
            this.SuspendLayout();
            // 
            // lDaneIdentyfikacyjne
            // 
            this.lDaneIdentyfikacyjne.AutoSize = true;
            this.lDaneIdentyfikacyjne.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lDaneIdentyfikacyjne.Location = new System.Drawing.Point(20, 20);
            this.lDaneIdentyfikacyjne.Name = "lDaneIdentyfikacyjne";
            this.lDaneIdentyfikacyjne.Size = new System.Drawing.Size(174, 21);
            this.lDaneIdentyfikacyjne.TabIndex = 0;
            this.lDaneIdentyfikacyjne.Text = "Dane identyfikacyjne";
            // 
            // gpDaneIdentyfikacyjne
            // 
            this.gpDaneIdentyfikacyjne.BackColor = System.Drawing.Color.White;
            this.gpDaneIdentyfikacyjne.Controls.Add(this.dtpDateBirth);
            this.gpDaneIdentyfikacyjne.Controls.Add(this.tbPesel);
            this.gpDaneIdentyfikacyjne.Controls.Add(this.lPesel);
            this.gpDaneIdentyfikacyjne.Controls.Add(this.lDateBirth);
            this.gpDaneIdentyfikacyjne.Controls.Add(this.cbGender);
            this.gpDaneIdentyfikacyjne.Controls.Add(this.lGender);
            this.gpDaneIdentyfikacyjne.Controls.Add(this.tbFirstName);
            this.gpDaneIdentyfikacyjne.Controls.Add(this.lFirstName);
            this.gpDaneIdentyfikacyjne.Controls.Add(this.tbLastName);
            this.gpDaneIdentyfikacyjne.Controls.Add(this.lLastName);
            this.gpDaneIdentyfikacyjne.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gpDaneIdentyfikacyjne.Location = new System.Drawing.Point(24, 53);
            this.gpDaneIdentyfikacyjne.Name = "gpDaneIdentyfikacyjne";
            this.gpDaneIdentyfikacyjne.Size = new System.Drawing.Size(271, 189);
            this.gpDaneIdentyfikacyjne.TabIndex = 1;
            this.gpDaneIdentyfikacyjne.TabStop = false;
            this.gpDaneIdentyfikacyjne.Text = "Ogólne";
            // 
            // dtpDateBirth
            // 
            this.dtpDateBirth.CustomFormat = " ";
            this.dtpDateBirth.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpDateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateBirth.Location = new System.Drawing.Point(128, 116);
            this.dtpDateBirth.Name = "dtpDateBirth";
            this.dtpDateBirth.Size = new System.Drawing.Size(125, 23);
            this.dtpDateBirth.TabIndex = 16;
            this.dtpDateBirth.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpDateBirth.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // tbPesel
            // 
            this.tbPesel.Location = new System.Drawing.Point(128, 145);
            this.tbPesel.Margin = new System.Windows.Forms.Padding(10);
            this.tbPesel.Name = "tbPesel";
            this.tbPesel.Size = new System.Drawing.Size(125, 23);
            this.tbPesel.TabIndex = 10;
            this.tbPesel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPesel_KeyPress);
            this.tbPesel.Validated += new System.EventHandler(this.tbPesel_Validated);
            // 
            // lPesel
            // 
            this.lPesel.AutoSize = true;
            this.lPesel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lPesel.Location = new System.Drawing.Point(11, 148);
            this.lPesel.Margin = new System.Windows.Forms.Padding(8);
            this.lPesel.Name = "lPesel";
            this.lPesel.Size = new System.Drawing.Size(40, 17);
            this.lPesel.TabIndex = 9;
            this.lPesel.Text = "Pesel";
            // 
            // lDateBirth
            // 
            this.lDateBirth.AutoSize = true;
            this.lDateBirth.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lDateBirth.Location = new System.Drawing.Point(11, 121);
            this.lDateBirth.Margin = new System.Windows.Forms.Padding(8);
            this.lDateBirth.Name = "lDateBirth";
            this.lDateBirth.Size = new System.Drawing.Size(109, 17);
            this.lDateBirth.TabIndex = 8;
            this.lDateBirth.Text = "Data urodzenia";
            // 
            // cbGender
            // 
            this.cbGender.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsGender, "Value", true));
            this.cbGender.DataSource = this.bsGender;
            this.cbGender.DisplayMember = "Value";
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(128, 86);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(125, 24);
            this.cbGender.TabIndex = 2;
            this.cbGender.ValueMember = "Value";
            // 
            // bsGender
            // 
            this.bsGender.DataSource = typeof(SysetemHR.DataAccessLayer.Models.Dictionaries.GenderModel);
            // 
            // lGender
            // 
            this.lGender.AutoSize = true;
            this.lGender.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lGender.Location = new System.Drawing.Point(11, 89);
            this.lGender.Margin = new System.Windows.Forms.Padding(8);
            this.lGender.Name = "lGender";
            this.lGender.Size = new System.Drawing.Size(36, 17);
            this.lGender.TabIndex = 6;
            this.lGender.Text = "Płeć";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(128, 57);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(125, 23);
            this.tbFirstName.TabIndex = 5;
            this.tbFirstName.TextChanged += new System.EventHandler(this.tbFirstName_TextChanged);
            // 
            // lFirstName
            // 
            this.lFirstName.AutoSize = true;
            this.lFirstName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lFirstName.Location = new System.Drawing.Point(11, 60);
            this.lFirstName.Margin = new System.Windows.Forms.Padding(8);
            this.lFirstName.Name = "lFirstName";
            this.lFirstName.Size = new System.Drawing.Size(36, 16);
            this.lFirstName.TabIndex = 4;
            this.lFirstName.Text = "Imię";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(128, 28);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(125, 23);
            this.tbLastName.TabIndex = 3;
            this.tbLastName.TextChanged += new System.EventHandler(this.tbLastName_TextChanged);
            // 
            // lLastName
            // 
            this.lLastName.AutoSize = true;
            this.lLastName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lLastName.Location = new System.Drawing.Point(11, 31);
            this.lLastName.Margin = new System.Windows.Forms.Padding(10);
            this.lLastName.Name = "lLastName";
            this.lLastName.Size = new System.Drawing.Size(69, 16);
            this.lLastName.TabIndex = 2;
            this.lLastName.Text = "Nazwisko";
            // 
            // gbContact
            // 
            this.gbContact.Controls.Add(this.tbEmailAdress);
            this.gbContact.Controls.Add(this.tbPhoneNumber);
            this.gbContact.Controls.Add(this.lTelephoneNumber);
            this.gbContact.Controls.Add(this.lEmailAdrress);
            this.gbContact.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbContact.Location = new System.Drawing.Point(24, 246);
            this.gbContact.Name = "gbContact";
            this.gbContact.Size = new System.Drawing.Size(271, 95);
            this.gbContact.TabIndex = 2;
            this.gbContact.TabStop = false;
            this.gbContact.Text = "Kontakt";
            // 
            // tbEmailAdress
            // 
            this.tbEmailAdress.Location = new System.Drawing.Point(128, 56);
            this.tbEmailAdress.Name = "tbEmailAdress";
            this.tbEmailAdress.Size = new System.Drawing.Size(125, 23);
            this.tbEmailAdress.TabIndex = 6;
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(128, 27);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(125, 23);
            this.tbPhoneNumber.TabIndex = 5;
            // 
            // lTelephoneNumber
            // 
            this.lTelephoneNumber.AutoSize = true;
            this.lTelephoneNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lTelephoneNumber.Location = new System.Drawing.Point(13, 30);
            this.lTelephoneNumber.Margin = new System.Windows.Forms.Padding(10);
            this.lTelephoneNumber.Name = "lTelephoneNumber";
            this.lTelephoneNumber.Size = new System.Drawing.Size(108, 17);
            this.lTelephoneNumber.TabIndex = 4;
            this.lTelephoneNumber.Text = "Numer Telefonu";
            // 
            // lEmailAdrress
            // 
            this.lEmailAdrress.AutoSize = true;
            this.lEmailAdrress.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lEmailAdrress.Location = new System.Drawing.Point(13, 59);
            this.lEmailAdrress.Margin = new System.Windows.Forms.Padding(10);
            this.lEmailAdrress.Name = "lEmailAdrress";
            this.lEmailAdrress.Size = new System.Drawing.Size(86, 17);
            this.lEmailAdrress.TabIndex = 3;
            this.lEmailAdrress.Text = "Adres E-mail";
            // 
            // gbIdentityCard
            // 
            this.gbIdentityCard.Controls.Add(this.dtpExpirationDateIdentity);
            this.gbIdentityCard.Controls.Add(this.dtpIssueDateIdentity);
            this.gbIdentityCard.Controls.Add(this.lExpirationDateIdentityCard);
            this.gbIdentityCard.Controls.Add(this.lIssueDateIdentityCard);
            this.gbIdentityCard.Controls.Add(this.tbIdentityCardNumber);
            this.gbIdentityCard.Controls.Add(this.lIdentityCardNumber);
            this.gbIdentityCard.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbIdentityCard.Location = new System.Drawing.Point(311, 53);
            this.gbIdentityCard.Name = "gbIdentityCard";
            this.gbIdentityCard.Size = new System.Drawing.Size(270, 120);
            this.gbIdentityCard.TabIndex = 3;
            this.gbIdentityCard.TabStop = false;
            this.gbIdentityCard.Text = "Dowód osobisty";
            // 
            // dtpExpirationDateIdentity
            // 
            this.dtpExpirationDateIdentity.CustomFormat = " ";
            this.dtpExpirationDateIdentity.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpirationDateIdentity.Location = new System.Drawing.Point(132, 80);
            this.dtpExpirationDateIdentity.Name = "dtpExpirationDateIdentity";
            this.dtpExpirationDateIdentity.Size = new System.Drawing.Size(125, 23);
            this.dtpExpirationDateIdentity.TabIndex = 10;
            this.dtpExpirationDateIdentity.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpExpirationDateIdentity.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // dtpIssueDateIdentity
            // 
            this.dtpIssueDateIdentity.CustomFormat = " ";
            this.dtpIssueDateIdentity.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpIssueDateIdentity.Location = new System.Drawing.Point(132, 51);
            this.dtpIssueDateIdentity.Name = "dtpIssueDateIdentity";
            this.dtpIssueDateIdentity.Size = new System.Drawing.Size(125, 23);
            this.dtpIssueDateIdentity.TabIndex = 9;
            this.dtpIssueDateIdentity.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpIssueDateIdentity.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // lExpirationDateIdentityCard
            // 
            this.lExpirationDateIdentityCard.AutoSize = true;
            this.lExpirationDateIdentityCard.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lExpirationDateIdentityCard.Location = new System.Drawing.Point(6, 85);
            this.lExpirationDateIdentityCard.Name = "lExpirationDateIdentityCard";
            this.lExpirationDateIdentityCard.Size = new System.Drawing.Size(104, 17);
            this.lExpirationDateIdentityCard.TabIndex = 6;
            this.lExpirationDateIdentityCard.Text = "Dara ważności";
            // 
            // lIssueDateIdentityCard
            // 
            this.lIssueDateIdentityCard.AutoSize = true;
            this.lIssueDateIdentityCard.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lIssueDateIdentityCard.Location = new System.Drawing.Point(6, 56);
            this.lIssueDateIdentityCard.Name = "lIssueDateIdentityCard";
            this.lIssueDateIdentityCard.Size = new System.Drawing.Size(101, 17);
            this.lIssueDateIdentityCard.TabIndex = 5;
            this.lIssueDateIdentityCard.Text = "Data wydania";
            // 
            // tbIdentityCardNumber
            // 
            this.tbIdentityCardNumber.Location = new System.Drawing.Point(132, 24);
            this.tbIdentityCardNumber.Name = "tbIdentityCardNumber";
            this.tbIdentityCardNumber.Size = new System.Drawing.Size(125, 23);
            this.tbIdentityCardNumber.TabIndex = 4;
            // 
            // lIdentityCardNumber
            // 
            this.lIdentityCardNumber.AutoSize = true;
            this.lIdentityCardNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lIdentityCardNumber.Location = new System.Drawing.Point(6, 27);
            this.lIdentityCardNumber.Name = "lIdentityCardNumber";
            this.lIdentityCardNumber.Size = new System.Drawing.Size(111, 17);
            this.lIdentityCardNumber.TabIndex = 0;
            this.lIdentityCardNumber.Text = "Numer dowodu";
            // 
            // gbPassport
            // 
            this.gbPassport.Controls.Add(this.dtpExpirationDatePassport);
            this.gbPassport.Controls.Add(this.dtpIssueDatePassport);
            this.gbPassport.Controls.Add(this.lExpirationDatePassport);
            this.gbPassport.Controls.Add(this.lIssueDatePassport);
            this.gbPassport.Controls.Add(this.tbPassportNumber);
            this.gbPassport.Controls.Add(this.lPassportNumber);
            this.gbPassport.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbPassport.Location = new System.Drawing.Point(311, 184);
            this.gbPassport.Name = "gbPassport";
            this.gbPassport.Size = new System.Drawing.Size(270, 126);
            this.gbPassport.TabIndex = 4;
            this.gbPassport.TabStop = false;
            this.gbPassport.Text = "Paszport";
            // 
            // dtpExpirationDatePassport
            // 
            this.dtpExpirationDatePassport.CustomFormat = " ";
            this.dtpExpirationDatePassport.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpirationDatePassport.Location = new System.Drawing.Point(132, 80);
            this.dtpExpirationDatePassport.Name = "dtpExpirationDatePassport";
            this.dtpExpirationDatePassport.Size = new System.Drawing.Size(125, 23);
            this.dtpExpirationDatePassport.TabIndex = 16;
            this.dtpExpirationDatePassport.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpExpirationDatePassport.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // dtpIssueDatePassport
            // 
            this.dtpIssueDatePassport.CustomFormat = " ";
            this.dtpIssueDatePassport.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpIssueDatePassport.Location = new System.Drawing.Point(132, 53);
            this.dtpIssueDatePassport.Name = "dtpIssueDatePassport";
            this.dtpIssueDatePassport.Size = new System.Drawing.Size(125, 23);
            this.dtpIssueDatePassport.TabIndex = 15;
            this.dtpIssueDatePassport.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpIssueDatePassport.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // lExpirationDatePassport
            // 
            this.lExpirationDatePassport.AutoSize = true;
            this.lExpirationDatePassport.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lExpirationDatePassport.Location = new System.Drawing.Point(6, 85);
            this.lExpirationDatePassport.Name = "lExpirationDatePassport";
            this.lExpirationDatePassport.Size = new System.Drawing.Size(104, 17);
            this.lExpirationDatePassport.TabIndex = 12;
            this.lExpirationDatePassport.Text = "Dara ważności";
            // 
            // lIssueDatePassport
            // 
            this.lIssueDatePassport.AutoSize = true;
            this.lIssueDatePassport.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lIssueDatePassport.Location = new System.Drawing.Point(6, 56);
            this.lIssueDatePassport.Name = "lIssueDatePassport";
            this.lIssueDatePassport.Size = new System.Drawing.Size(101, 17);
            this.lIssueDatePassport.TabIndex = 11;
            this.lIssueDatePassport.Text = "Data wydania";
            // 
            // tbPassportNumber
            // 
            this.tbPassportNumber.Location = new System.Drawing.Point(132, 24);
            this.tbPassportNumber.Name = "tbPassportNumber";
            this.tbPassportNumber.Size = new System.Drawing.Size(125, 23);
            this.tbPassportNumber.TabIndex = 10;
            // 
            // lPassportNumber
            // 
            this.lPassportNumber.AutoSize = true;
            this.lPassportNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lPassportNumber.Location = new System.Drawing.Point(6, 27);
            this.lPassportNumber.Name = "lPassportNumber";
            this.lPassportNumber.Size = new System.Drawing.Size(119, 17);
            this.lPassportNumber.TabIndex = 9;
            this.lPassportNumber.Text = "Numer paszportu";
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(311, 316);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(133, 40);
            this.bSave.TabIndex = 5;
            this.bSave.Text = "Zapisz";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(450, 316);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(131, 40);
            this.bCancel.TabIndex = 6;
            this.bCancel.Text = "Anuluj";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1, 1);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(1, 1);
            this.textBox3.TabIndex = 1;
            // 
            // epLastName
            // 
            this.epLastName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epLastName.ContainerControl = this;
            // 
            // epFirstName
            // 
            this.epFirstName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epFirstName.ContainerControl = this;
            // 
            // epPesel
            // 
            this.epPesel.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epPesel.ContainerControl = this;
            // 
            // EmployeeAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 371);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.gbPassport);
            this.Controls.Add(this.gbIdentityCard);
            this.Controls.Add(this.gbContact);
            this.Controls.Add(this.gpDaneIdentyfikacyjne);
            this.Controls.Add(this.lDaneIdentyfikacyjne);
            this.KeyPreview = true;
            this.Name = "EmployeeAddForm";
            this.Text = "Dodaj pracownika";
            this.gpDaneIdentyfikacyjne.ResumeLayout(false);
            this.gpDaneIdentyfikacyjne.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsGender)).EndInit();
            this.gbContact.ResumeLayout(false);
            this.gbContact.PerformLayout();
            this.gbIdentityCard.ResumeLayout(false);
            this.gbIdentityCard.PerformLayout();
            this.gbPassport.ResumeLayout(false);
            this.gbPassport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPesel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lDaneIdentyfikacyjne;
        private System.Windows.Forms.GroupBox gpDaneIdentyfikacyjne;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lLastName;
        private System.Windows.Forms.Label lDateBirth;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label lGender;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lFirstName;
        private System.Windows.Forms.TextBox tbPesel;
        private System.Windows.Forms.Label lPesel;
        private System.Windows.Forms.GroupBox gbContact;
        private System.Windows.Forms.TextBox tbEmailAdress;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.Label lTelephoneNumber;
        private System.Windows.Forms.Label lEmailAdrress;
        private System.Windows.Forms.GroupBox gbIdentityCard;
        private System.Windows.Forms.Label lExpirationDateIdentityCard;
        private System.Windows.Forms.Label lIssueDateIdentityCard;
        private System.Windows.Forms.TextBox tbIdentityCardNumber;
        private System.Windows.Forms.Label lIdentityCardNumber;
        private System.Windows.Forms.GroupBox gbPassport;
        private System.Windows.Forms.Label lExpirationDatePassport;
        private System.Windows.Forms.Label lIssueDatePassport;
        private System.Windows.Forms.TextBox tbPassportNumber;
        private System.Windows.Forms.Label lPassportNumber;
        private System.Windows.Forms.DateTimePicker dtpDateBirth;
        private System.Windows.Forms.DateTimePicker dtpExpirationDateIdentity;
        private System.Windows.Forms.DateTimePicker dtpIssueDateIdentity;
        private System.Windows.Forms.DateTimePicker dtpExpirationDatePassport;
        private System.Windows.Forms.DateTimePicker dtpIssueDatePassport;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.BindingSource bsGender;
        private System.Windows.Forms.ErrorProvider epLastName;
        private System.Windows.Forms.ErrorProvider epFirstName;
        private System.Windows.Forms.ErrorProvider epPesel;
    }
}