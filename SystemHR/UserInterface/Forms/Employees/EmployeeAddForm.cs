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
using SystemHR.UserInterface.Extensions;
using SystemHR.UserInterface.Forms.Base;
using SystemHR.UserInterface.Helpers;

namespace SystemHR.UserInterface.Forms.Employees
{
    public partial class EmployeeAddForm : BaseAddEditButtons
    {
        public EmployeeAddForm()
        {
            InitializeComponent();
            InitializeData();
            ValidateControls();
;        }

        private void ValidateControls()
        {
            if(string.IsNullOrWhiteSpace(tbLastName.Text))
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

        private void bSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }
        protected override void Save()
        {
            if(ValidateForm())
            {
                EmployeeModel employee = new EmployeeModel()
                {
                    LastName = tbLastName.Text,
                    FirstName = tbFirstName.Text,
                    Gender = new GenderModel(cbGender.Text),
                    DateBirth = dtpDateBirth.Value,
                    PESEL = tbPesel.Text,
                    PhoneNumber = tbPhoneNumber.Text,
                    EmailAdrress = tbEmailAdress.Text,
                    IdentityCardNumber = tbIdentityCardNumber.Text,
                    IssueDateIdentityCard = dtpIssueDateIdentity.Value,
                    ExpirationDateIdentityCard = dtpExpirationDateIdentity.Value,
                    PassportNumber = tbPassportNumber.Text,
                    IssueDatePassport = dtpIssueDatePassport.Value,
                    ExpirationDatePassport = dtpExpirationDatePassport.Value,
                    Status = new StatusModel("Wprowadzony")
                };

                // employee = CreateEmployee(employee)
                employee.ID = 4;
                employee.Code = 4;
                Close();
            }
        }

        private bool ValidateForm()
        {
            StringBuilder sbErrorMessage = new StringBuilder();

            string lastNameErrorMessage = epLastName.GetError(tbLastName);
            if(!string.IsNullOrWhiteSpace(lastNameErrorMessage))
            {
                sbErrorMessage.Append(lastNameErrorMessage);
            }
            string firstNameErrorMessage = epFirstName.GetError(tbFirstName);
            if (!string.IsNullOrWhiteSpace(firstNameErrorMessage))
            {
                sbErrorMessage.Append(firstNameErrorMessage);
            }
            if(sbErrorMessage.Length > 0)
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
                if(answer == DialogResult.No)
                {
                    return false;
                }
            }
            return true;
        }

        protected override void Cancel()
        {
            MessageBox.Show("Operacja została anulowana!");
            Close();
        }

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
                epPesel.SetError(tbPesel,"Liczba cyfr dla numeru pesel jest nieprawidłowa.");
            }
            else
            {
                epPesel.Clear();
            }
        }
        //26.01
    }
}
