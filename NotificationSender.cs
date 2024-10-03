namespace EventHandler
{
    public class NotificationSender
    {
        protected INotificationService NotificationService { get; }

        public NotificationSender(INotificationService notificationService)
        {
            this.NotificationService = notificationService;
        }

        public void SendMessage(string message)
        {
            NotificationService.Send(message);
        }
    }
}
