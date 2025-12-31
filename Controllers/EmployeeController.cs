using dependency_injection.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dependency_injection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;


        // constructor injection
        public EmployeeController(
            IEmployeeService employeeService)
        {
            this._employeeService = employeeService;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        { 
            var empObj = _employeeService.GetEmployees();

            return Ok(empObj);
        }
    }
}
