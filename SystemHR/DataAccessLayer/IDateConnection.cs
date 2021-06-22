using SysetemHR.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysetemHR.DataAccessLayer
{
    public interface IDateConnection
    {
        IEnumerable<EmployeeModel> GetEmployees();
        EmployeeModel GetEmployee(int ID);

        EmployeeModel CreateEmployee(EmployeeModel model);

        EmployeeModel ModifyEmployee(EmployeeModel model);
        /*void RemoveEmployee(int ID)
        {

        }*/
    }
}
