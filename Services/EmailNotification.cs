namespace dependency_injection.Services
{

    public interface INotificationService
    {
        bool SendNotification();
    }


    public class EmailNotification : INotificationService
    {
        public bool SendNotification()
        {
            Console.WriteLine("Sending email..");

            return true;
        }
    }


    public class SMSNotification : INotificationService
    {
        public bool SendNotification()
        {
            Console.WriteLine("Sending SMS");
            return true;
        }
    }
}
