using SysetemHR.DataAccessLayer;
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
    public partial class BaseForm : Form
    {
        protected SqlConnector sqlCon { get; private set; }
        public BaseForm()
        {
            InitializeComponent();
            // sqlCon = new SqlConnector();
        }
    }
}
