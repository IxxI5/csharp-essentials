using System;
using System.Collections.Generic;

namespace CSharpEssentials.CS15_Collections
{
    public class Main 
    {
        /// <summary>
        /// We simulate a Bookstore Inventory Management System that uses these collections (List<T>, HashSet<T>, and Dictionary<TKey, TValue>) to 
        /// store and manage data about books, authors, and genres.
        /// </summary>
        public static void Demo()
        {
            Console.WriteLine("CS15_Collections");

            // 1. Store inventory using an array
            Book[] inventory = new Book[]
            {
                new Book("The Catcher in the Rye", "J.D. Salinger", "9780316769488", "Fiction", 8.99m),
                new Book("1984", "George Orwell", "9780451524935", "Dystopian", 9.99m),
                new Book("To Kill a Mockingbird", "Harper Lee", "9780060935467", "Fiction", 7.99m),
                new Book("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565", "Fiction", 10.99m)
            };

            // Display the entire inventory
            Console.WriteLine("Complete Book Inventory:");
            foreach (var book in inventory)
            {
                Console.WriteLine(book);
            }

            // 2. Use a List to manage books currently on sale
            List<Book> booksOnSale = new List<Book>();

            // Add books to the sale list
            booksOnSale.Add(inventory[0]); // The Catcher in the Rye
            booksOnSale.Add(inventory[2]); // To Kill a Mockingbird

            Console.WriteLine("\nBooks on Sale:");
            foreach (var book in booksOnSale)
            {
                Console.WriteLine(book);
            }

            // 3. Use a HashSet to track unique ISBNs
            HashSet<string> isbnSet = new HashSet<string>();

            foreach (var book in inventory)
            {
                if (!isbnSet.Add(book.ISBN))
                {
                    Console.WriteLine($"Duplicate ISBN found: {book.ISBN} for {book.Title}");
                }
            }

            // 4. Use a Dictionary to map genres to a list of books in that genre
            Dictionary<string, List<Book>> booksByGenre = new Dictionary<string, List<Book>>();

            foreach (var book in inventory)
            {
                if (!booksByGenre.ContainsKey(book.Genre))
                {
                    booksByGenre[book.Genre] = new List<Book>();
                }
                booksByGenre[book.Genre].Add(book);
            }

            // Display books by genre
            Console.WriteLine("\nBooks by Genre:");
            foreach (var genre in booksByGenre.Keys)
            {
                Console.WriteLine($"\nGenre: {genre}");
                foreach (var book in booksByGenre[genre])
                {
                    Console.WriteLine(book);
                }
            }

            /* 1. Array (Book[] inventory):
             *    The bookstore inventory is stored in an array. This is useful when the size of the inventory is fixed or known beforehand.
             * 2. List (List<Book> booksOnSale):
             *    The List<Book> is used to keep track of books currently on sale. The List collection is dynamic and allows for easy addition and removal of items.
             *    Lists are great when you need flexibility in the number of items.
             * 3. HashSet (HashSet<string> isbnSet):
             *    A HashSet<string> is used to store unique ISBNs. HashSet automatically handles duplicates, ensuring that each ISBN is unique.
             *    The Add method returns false if the ISBN already exists, allowing us to catch duplicates easily.
             * 4. Dictionary (Dictionary<string, List<Book>> booksByGenre):
             *    The Dictionary<string, List<Book>> maps each genre to a list of books in that genre. This allows for quick lookups of books by genre.
             *    The dictionary is useful when you need to associate keys (genres) with multiple values (books).              
             */
        }
    }
}
