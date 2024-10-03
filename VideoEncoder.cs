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
            Console.WriteLine("Encoding video...");
            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(
                    this,
                    new VideoEventArgs()
                    {
                        VideoTag = video,
                        EncodingDuration = TimeSpan.FromSeconds(3),
                    }
                );
        }
    }
}
