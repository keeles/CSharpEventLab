namespace EventHandler
{
    public class LogService
    {
        public void VideoEncoderEventHandler(object source, VideoEventArgs e)
        {
            Console.WriteLine("LogService: Logging video encoding...");
            Console.WriteLine(
                $"{e.VideoTag.Title} has been encoded in {e.EncodingDuration.Seconds} seconds"
            );
        }
    }
}
