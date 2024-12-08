using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Train_project.Core.Entities;
using Train_project.Core.IRepositories;

namespace Train_project.Data.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        readonly DataContext _dataContext;
        public EmployeeRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<EmployeeEntity> GetAllEmployees()
        {
            return _dataContext.Employees.ToList();
        }
        public int EmployeeById(int id)
        {
            int indexEmployee = _dataContext.Employees.ToList().FindIndex(employee => employee.EmployeeCode == id);
            return indexEmployee;

        }
        public EmployeeEntity GetEmployeeById(int indexEmployee)
        {
            return _dataContext.Employees.ToList()[indexEmployee];
        }
        public bool AddEmployee(EmployeeEntity employee)
        {
            try
            {
                _dataContext.Employees.Add(employee);
                _dataContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateEmployee(int indexEmployee, EmployeeEntity updatedEmployee)
        {

            EmployeeEntity existingEmployee = _dataContext.Employees.ToList()[indexEmployee];

            if (!string.IsNullOrEmpty(updatedEmployee.EmployeeId))
                existingEmployee.EmployeeId = updatedEmployee.EmployeeId;

            if (!string.IsNullOrEmpty(updatedEmployee.EmployeeName))
                existingEmployee.EmployeeName = updatedEmployee.EmployeeName;

            if (!string.IsNullOrEmpty(updatedEmployee.EmployeeAddress))
                existingEmployee.EmployeeAddress = updatedEmployee.EmployeeAddress;

            if (!string.IsNullOrEmpty(updatedEmployee.EmployeType))
                existingEmployee.EmployeType = updatedEmployee.EmployeType;

            if (!string.IsNullOrEmpty(updatedEmployee.EmployeePhone))
                existingEmployee.EmployeePhone = updatedEmployee.EmployeePhone;

            if (updatedEmployee.Salary > 0)
                existingEmployee.Salary = updatedEmployee.Salary;

            if (updatedEmployee.EmployedFrom != default)
                existingEmployee.EmployedFrom = updatedEmployee.EmployedFrom;
            _dataContext.SaveChanges();
            return true;


        }
        public bool DeleteEmployee(int indexEmployee)
        {
            _dataContext.Employees.Remove(_dataContext.Employees.ToList()[indexEmployee]);
            _dataContext.SaveChanges() ;
            return true;
        }

    }
}

