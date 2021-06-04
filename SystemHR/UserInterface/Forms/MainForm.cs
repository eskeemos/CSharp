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
using SystemHR.UserInterface.Helpers;

namespace SystemHR.UserInterface.Forms
{
    public partial class MainForm : Form
    {
        #region Fields

        private TabPage tab_Employees;
        private TabPage tab_Contract;

        #endregion
        #region Ctor
        public MainForm()
        {
            InitializeComponent();
        }

        #endregion
        #region Events

        private void BtnEmployees_Click(object sender, EventArgs e)
        {
            if (EmployeesForm.IsNull)
            {
                tab_Employees = new TabPage();
                ShowFormInTabPage(tab_Employees, EmployeesForm.Instance);
            }
            else
            {
                formArea.SelectedTab = tab_Employees;
            }
        }

        private void BtnContracts_Click(object sender, EventArgs e)
        {
            if (ContractForm.IsNull)
            {
                tab_Contract = new TabPage();
                ShowFormInTabPage(tab_Contract, ContractForm.Instance);
            }
            else
            {
                formArea.SelectedTab = tab_Contract;
            }
        }

        private void MainTab_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                var tabPage = this.formArea.TabPages[e.Index];
                var tabRect = this.formArea.GetTabRect(e.Index);
                tabRect.Inflate(-2, -2);
                {
                    var closeImage = new Bitmap($"{ResourcesHelper.ResourcesFilePath}\\{ResourcesHelper.CloseImage}");
                    e.Graphics.DrawImage(closeImage, (tabRect.Right - closeImage.Width) - 5, tabRect.Top + (tabRect.Height - closeImage.Height) / 2);
                    TextRenderer.DrawText(e.Graphics, tabPage.Text, tabPage.Font, tabRect, tabPage.ForeColor, TextFormatFlags.Left);
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        private void MainTab_MouseDown(object sender, MouseEventArgs e)
        {
            for (var i = 0; i < this.formArea.TabPages.Count; i++)
            {
                var tabRect = this.formArea.GetTabRect(i);
                tabRect.Inflate(-2, -2);
                var closeImage = new Bitmap($"{ResourcesHelper.ResourcesFilePath}\\{ResourcesHelper.CloseImage}");
                var imageRect = new Rectangle((tabRect.Right - closeImage.Width) - 5, tabRect.Top + (tabRect.Height - closeImage.Height) / 2, closeImage.Width, closeImage.Height);
                if (imageRect.Contains(e.Location))
                {
                    var form = formArea.TabPages[i].Controls[0] as Form;
                    form.Close();
                    this.formArea.TabPages.RemoveAt(i);
                    break;
                }
            }
        }

        #endregion
        #region Private Methods

        private void ShowFormInTabPage(TabPage tabPage, Form form)
        {
            formArea.Controls.Add(tabPage);

            tabPage.Text = form.Text;
            form.TopLevel = false;
            form.Visible = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            tabPage.Controls.Add(form);
            formArea.SelectedTab = tabPage;
        }

        #endregion
    }
}
