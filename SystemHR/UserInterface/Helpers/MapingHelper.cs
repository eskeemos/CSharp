using SysetemHR.DataAccessLayer.Models;
using SysetemHR.DataAccessLayer.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemHR.UserInterface.Helpers
{
    public class MapingHelper
    { 
        public static IList<EmployeeViewModel> MapEmployeeModelToEmployeeViewModel(IEnumerable<EmployeeModel> employeesModels)
        {
            IList<EmployeeViewModel> fakeEmployeesViewModel = new List<EmployeeViewModel>();

            foreach (EmployeeModel item in employeesModels)
            {
                EmployeeViewModel fakeEmployeeViewModel = new EmployeeViewModel();
                fakeEmployeeViewModel.Id        = item.ID;
                fakeEmployeeViewModel.LastName  = item.LastName;
                fakeEmployeeViewModel.FirstName = item.FirstName;
                fakeEmployeeViewModel.Code      = item.Code.ToString();
                fakeEmployeeViewModel.Position  = string.Empty;
                fakeEmployeeViewModel.Status    = item.Status.ToString();

                fakeEmployeesViewModel.Add(fakeEmployeeViewModel);
            }
            return fakeEmployeesViewModel;
        }
        public static EmployeeViewModel MapEmployeeModelToEmployeeViewModel(EmployeeModel employeeModel)
        {
            EmployeeViewModel employeeViewModel = new EmployeeViewModel();
            employeeViewModel.Id        = employeeModel.ID;
            employeeViewModel.LastName  = employeeModel.LastName;
            employeeViewModel.FirstName = employeeModel.FirstName;
            employeeViewModel.Code      = employeeModel.Code.ToString();
            employeeViewModel.Position  = string.Empty;
            employeeViewModel.Status    = employeeModel.Status.ToString();

            return employeeViewModel;
        }
    }
}
