using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiMIddleware.Models;

namespace WebApiMIddleware.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        List<Employee> Employees;

        public EmployeeController()
        {
            Employees = new List<Employee>();
        }

        [HttpPost]
        public IActionResult Post(Employee employee)
        {
            if (ModelState.IsValid)
            {
                if (employee.EmpNo < 0) throw new Exception("EmpNo cannot be -ve");
                Employees.Add(employee);
                return Ok(Employees);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

    }
}
