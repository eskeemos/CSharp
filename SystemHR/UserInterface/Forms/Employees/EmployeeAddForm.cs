using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemHR.UserInterface.Forms.Base;

namespace SystemHR.UserInterface.Forms.Employees
{
    public partial class EmployeeAddForm : BaseAddEditButtons
    {
        public EmployeeAddForm()
        {
            InitializeComponent();
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
    }
}
