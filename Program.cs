namespace EventHandler;

internal class Program
{
    static void Main(string[] args)
    {
        var video = new Video() { Title = "Video 1" };
        var emailMessageService = new EmailNotificationService();
        var smsMessageService = new SmsNotificationService();
        var emailSender = new NotificationSender(emailMessageService);
        var smsSender = new NotificationSender(smsMessageService);
        var videoEncoder = new VideoEncoder(); // Publisher
        var mailService = new MailService(); // Subscriber
        var messageService = new MessageService(); // Subscriber
        var logService = new LogService(); // Subscriber

        videoEncoder.VideoEncoded += mailService.VideoEncoderEventHandler; // Attaching event handler (assigning subscriber)
        videoEncoder.VideoEncoded += messageService.VideoEncoderEventHandler; // Attaching event handler again
        videoEncoder.VideoEncoded += logService.VideoEncoderEventHandler; // Attaching event handler again

        videoEncoder.Encode(video);
        emailSender.SendMessage("This is my email");
        smsSender.SendMessage("This is my text");
    }
}
