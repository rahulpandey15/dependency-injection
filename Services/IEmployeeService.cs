using dependency_injection.Models;

namespace dependency_injection.Services
{
    public interface IEmployeeService
    {
        List<EmployeeResponseDto> GetEmployees();
    }
}
