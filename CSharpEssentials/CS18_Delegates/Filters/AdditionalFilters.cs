using System;
using CSharpEssentials.CS18_Delegates.Models;

namespace CSharpEssentials.CS18_Delegates.Filters
{
    public static class AdditionalFilters
    {
        /// <summary>
        /// Method to apply a SepiaFilter to a video object
        /// </summary>
        /// <param name="video"></param>
        /// <returns></returns>
        public static Video SepiaFilter(Video video)
        {
            Console.WriteLine($"Applying Sepia filter to {video.FileName}");
            // Simulate filter application
            return video;
        }
    }
}
