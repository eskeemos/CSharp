using SysetemHR.DataAccessLayer;
using SysetemHR.DataAccessLayer.Models;
using SysetemHR.DataAccessLayer.Models.Dictionaries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemHR.UserInterface.Classes;
using SystemHR.UserInterface.Extensions;
using SystemHR.UserInterface.Forms.Base;
using SystemHR.UserInterface.Helpers;

namespace SystemHR.UserInterface.Forms.Employees
{
    public partial class EmployeeEditForm : BaseAddEditButtons
    {
        #region Fields
        private EmployeeModel employee;
        public EventHandler ReloadEmployees;
        #endregion
        #region Constructor
        public EmployeeEditForm(int employeeId)
            {
                InitializeComponent();
                InitializeData();
                employee = GlobalConfig.Connection.GetEmployee(employeeId);
                PrepareEmployeeData(employee);
                ValidateControls();
            }
        private void PrepareEmployeeData(EmployeeModel employee)
        {
            tbLastName.Text           = employee.LastName;
            tbFirstName.Text          = employee.FirstName;
            cbGender.Text             = employee.Gender != null ? employee.Gender.Value : null;
            dtpDateBirth.Value        = employee.DateBirth.Value;
            tbPesel.Text              = employee.PESEL;
            tbPhoneNumber.Text        = employee.PhoneNumber;
            tbEmailAdress.Text        = employee.EmailAdrress;
            tbIdentityCardNumber.Text = employee.IdentityCardNumber;
            dtpIssueDateIdentity.SetDateTimePickerValue(employee.DateBirth);
            dtpExpirationDateIdentity.SetDateTimePickerValue(employee.ExpirationDateIdentityCard);
            tbPassportNumber.Text = employee.PassportNumber;
            dtpIssueDatePassport.SetDateTimePickerValue(employee.IssueDatePassport);
            dtpExpirationDatePassport.SetDateTimePickerValue(employee.ExpirationDatePassport);

            lEmployee.Text = $"{employee.FirstName} {employee.LastName} ({employee.Code.ToString().PadLeft(4,'0')}) - {employee.Status}";
        }
        #endregion
        #region PrivateMethod
        private EmployeeModel GetFakeEmployee(int employeeId)
        {
            IList<EmployeeModel> fakeEmployeesModel = new List<EmployeeModel>()
            {
                new EmployeeModel()
                {
                    ID = 1,
                    LastName = "Karaś",
                    FirstName = "Ala",
                    Code = 1,
                    Gender = new GenderModel("Kobieta"),
                    DateBirth = new DateTime(1994,9,1),
                    PESEL = "12345678933",
                    PhoneNumber = "333456727",
                    EmailAdrress = "pKarasia@wp.pl",
                    IdentityCardNumber = "AWF123",
                    IssueDateIdentityCard = new DateTime(2012,9,12),
                    ExpirationDateIdentityCard = new DateTime(2022,5,5),
                    PassportNumber = "KSK221",
                    IssueDatePassport = new DateTime(2012,6,8),
                    ExpirationDatePassport = new DateTime(2031,2,2),
                    Status = new StatusModel("Wprowadzono")
                },
                new EmployeeModel()
                {
                    ID = 2,
                    LastName = "Benek",
                    FirstName = "Ewa",
                    Code = 2,
                    Gender = new GenderModel("Kobieta"),
                    DateBirth = new DateTime(1995,2,1),
                    PESEL = "23456789033",
                    PhoneNumber = "444567912",
                    EmailAdrress = "Benew@wp.pl",
                    IdentityCardNumber = "ASD123",
                    IssueDateIdentityCard = new DateTime(2015,2,7),
                    ExpirationDateIdentityCard = new DateTime(2025,1,10),
                    PassportNumber = "jkj221",
                    IssueDatePassport = new DateTime(2013,5,1),
                    ExpirationDatePassport = new DateTime(2021,6,6),
                    Status = new StatusModel("Wprowadzono")
                },
                new EmployeeModel()
                {
                    ID = 3,
                    LastName = "Marek",
                    FirstName = "Stan",
                    Code = 3,
                    Gender = new GenderModel("Mężczyzna"),
                    DateBirth = new DateTime(1996,1,6),
                    PESEL = "34567890121",
                    PhoneNumber = "881199012",
                    EmailAdrress = "StanMar@wp.pl",
                    IdentityCardNumber = "OOP123",
                    IssueDateIdentityCard = new DateTime(2010,9,12),
                    ExpirationDateIdentityCard = new DateTime(2032,5,5),
                    PassportNumber = "IOI123",
                    IssueDatePassport = new DateTime(2011,6,8),
                    ExpirationDatePassport = new DateTime(2035,2,2),
                    Status = new StatusModel("Wprowadzono")
                }
            };
            EmployeeModel fakeEmployeeModel = fakeEmployeesModel.Where((x) => x.ID == employeeId).FirstOrDefault();
            return fakeEmployeeModel;
        }
        private bool ValidateForm()
        {
            StringBuilder sbErrorMessage = new StringBuilder();

            string lastNameErrorMessage = epLastName.GetError(tbLastName);
            if (!string.IsNullOrWhiteSpace(lastNameErrorMessage))
            {
                sbErrorMessage.Append(lastNameErrorMessage);
            }
            string firstNameErrorMessage = epFirstName.GetError(tbFirstName);
            if (!string.IsNullOrWhiteSpace(firstNameErrorMessage))
            {
                sbErrorMessage.Append(firstNameErrorMessage);
            }
            if (sbErrorMessage.Length > 0)
            {
                MessageBox.Show(sbErrorMessage.ToString(),
                    "Dodawanie pracownika",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            string peselWarningMessage = epPesel.GetError(tbPesel);
            if (!string.IsNullOrWhiteSpace(peselWarningMessage))
            {
                DialogResult answer = MessageBox.Show(
                    peselWarningMessage + Environment.NewLine + "Czy mimo to chcesz dodać pracownika?",
                    "Dodawanie pracownika",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (answer == DialogResult.No)
                {
                    return false;
                }
            }
            return true;
        }
        private void InitializeData()
        {
            IList<GenderModel> genders = new List<GenderModel>()
            {
                new GenderModel("Kobieta"),
                new GenderModel("Mężczyzna"),
                new GenderModel("Nieokreślona")
            };
            bsGender.DataSource = genders;
            cbGender.Text = "Nieokreślona";

        }
        private void ValidateControls()
        {
            if (string.IsNullOrWhiteSpace(tbLastName.Text))
            {
                epLastName.SetError(tbLastName, "Pole 'Nazwisko' jest wymagane.\n");
            }
            else
            {
                epLastName.Clear();
            }
            if (string.IsNullOrWhiteSpace(tbFirstName.Text))
            {
                epFirstName.SetError(tbFirstName, "Pole 'Imię' jest wymagane.");
            }
            else
            {
                epFirstName.Clear();
            }
            if (!string.IsNullOrWhiteSpace(tbPesel.Text) && !ValidatorHelper.IsValidPESEL(tbPesel.Text))
            {
                epPesel.SetError(tbPesel, "Liczba cyfr dla numeru pesel jest nieprawidłowa.");
            }
            else
            {
                epPesel.Clear();
            }
        }
        #endregion
        #region Events
        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dtp = sender as DateTimePicker;
            dtp.DateTimePickerValueChange();
        }
        private void tbLastName_TextChanged(object sender, EventArgs e)
        {
            ValidateControls();
        }
        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {
            ValidateControls();
        }
        private void tbPesel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void tbPesel_Validated(object sender, EventArgs e)
        {
            string pesel = tbPesel.Text;
            if (!string.IsNullOrWhiteSpace(pesel) && !ValidatorHelper.IsValidPESEL(pesel))
            {
                epPesel.SetError(tbPesel, "Liczba cyfr dla numeru pesel jest nieprawidłowa.");
            }
            else
            {
                epPesel.Clear();
            }
        }
        private void bSave_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void bCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }
        #endregion
        #region Override
        protected override void Save()
        {
            if (ValidateForm())
            {

                employee.LastName = tbLastName.Text;
                employee.FirstName = tbFirstName.Text;
                employee.Gender = new GenderModel(cbGender.Text);
                employee.DateBirth = dtpDateBirth.Value;
                employee.PESEL = tbPesel.Text;
                employee.PhoneNumber = tbPhoneNumber.Text;
                employee.EmailAdrress = tbEmailAdress.Text;
                employee.IdentityCardNumber = tbIdentityCardNumber.Text;
                employee.IssueDateIdentityCard = dtpIssueDateIdentity.Value;
                employee.ExpirationDateIdentityCard = dtpExpirationDateIdentity.Value;
                employee.PassportNumber = tbPassportNumber.Text;
                employee.IssueDatePassport = dtpIssueDatePassport.Value;
                employee.ExpirationDatePassport = dtpExpirationDatePassport.Value;
                employee.Status = new StatusModel("Wprowadzony");
                

                // employee = CreateEmployee(employee)

                ReloadEmployees?.Invoke(bSave, new EmployeeEventArgs(employee));

                Close();
            }
        }
        protected override void Cancel()
        {
            MessageBox.Show("Operacja została anulowana!");
            Close();
        }
        #endregion
    }
}
