using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Train_project.Core.Entities;

namespace Train_project.Core.IServices
{
    public interface IEmployeeService
    {
        List<EmployeeEntity> GetAllEmployees();
        EmployeeEntity? GetEmployeeById(int id);
        bool AddEmployee(EmployeeEntity employee);
        bool UpdateEmployee(int id, EmployeeEntity employee);
        bool DeleteEmployee(int id);
        bool ValidData(EmployeeEntity employee);
    }
}
