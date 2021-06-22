using SysetemHR.DataAccessLayer;
using SysetemHR.DataAccessLayer.Models;
using SysetemHR.DataAccessLayer.Models.Dictionaries;
using SysetemHR.DataAccessLayer.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            IEnumerable<EmployeeModel> employees = GlobalConfig.Connection.GetEmployees();
            fakeEmployees = MapingHelper.MapEmployeeModelToEmployeeViewModel(employees.ToList());
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
                    LastName = "Karaś",
                    FirstName = "Ala",
                    Code = 1,
                    Gender = new GenderModel("Kobieta"),
                    DateBirth = new DateTime(1994,9,1),
                    PESEL = "12345678933",
                    PhoneNumber = "333456727",
                    EmailAdrress = "pKarasia@wp.pl",
                    IdentityCardNumber = "AWF123",
                    IssueDateIdentityCard = new DateTime(2012,9,12),
                    ExpirationDateIdentityCard = new DateTime(2022,5,5),
                    PassportNumber = "KSK221",
                    IssueDatePassport = new DateTime(2012,6,8),
                    ExpirationDatePassport = new DateTime(2031,2,2),
                    Status = new StatusModel("Wprowadzono")
                },
                new EmployeeModel()
                {
                    ID = 2,
                    LastName = "Benek",
                    FirstName = "Ewa",
                    Code = 2,
                    Gender = new GenderModel("Kobieta"),
                    DateBirth = new DateTime(1995,2,1),
                    PESEL = "23456789033",
                    PhoneNumber = "444567912",
                    EmailAdrress = "Benew@wp.pl",
                    IdentityCardNumber = "ASD123",
                    IssueDateIdentityCard = new DateTime(2015,2,7),
                    ExpirationDateIdentityCard = new DateTime(2025,1,10),
                    PassportNumber = "jkj221",
                    IssueDatePassport = new DateTime(2013,5,1),
                    ExpirationDatePassport = new DateTime(2021,6,6),
                    Status = new StatusModel("Wprowadzono")
                },
                new EmployeeModel()
                {
                    ID = 3,
                    LastName = "Marek",
                    FirstName = "Stan",
                    Code = 3,
                    Gender = new GenderModel("Mężczyzna"),
                    DateBirth = new DateTime(1996,1,6),
                    PESEL = "34567890121",
                    PhoneNumber = "881199012",
                    EmailAdrress = "StanMar@wp.pl",
                    IdentityCardNumber = "OOP123",
                    IssueDateIdentityCard = new DateTime(2010,9,12),
                    ExpirationDateIdentityCard = new DateTime(2032,5,5),
                    PassportNumber = "IOI123",
                    IssueDatePassport = new DateTime(2011,6,8),
                    ExpirationDatePassport = new DateTime(2035,2,2),
                    Status = new StatusModel("Wprowadzono")
                }
                /*
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
                    ID = 3,
                    LastName = "Szczepaniak",
                    FirstName = "Katarzyna",
                    Code = 3,
                    Gender = new GenderModel("kobieta"),
                    DateBirth = new DateTime(1995,10,13),
                    PESEL = "95101361886",
                    PhoneNumber = "852745984",
                    EmailAdrress = "k.szczepaniak@gmail.com",
                    IdentityCardNumber = "AWR204120",
                    IssueDateIdentityCard = new DateTime(2012,9,15),
                    ExpirationDateIdentityCard = new DateTime(2032,9,15),
                    PassportNumber = "ER8984510",
                    IssueDatePassport = new DateTime(2015,5,23),
                    ExpirationDatePassport = new DateTime(2025,5,23),
                    Status = new StatusModel("Wprowadzony")
                }
                */
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
            int employeeID = (int)this.DGVEmployees.CurrentRow.Cells["colId"].Value;
            int selectedRowIndex = DGVEmployees.CurrentRow.Index;

            EmployeeEditForm form = new EmployeeEditForm(employeeID);
            form.ReloadEmployees += (s, ea) =>
            {
                EmployeeEventArgs eventArgs = ea as EmployeeEventArgs;
                if (eventArgs != null)
                {
                    EmployeeViewModel employee = MapingHelper.MapEmployeeModelToEmployeeViewModel(eventArgs.Employee);
                    BSEmployees[selectedRowIndex] = employee;
                }
            };
            form.ShowDialog();
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            int employeeID = (int)this.DGVEmployees.CurrentRow.Cells["colId"].Value;
            int selectedRowIndex = DGVEmployees.CurrentRow.Index;

            // Remove pointer

            EmployeeViewModel employee = fakeEmployees.Where((x) => x.Id == employeeID).FirstOrDefault();
            if (employee != null)
            {
                BSEmployees.Remove(employee);

                if (DGVEmployees.Rows.Count > 1)
                {
                    DGVEmployees.ClearSelection();
                    DGVEmployees.Rows[DGVEmployees.Rows.Count - 1].Selected = true;
                }
            }
        }
        #endregion
    }
}
