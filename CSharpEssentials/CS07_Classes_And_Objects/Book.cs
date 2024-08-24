using System;

namespace CSharpEssentials.CS07_Classes_And_Objects
{
    /// <summary>
    /// Book class. Represents a book in the library.
    /// </summary>
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsAvailable { get; set; } = true;

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public override string ToString()
        {
            return $"{Title} by {Author} (Available: {IsAvailable})";
        }
    }
}
