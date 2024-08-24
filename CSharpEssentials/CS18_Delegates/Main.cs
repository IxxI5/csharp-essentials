using CSharpEssentials.CS18_Delegates.Filters;
using CSharpEssentials.CS18_Delegates.Models;
using CSharpEssentials.CS18_Delegates.Processing;
using System;
using static CSharpEssentials.CS18_Delegates.Delegates.VideoFilterDelegate;

namespace CSharpEssentials.CS18_Delegates
{
    public class Main
    {
        /// <summary>
        /// Simulating a Video Processing System.
        /// This system applies various filters to video files using a flexible delegate-based approach. 
        /// Default filters like Black and White and Brightness are included, and additional filters can be added dynamically without recompiling the entire project.
        /// </summary>
        public static void Demo()
        {
            Console.WriteLine("CS18_Delegates");

            // Create a video instance
            Video video = new Video("example.mp4", "1920x1080", TimeSpan.FromMinutes(5));

            // Display video info
            video.DisplayInfo();

            // Create a video processor instance
            VideoProcessor processor = new VideoProcessor();

            // Apply default filters (Black and White, Brightness)
            VideoFilter defaultFilter = DefaultFilters.BlackAndWhiteFilter;
            defaultFilter += DefaultFilters.BrightnessFilter;
            processor.Process(video, defaultFilter);

            // Now let's apply an additional filter from the separate module
            VideoFilter extendedFilter = AdditionalFilters.SepiaFilter;

            Console.WriteLine("Applying extended filters...");
            processor.Process(video, extendedFilter);

            // You can even chain the new filter with the old ones
            VideoFilter combinedFilter = defaultFilter + extendedFilter;
            Console.WriteLine("Applying combined filters...");
            processor.Process(video, combinedFilter);
        }
    }
}
