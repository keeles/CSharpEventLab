namespace EventHandler
{
    public class SmsNotificationService : INotificationService
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sms sent: {message}");
        }
    }
}
