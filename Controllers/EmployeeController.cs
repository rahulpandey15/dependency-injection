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
        private readonly ICustomerService _customerService;


        // constructor injection
        public EmployeeController(
            IEmployeeService employeeService,
            ICustomerService customerService)
        {
            _employeeService = employeeService;
            _customerService = customerService;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        { 
            var empObj = _employeeService.GetEmployees();

            return Ok(empObj);
        }
    }
}
