using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemHR.UserInterface.Forms.Base
{
    public partial class BaseAddEditButtons : BaseForm
    {
        public BaseAddEditButtons()
        {
            InitializeComponent();
        }
        protected virtual void Save() { }
        protected virtual void Cancel() { }
        private void BaseAddEditButtons_KeyDown(object sender, KeyEventArgs e)
        {
            if ((ModifierKeys == Keys.Control) && (e.KeyCode == Keys.Z))
            {
                Save();
            }
            if ((ModifierKeys == Keys.Control) && (e.KeyCode == Keys.A))
            {
                Cancel();
            }
            if(e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
