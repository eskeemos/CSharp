using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemHR.UserInterface.Forms.Contracts;
using SystemHR.UserInterface.Forms.Employees;

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

            EmployeesForm form = new EmployeesForm();
            tabPage.Text = form.Text;
            form.TopLevel = false;
            form.Visible = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            MainTab.TabPages[0].Controls.Add(form);
        }

        private void BtnContracts_Click(object sender, EventArgs e)
        {
            TabPage tabPage = new TabPage();
            MainTab.Controls.Add(tabPage);

            ContractForm form = new ContractForm();
            tabPage.Text = form.Text;
            form.TopLevel = false;
            form.Visible = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            MainTab.TabPages[0].Controls.Add(form);
        }
        // 12.45
    }
}
