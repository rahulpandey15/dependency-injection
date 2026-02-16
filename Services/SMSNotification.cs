namespace dependency_injection.Services
{
    public class SMSNotification : INotificationService
    {
        public bool SendNotification()
        {
            Console.WriteLine("Sending SMS");
            return true;
        }
    }
}
