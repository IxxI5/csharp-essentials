using System;
using System.Collections.Generic;

namespace CSharpEssentials.CS07_Classes_And_Objects
{
    /// <summary>
    /// Library class: Manages the collection of books and the patrons.
    /// </summary>
    public class Library
    {
        public List<Book> Books { get; private set; } = new List<Book>();
        public List<Patron> Patrons { get; private set; } = new List<Patron>();

        /// <summary>
        /// Method to add a book to the library. It adds a book object into the Books list.
        /// </summary>
        /// <param name="book"></param>
        public void AddBook(Book book)
        {
            Books.Add(book);
            Console.WriteLine($"Added \"{book.Title}\" to the library.");
        }

        /// <summary>
        /// Method to add a patron into the library. It adds a patron object into the Patrons list.
        /// </summary>
        /// <param name="patron"></param>
        public void RegisterPatron(Patron patron)
        {
            Patrons.Add(patron);
            Console.WriteLine($"Registered patron: {patron.Name}");
        }

        /// <summary>
        /// Method to display the available books (Books list) in the library.
        /// </summary>
        public void ListBooks()
        {
            Console.WriteLine("Books in Library:");
            foreach (var book in Books)
            {
                Console.WriteLine(book);
            }
        }
    }
}
