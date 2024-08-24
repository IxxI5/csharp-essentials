using System;

namespace CSharpEssentials.CS18_Delegates.Models
{
    public class Video
    {
        public string FileName { get; set; }
        public string Resolution { get; set; }
        public TimeSpan Duration { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="resolution"></param>
        /// <param name="duration"></param>
        public Video(string fileName, string resolution, TimeSpan duration)
        {
            FileName = fileName;
            Resolution = resolution;
            Duration = duration;
        }

        /// <summary>
        /// Method to display information about a video object
        /// </summary>
        public void DisplayInfo()
        {
            Console.WriteLine($"Video File: {FileName}, Resolution: {Resolution}, Duration: {Duration}");
        }
    }
}
