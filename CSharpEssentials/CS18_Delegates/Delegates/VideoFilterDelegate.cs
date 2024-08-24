using System;
using CSharpEssentials.CS18_Delegates.Models;

namespace CSharpEssentials.CS18_Delegates.Delegates
{
    public class VideoFilterDelegate
    {
        // Define a delegate for video filters
        public delegate Video VideoFilter(Video video);
    }
}
