using System;

namespace CSharpEssentials.CS07_Classes_And_Objects
{
    public class Main
    {
        /// <summary>
        /// We’ll build a Library Management System where you can manage books and patrons. 
        /// This example will demonstrate how to define classes and use objects to represent and interact with different entities in the system.
        /// We define the following classes:
        /// Book: Represents a book in the library.
        /// Patron: Represents a library patron.
        /// Library: Manages the collection of books and the patrons.
        /// </summary>
        public static void Demo()
        {
            Console.WriteLine("CS07_Classes_And_Objects");

            // Create a library
            Library library = new Library();

            // Add books to the library
            library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee"));
            library.AddBook(new Book("1984", "George Orwell"));
            library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald"));

            // Register patrons
            Patron alice = new Patron("Alice");
            Patron bob = new Patron("Bob");
            library.RegisterPatron(alice);
            library.RegisterPatron(bob);

            // List books in the library
            library.ListBooks();

            // Patrons borrow and return books
            alice.BorrowBook(library.Books[0]); // Alice borrows "To Kill a Mockingbird"
            bob.BorrowBook(library.Books[1]);   // Bob borrows "1984"

            // Print borrowed books
            alice.PrintBorrowedBooks();
            bob.PrintBorrowedBooks();

            // Alice returns a book
            alice.ReturnBook(library.Books[0]); // Alice returns "To Kill a Mockingbird"

            // List books in the library after some operations
            library.ListBooks();
        }
    }
}
