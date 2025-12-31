namespace dependency_injection.Services
{
    public class CustomerService : ICustomerService
    {
        public CustomerService()
        {
            Console.WriteLine($"Guid Generated with value {Guid.NewGuid().ToString()} at {DateTime.Now}");
        }
    }
}
