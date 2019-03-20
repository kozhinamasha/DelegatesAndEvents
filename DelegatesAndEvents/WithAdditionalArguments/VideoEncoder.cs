﻿using System;
using System.Threading;

namespace DelegatesAndEvents
{
    public class VideoEventArgs
    {
        public Video Video { get; set; }
    }

    public class VideoEncoder
    {
        // Define delegate
        // Define event based on delegate
        // publish event (create event publisher method)

        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        public event VideoEncodedEventHandler VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video..." + video.Title);
            Thread.Sleep(3000);
            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs() { Video = video });
            }
        }
    }
}