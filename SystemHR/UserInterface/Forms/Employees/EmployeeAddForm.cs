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
                epLastName.SetError(tbLastName, "Pole 'Nazwisko' jest wymagane.");
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
            MessageBox.Show("Pracownik został zapisany pomyślnie!");
            Close();
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
