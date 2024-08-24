using System;
using CSharpEssentials.CS18_Delegates.Models;
using static CSharpEssentials.CS18_Delegates.Delegates.VideoFilterDelegate;

namespace CSharpEssentials.CS18_Delegates.Processing
{
    public class VideoProcessor
    {
        /// <summary>
        /// Method to process a video file
        /// </summary>
        /// <param name="video"></param>
        /// <param name="videoFilter"></param>
        public void Process(Video video, VideoFilter videoFilter)
        {
            Console.WriteLine("Starting video processing...");
            video = videoFilter(video);
            Console.WriteLine("Video processing completed.");
        }
    }
}
