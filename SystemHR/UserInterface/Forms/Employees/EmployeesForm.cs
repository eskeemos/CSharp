using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemHR.UserInterface.Forms.Employees
{
    public partial class EmployeesForm : Form
    {
        private EmployeesForm()
        {
            InitializeComponent();
        }

        private static EmployeesForm instance = null;

        public static EmployeesForm Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new EmployeesForm();
                }
                return instance;
            }
        }
        public static bool IsNull
        {
            get
            {
                if (instance == null)
                {
                    return true;
                }
                return false;
            }
        }

        private void EmployeesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            instance = null;
        }
    }
}
