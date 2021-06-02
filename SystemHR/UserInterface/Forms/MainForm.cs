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
        private string closeButtonFullPath = "C:\\Users\\krzys\\Desktop\\CSharp\\SystemHR\\resources\\esc.png";
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

        private void MainTab_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                var tabPage = this.MainTab.TabPages[e.Index];
                var tabRect = this.MainTab.GetTabRect(e.Index);
                tabRect.Inflate(-2, -2);
                {
                    var closeImage = new Bitmap(closeButtonFullPath);
                    e.Graphics.DrawImage(closeImage,
                        (tabRect.Right - closeImage.Width),
                        tabRect.Top + (tabRect.Height - closeImage.Height) / 2);
                    TextRenderer.DrawText(e.Graphics, tabPage.Text, tabPage.Font,
                        tabRect, tabPage.ForeColor, TextFormatFlags.Left);
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        private void MainTab_MouseDown(object sender, MouseEventArgs e)
        {
            for (var i = 0; i < this.MainTab.TabPages.Count - 1; i++)
            {
                var tabRect = this.MainTab.GetTabRect(i);
                tabRect.Inflate(-2, -2);
                var closeImage = new Bitmap(closeButtonFullPath);
                var imageRect = new Rectangle(
                    (tabRect.Right - closeImage.Width),
                    tabRect.Top + (tabRect.Height - closeImage.Height) / 2,
                    closeImage.Width,
                    closeImage.Height);
                if (imageRect.Contains(e.Location))
                {
                    this.MainTab.TabPages.RemoveAt(i);
                    break;
                }
            }
        }

        private void BtnOrganizationStructure_Click(object sender, EventArgs e)
        {
            /*
            TabPage tabPage = new TabPage();
            MainTab.Controls.Add(tabPage);

            ContractForm form = new ContractForm();
            tabPage.Text = form.Text;
            form.TopLevel = false;
            form.Visible = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            MainTab.TabPages[0].Controls.Add(form);
            */
        }
    }
}
