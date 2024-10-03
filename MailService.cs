namespace EventHandler
{
    public class MailService
    {
        public void VideoEncoderEventHandler(object source, VideoEventArgs e)
        {
            Console.WriteLine("MailService: sending an email...");
            Console.WriteLine(
                $"{e.VideoTag.Title} has been encoded in {e.EncodingDuration.Seconds} seconds"
            );
        }
    }
}
