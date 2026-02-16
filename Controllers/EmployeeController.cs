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
        private readonly INotificationService notificationService;


        // constructor injection
        public EmployeeController(
            IEmployeeService employeeService,
            ICustomerService customerService,
            [FromKeyedServices("SMS")]INotificationService notificationService)
        {
            _employeeService = employeeService;
            _customerService = customerService;
            this.notificationService = notificationService;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {

            var notification = notificationService.SendNotification();//


            var empObj = _employeeService.GetEmployees();

            return Ok(empObj);
        }
    }
}
