using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Train_project.Core.Entities;

namespace Train_project.Core.IRepositories
{
    public interface IEmployeeRepository
    {
        List<EmployeeEntity> GetAllEmployees();
        int EmployeeById(int id);
        EmployeeEntity GetEmployeeById(int indexEmployee);
        bool AddEmployee(EmployeeEntity employee);
        bool UpdateEmployee(int indexEmployee, EmployeeEntity employee);
        bool DeleteEmployee(int indexEmployee);
    }
}
