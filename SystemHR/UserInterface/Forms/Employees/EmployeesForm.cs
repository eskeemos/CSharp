using SysetemHR.DataAccessLayer.Models;
using SysetemHR.DataAccessLayer.Models.Dictionaries;
using SysetemHR.DataAccessLayer.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using SystemHR.UserInterface.Classes;
using SystemHR.UserInterface.Forms.Base;
using SystemHR.UserInterface.Helpers;

namespace SystemHR.UserInterface.Forms.Employees
{
    public partial class EmployeesForm : BaseForm
    {
        #region Fields
        private static EmployeesForm instance = null;
        private static IList<EmployeeViewModel> fakeEmployees;
        #endregion
        #region Properties
        public static EmployeesForm Instance
        {
            get
            {
                if (instance == null)
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
        #endregion
        #region Constructor
        private EmployeesForm()
        {
            InitializeComponent();
            fakeEmployees = GetFakeEmployees();
            PrepareEmployeesData();
        }
        #endregion
        #region PrivateMethods
        private IList<EmployeeViewModel> GetFakeEmployees()
        {
            IList<EmployeeModel> fakeEmployeesModel = new List<EmployeeModel>()
            {
                new EmployeeModel()
                {
                    ID = 1,
                    LastName = "Andrzejewski",
                    FirstName = "Paweł",
                    Code = 1,
                    Gender = new GenderModel("mężczyzna"),
                    DateBirth = new DateTime(1994,9,1),
                    PESEL = "94090142830",
                    PhoneNumber = "665988254",
                    EmailAdrress = "p.andrzejewski@gmail.com",
                    IdentityCardNumber = "AWR204120",
                    IssueDateIdentityCard = new DateTime(2012,9,15),
                    ExpirationDateIdentityCard = new DateTime(2032,9,15),
                    PassportNumber = "ER8984510",
                    IssueDatePassport = new DateTime(2015,5,23),
                    ExpirationDatePassport = new DateTime(2025,5,23),
                    Status = new StatusModel("Wprowadzony")
                },
                 new EmployeeModel()
                {
                    ID = 2,
                    LastName = "Bedanerek",
                    FirstName = "Damian",
                    Code = 2,
                    Gender = new GenderModel("mężczyzna"),
                    DateBirth = new DateTime(1990,9,14),
                    PESEL = "90091444249",
                    PhoneNumber = "754952134",
                    EmailAdrress = "d.bednarek@gmail.com",
                    Status = new StatusModel("Wprowadzony")
                },
                new EmployeeModel()
                {
                    ID = 3,
                    LastName = "Szczepaniak",
                    FirstName = "Katarzyna",
                    Code = 3,
                    Gender = new GenderModel("kobieta"),
                    DateBirth = new DateTime(1995,10,13),
                    PESEL = "95101361886",
                    PhoneNumber = "852745984",
                    EmailAdrress = "k.szczepaniak@gmail.com",
                    Status = new StatusModel("Wprowadzony")
                }
            };
            return MapingHelper.MapEmployeeModelToEmployeeViewModel(fakeEmployeesModel);
        }
        private void PrepareEmployeesData()
        {
            var fakeEmployeesSorted = fakeEmployees.OrderBy((x) => x.Code).ToList();
            BSEmployees.DataSource = new BindingList<EmployeeViewModel>(fakeEmployeesSorted);
            DGVEmployees.DataSource = BSEmployees;
        }
        #endregion
        #region Events
        private void EmployeesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            instance = null;
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            EmployeeAddForm form = new EmployeeAddForm();
            form.ReloadEmployees += (s, ea) =>
            {
                EmployeeEventArgs eventArgs = ea as EmployeeEventArgs;
                if (eventArgs != null)
                {
                    EmployeeViewModel employee = MapingHelper.MapEmployeeModelToEmployeeViewModel(eventArgs.Employee);
                    BSEmployees.Add(employee);

                    DGVEmployees.ClearSelection();
                    DGVEmployees.Rows[DGVEmployees.Rows.Count - 1].Selected = true;
                }
            };
            form.ShowDialog();
        }
        private void bModify_Click(object sender, EventArgs e)
        {
            // int employeeID = (int)this.DGVEmployees.CurrentRow.Cells["Code"].Value;
            int employeeID = 1;
            EmployeeEditForm form = new EmployeeEditForm(employeeID);
            form.ShowDialog();
        }
        #endregion
    }
}
