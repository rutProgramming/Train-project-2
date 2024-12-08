﻿using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Train_project.Core.Entities;
using Train_project.Core.IServices;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Train_project.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        // GET: api/<EmployeeController>
        [HttpGet]
        public ActionResult<List<EmployeeEntity>> Get()
        {
            return _employeeService.GetAllEmployees();
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public ActionResult<EmployeeEntity> Get(int id)
        {
            if (id < 0) return BadRequest();
            EmployeeEntity? employee = _employeeService.GetEmployeeById(id);
            if (employee == null)
            {
                return NotFound();
            }
            return employee;
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public ActionResult<EmployeeEntity> Post([FromBody] EmployeeEntity employee)
        {
            if (employee == null)
                return BadRequest();
            bool success=_employeeService.AddEmployee(employee);
            if (!success)
                return BadRequest();
            return employee;

        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public ActionResult<EmployeeEntity> Put(int id, [FromBody] EmployeeEntity employee)
        {
            bool success = _employeeService.UpdateEmployee(id, employee);
            if (success)
            {
                return  employee;
            }
            return NotFound();
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public ActionResult<int> Delete(int id)
        {
            bool success = _employeeService.DeleteEmployee(id);
            if (success)
            {
                return id;
            }
            return NotFound();
        }
    }
}
