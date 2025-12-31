using dependency_injection.Models;

namespace dependency_injection.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly ICustomerService customerService;

        public EmployeeService(ICustomerService customerService)
        {
            this.customerService = customerService;
        }


        public List<EmployeeResponseDto> GetEmployees()
        {
            // assume we are fetching records from database
            return new List<EmployeeResponseDto>();
        }
    }
}
