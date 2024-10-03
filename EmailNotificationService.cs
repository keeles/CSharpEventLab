namespace EventHandler
{
    public class EmailNotificationService : INotificationService
    {
        public void Send(string message)
        {
            Console.WriteLine($"Email sent: {message}");
        }
    }
}
