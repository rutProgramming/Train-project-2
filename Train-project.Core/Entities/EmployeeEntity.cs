using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train_project.Core.Entities
{
   public enum typeWork { driver,cleaner,workerOffice}
    [Table("Employee")]
    public class EmployeeEntity
    {
        [Key]
        public int EmployeeCode { get; set; }
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeAddress{ get; set; }
        public string EmployeType { get; set; }
        public string EmployeePhone { get; set; }
        public int Salary { get; set; }
        public DateTime EmployedFrom { get; set; }
        public  EmployeeEntity()
        {
                
        }
        public  EmployeeEntity(int employeeCode, string employeeId, string employeeName, string employeeAddress, string employeType, string employeePhone, int salary, DateTime employedFrom)
        {
            EmployeeCode = employeeCode;
            EmployeeId = employeeId;
            EmployeeName = employeeName;
            EmployeeAddress = employeeAddress;
            EmployeType = employeType;
            EmployeePhone = employeePhone;
            Salary = salary;
            EmployedFrom = employedFrom;
        }
    }
}
