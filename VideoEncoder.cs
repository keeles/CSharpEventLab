namespace EventHandler
{
    public class VideoEventArgs : EventArgs
    {
        public Video VideoTag { get; set; }
        public TimeSpan EncodingDuration { get; set; }
    }

    public class VideoEncoder
    {
        // Define a delegate
        // Define an event based on delegate
        // Raise that event

        public delegate void VideoEncoderEventHandler(object source, VideoEventArgs args);

        public event VideoEncoderEventHandler VideoEncoded;

        // EventHandler
        // EventHandler<TEventArgs>

        // public event EventHandler<VideoEventArgs> VideoEncoded;

        public void Encode(Video video)
        {
            DateTime start = DateTime.Now;
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);
            DateTime end = DateTime.Now;
            TimeSpan EncodingDuration = end - start;
            OnVideoEncoded(video, EncodingDuration);
        }

        protected virtual void OnVideoEncoded(Video video, TimeSpan timeSpan)
        {
            if (VideoEncoded != null)
                VideoEncoded(
                    this,
                    new VideoEventArgs() { VideoTag = video, EncodingDuration = timeSpan }
                );
        }
    }
}
