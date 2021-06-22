using SysetemHR.DataAccessLayer.Models;
using SysetemHR.DataAccessLayer.Models.Dictionaries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysetemHR.DataAccessLayer
{
    class TextConnector : IDateConnection
    {
        IList<EmployeeModel> fakeTextEmployeesModel = new List<EmployeeModel>()
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
        };
        public IEnumerable<EmployeeModel> GetEmployees()
        {
            return fakeTextEmployeesModel;
        }
        public EmployeeModel GetEmployee(int ID)
        {
            return fakeTextEmployeesModel.Single((x) => x.ID == ID);
        }

        public EmployeeModel CreateEmployee(EmployeeModel model)
        {
            throw new NotImplementedException();
        }

        public EmployeeModel ModifyEmployee(EmployeeModel model)
        {
            throw new NotImplementedException();
        }
    }
}
