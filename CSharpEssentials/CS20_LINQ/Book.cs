using System;

namespace CSharpEssentials.CS20_LINQ
{
    /// <summary>
    /// Book class 
    /// </summary>
    public class Book
    {
        // Properties
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        public string Genre { get; set; }
        public string PublisherName { get; set; }  // Added a PublisherName property
    }
}
