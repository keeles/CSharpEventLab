namespace EventHandler
{
    class MessageService
    {
        public void VideoEncoderEventHandler(object source, VideoEventArgs e)
        {
            Console.WriteLine("MessageService: sending a text message...");
            Console.WriteLine(
                $"{e.VideoTag.Title} has been encoded in {e.EncodingDuration.Seconds} seconds"
            );
        }
    }
}
