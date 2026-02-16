namespace dependency_injection.Services
{

    


    public class EmailNotification : INotificationService
    {
        public bool SendNotification()
        {
            Console.WriteLine("Sending email..");

            return true;
        }
    }
}
