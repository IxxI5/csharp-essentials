using System;
using CSharpEssentials.CS18_Delegates.Models;

namespace CSharpEssentials.CS18_Delegates.Filters
{
    public static class DefaultFilters
    {
        /// <summary>
        /// Method to apply a BlackAndWhiteFilter to a video object
        /// </summary>
        /// <param name="video"></param>
        /// <returns></returns>
        public static Video BlackAndWhiteFilter(Video video)
        {
            Console.WriteLine($"Applying Black and White filter to {video.FileName}");
            // Simulate filter application
            return video;
        }

        /// <summary>
        /// Method to apply a BrightnessFilter to a video object
        /// </summary>
        /// <param name="video"></param>
        /// <returns></returns>
        public static Video BrightnessFilter(Video video)
        {
            Console.WriteLine($"Applying Brightness filter to {video.FileName}");
            // Simulate filter application
            return video;
        }
    }
}
