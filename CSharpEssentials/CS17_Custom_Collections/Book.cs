using System;

namespace CSharpEssentials.CS17_Custom_Collections
{
    /// <summary>
    /// Book class
    /// </summary>
    public class Book
    {
        // Properties
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="title"></param>
        /// <param name="author"></param>
        /// <param name="isbn"></param>
        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
        }

        /// <summary>
        /// Method to override the default functionality of ToString() method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Title} by {Author}, ISBN: {ISBN}";
        }
    }
}
