using System;

namespace CSharpEssentials.CS14_Generics
{
    /// <summary>
    /// Book class representing a book item
    /// </summary>
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="title"></param>
        /// <param name="author"></param>
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        /// <summary>
        /// Method that overrides the ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Book: {Title} by {Author}";
        }

        /// <summary>
        /// Override Equals and GetHashCode to allow proper comparison
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            if (obj is Book book)
            {
                return Title == book.Title && Author == book.Author;
            }

            return false;
        }

        /// <summary>
        /// Method to create a HashCode combining two values the Title and Author
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(Title, Author);
        }
    }
}
