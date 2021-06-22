using SysetemHR.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysetemHR.DataAccessLayer
{
    public class CloudConnector : IDateConnection
    {
        public EmployeeModel CreateEmployee(EmployeeModel model)
        {
            throw new NotImplementedException();
        }

        public EmployeeModel GetEmployee(int ID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeModel> GetEmployees()
        {
            throw new NotImplementedException();
        }

        public EmployeeModel ModifyEmployee(EmployeeModel model)
        {
            throw new NotImplementedException();
        }
    }
}
