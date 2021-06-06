using SysetemHR.DataAccessLayer.Models;
using SysetemHR.DataAccessLayer.Models.Dictionaries;
using SysetemHR.DataAccessLayer.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemHR.UserInterface.Helpers;

namespace SystemHR.UserInterface.Forms.Employees
{
    public partial class EmployeesForm : Form
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

        private void PrepareEmployeesData()
        {
            var fakeEmployeesSorted = fakeEmployees.OrderBy((x) => x.Code).ToList();
            BSEmployees.DataSource = new BindingList<EmployeeViewModel>(fakeEmployeesSorted);
            DGVEmployees.DataSource = BSEmployees;
        }

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
                    PESEL = "123456789",
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
                    PESEL = "234567890",
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
                    PESEL = "345678901",
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
            };
            return MapingHelper.MapEmployeeModelToEmployeeViewModel(fakeEmployeesModel);
        }

        #endregion
        #region Events

        private void EmployeesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            instance = null;
        }

        #endregion
    }
}
