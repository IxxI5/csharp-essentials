using System;
using System.Collections.Generic;

namespace CSharpEssentials.CS07_Classes_And_Objects
{
    /// <summary>
    /// Patron class: Represents a library patron.
    /// </summary>
    public class Patron
    {
        public string Name { get; set; }
        public List<Book> BorrowedBooks { get; private set; } = new List<Book>();

        public Patron(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Method to borrow a book. It adds a book into the BorrowedBooks List.
        /// </summary>
        /// <param name="book"></param>
        public void BorrowBook(Book book)
        {
            if (book.IsAvailable)
            {
                BorrowedBooks.Add(book);
                book.IsAvailable = false;
                Console.WriteLine($"{Name} has borrowed \"{book.Title}\".");
            }
            else
            {
                Console.WriteLine($"Sorry, \"{book.Title}\" is not available.");
            }
        }

        /// <summary>
        /// Method to return a book. It removes a book from the BorrowedBooks List.
        /// </summary>
        /// <param name="book"></param>
        public void ReturnBook(Book book)
        {
            if (BorrowedBooks.Remove(book))
            {
                book.IsAvailable = true;
                Console.WriteLine($"{Name} has returned \"{book.Title}\".");
            }
            else
            {
                Console.WriteLine($"{Name} did not borrow \"{book.Title}\".");
            }
        }

        /// <summary>
        /// Method to display the currently borrowed books.
        /// </summary>
        public void PrintBorrowedBooks()
        {
            Console.WriteLine($"{Name}'s Borrowed Books:");
            foreach (var book in BorrowedBooks)
            {
                Console.WriteLine(book);
            }
        }
    }
}
