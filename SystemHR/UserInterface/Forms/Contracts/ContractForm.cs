using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemHR.UserInterface.Forms.Contracts
{
    public partial class ContractForm : Form
    {

        private static ContractForm instance = null;

        private ContractForm()
        {
            InitializeComponent();
        }

        public static ContractForm Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ContractForm();
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

        private void ContractForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            instance = null;
        }
    }
}
