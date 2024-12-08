using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Train_project.Core.Entities;
using Train_project.Core.IRepositories;
using Train_project.Core.IServices;

namespace Train_project.Service.Services
{
    public class EmployeeService : IEmployeeService
    {
        readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeEntity)
        {
            _employeeRepository = employeeEntity;
        }

        public List<EmployeeEntity> GetAllEmployees()
        {
            return _employeeRepository.GetAllEmployees();
        }
        public EmployeeEntity? GetEmployeeById(int id)
        {
            int indexEmployee = _employeeRepository.EmployeeById(id);
            if (indexEmployee != -1)
            {
                return _employeeRepository.GetEmployeeById(indexEmployee);
            }
            return null;
        }
        public bool AddEmployee(EmployeeEntity employee)
        {
            int indexEmployee = _employeeRepository.EmployeeById(employee.EmployeeCode);
            if (indexEmployee == -1 && ValidData(employee))
            {
                return _employeeRepository.AddEmployee(employee);
            }
            return false;
        }
        public bool UpdateEmployee(int id, EmployeeEntity employee)
        {
            int indexEmployee = _employeeRepository.EmployeeById(id);
            if (indexEmployee != -1 && ValidData(employee))
            {
                return _employeeRepository.UpdateEmployee(indexEmployee, employee);
            }
            return false;
        }
        public bool DeleteEmployee(int id)
        {
            int indexEmployee = _employeeRepository.EmployeeById(id);
            if (indexEmployee != -1)
            {
                return _employeeRepository.DeleteEmployee(indexEmployee);
            }
            return false;
        }
        public bool ValidData(EmployeeEntity employee)
        {
           
            return string.IsNullOrEmpty(employee.EmployeeId)?true:Valid.IsIdValid(employee.EmployeeId) && string.IsNullOrEmpty(employee.EmployeePhone)?true: Valid.IsIsraeliPhoneNumberValid(employee.EmployeePhone);

        }
        

    }
}
