using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemHR.UserInterface.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnEmployees_Click(object sender, EventArgs e)
        {
            TabPage tabPage = new TabPage();
            MainTab.Controls.Add(tabPage);

            Form form = new Form();
            form.Text = "Zakładka";
            form.TopLevel = false;
            form.Visible = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            MainTab.TabPages[0].Controls.Add(form);
        }
    }
}
