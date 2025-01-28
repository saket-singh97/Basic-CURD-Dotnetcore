using EmployeeService.Functionality;
using EmployeeService.Models;
using EmployeeService.Properties;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeService.Conroller
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmplyeeRepostory _emplyeeRepostory;
        public EmployeeController(IEmplyeeRepostory emplyeeRepostory)
        {
            _emplyeeRepostory = emplyeeRepostory;
        }
        [HttpGet("Fetch")]
        public IActionResult GetEmployeeDeatil ()
        {
           return Ok(_emplyeeRepostory.GetEmployees());
        }
        [HttpPost("Create")]
        public IActionResult EmployeeSave(Employee employee)
        {
          return Ok(_emplyeeRepostory.CreateEmployee(employee));
        }

    }
}