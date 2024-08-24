using System;
using System.Collections.Generic;

namespace CSharpEssentials.CS15_Collections
{
    /// <summary>
    /// Book class that holds information about a book
    /// </summary>
    public class Book
    {
        // Book properties
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; } // Unique identifier for each book
        public string Genre { get; set; }
        public decimal Price { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="title"></param>
        /// <param name="author"></param>
        /// <param name="isbn"></param>
        /// <param name="genre"></param>
        /// <param name="price"></param>
        public Book(string title, string author, string isbn, string genre, decimal price)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            Genre = genre;
            Price = price;
        }

        /// <summary>
        /// Method that overrides the ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Title: {Title}, Author: {Author}, ISBN: {ISBN}, Genre: {Genre}, Price: {Price:C}";
        }
    }
}
