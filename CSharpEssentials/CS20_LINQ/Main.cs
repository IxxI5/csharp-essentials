using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpEssentials.CS20_LINQ
{
    public class Main
    {
        public static void Demo()
        {
            Console.WriteLine("CS20_LINQ");

            // Create a list of books
            List<Book> books = new List<Book>
            {
                new Book { Id = 1, Title = "The Catcher in the Rye", Author = "J.D. Salinger", Year = 1951, Price = 9.99, Genre = "Fiction", PublisherName = "Little, Brown and Company" },
                new Book { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", Year = 1960, Price = 7.99, Genre = "Fiction", PublisherName = "J.B. Lippincott & Co." },
                new Book { Id = 3, Title = "1984", Author = "George Orwell", Year = 1949, Price = 8.99, Genre = "Dystopian", PublisherName = "Secker & Warburg" },
                new Book { Id = 4, Title = "Pride and Prejudice", Author = "Jane Austen", Year = 1813, Price = 5.99, Genre = "Romance", PublisherName = "T. Egerton" },
                new Book { Id = 5, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Year = 1925, Price = 10.99, Genre = "Fiction", PublisherName = "Charles Scribner's Sons" },
                new Book { Id = 6, Title = "Brave New World", Author = "Aldous Huxley", Year = 1932, Price = 6.99, Genre = "Dystopian", PublisherName = "Chatto & Windus" }
            };

            // Create a list of publishers
            List<Publisher> publishers = new List<Publisher>
            {
                new Publisher { PublisherId = 1, PublisherName = "Little, Brown and Company", Country = "United States" },
                new Publisher { PublisherId = 2, PublisherName = "J.B. Lippincott & Co.", Country = "United States" },
                new Publisher { PublisherId = 3, PublisherName = "Secker & Warburg", Country = "United Kingdom" },
                new Publisher { PublisherId = 4, PublisherName = "T. Egerton", Country = "United Kingdom" },
                new Publisher { PublisherId = 5, PublisherName = "Charles Scribner's Sons", Country = "United States" },
                new Publisher { PublisherId = 6, PublisherName = "Chatto & Windus", Country = "United Kingdom" }
            };

            // Demonstrate LINQ Join

            // Join books with publishers based on PublisherName
            var booksWithPublishers = from book in books
                                      join publisher in publishers
                                      on book.PublisherName equals publisher.PublisherName
                                      select new
                                      {
                                          book.Title,
                                          book.Author,
                                          book.Year,
                                          Publisher = publisher.PublisherName,
                                          Country = publisher.Country
                                      };

            Console.WriteLine("Books with their Publishers (Join):");
            foreach (var item in booksWithPublishers)
            {
                Console.WriteLine($"{item.Title} by {item.Author} ({item.Year}) - Published by {item.Publisher} in {item.Country}");
            }

            // Additional LINQ operations for completeness

            // 1. Query Syntax: Get all books with Price greater than 8, sorted by Year
            var expensiveBooks = from book in books
                                 where book.Price > 8
                                 orderby book.Year
                                 select book;

            Console.WriteLine("\nExpensive Books (Query Syntax):");
            foreach (var book in expensiveBooks)
            {
                Console.WriteLine($"{book.Title} - {book.Price:C} ({book.Year})");
            }

            // 2. Method Syntax: Get all Fiction books using Method Syntax
            var fictionBooks = books.Where(b => b.Genre == "Fiction").ToList();

            Console.WriteLine("\nFiction Books (Method Syntax):");
            fictionBooks.ForEach(b => Console.WriteLine(b.Title));

            // 3. Select: Get only Titles and Prices of books published before 1950
            var oldBooks = books.Where(b => b.Year < 1950)
                                .Select(b => new { b.Title, b.Price });

            Console.WriteLine("\nOld Books (Select):");
            foreach (var book in oldBooks)
            {
                Console.WriteLine($"{book.Title} - {book.Price:C}");
            }

            // 4. GroupBy: Group books by Genre
            var booksByGenre = books.GroupBy(b => b.Genre);

            Console.WriteLine("\nBooks Grouped by Genre:");
            foreach (var genreGroup in booksByGenre)
            {
                Console.WriteLine($"\nGenre: {genreGroup.Key}");
                foreach (var book in genreGroup)
                {
                    Console.WriteLine(book.Title);
                }
            }

            // 5. Aggregate: Calculate the total price of all books
            var totalPrice = books.Aggregate(0.0, (sum, b) => sum + b.Price);

            Console.WriteLine($"\nTotal Price of all books: {totalPrice:C}");

            // 6. Any and All: Check if there are any books from before 1900 and if all books are cheaper than $15
            bool anyOldBooks = books.Any(b => b.Year < 1900);
            bool allCheapBooks = books.All(b => b.Price < 15);

            Console.WriteLine($"\nAny books from before 1900? {anyOldBooks}");
            Console.WriteLine($"Are all books cheaper than $15? {allCheapBooks}");

            // 7. FirstOrDefault: Get the first Dystopian book
            var firstDystopianBook = books.FirstOrDefault(b => b.Genre == "Dystopian");

            Console.WriteLine($"\nFirst Dystopian Book: {firstDystopianBook?.Title}");

            // 8. Take and Skip: Take the first 3 books and skip the first 2
            var firstThreeBooks = books.Take(3);
            var skipFirstTwoBooks = books.Skip(2);

            Console.WriteLine("\nFirst 3 Books (Take):");
            foreach (var book in firstThreeBooks)
            {
                Console.WriteLine(book.Title);
            }

            Console.WriteLine("\nBooks after skipping first 2 (Skip):");
            foreach (var book in skipFirstTwoBooks)
            {
                Console.WriteLine(book.Title);
            }

            // 9. Distinct: Get distinct genres
            var distinctGenres = books.Select(b => b.Genre).Distinct();

            Console.WriteLine("\nDistinct Genres:");
            foreach (var genre in distinctGenres)
            {
                Console.WriteLine(genre);
            }

            // 10. Union: Get a union of two collections (in this case, we'll just use the same collection twice for demonstration)
            var unionBooks = books.Select(b => b.Title).Union(books.Select(b => b.Title));

            Console.WriteLine("\nUnion of Book Titles:");
            foreach (var title in unionBooks)
            {
                Console.WriteLine(title);
            }

            /* Book Class: Represents individual books, with properties like Id, Title, Author, Year, Price, Genre, and a new property PublisherName.
             * Publisher Class: Represents publishers with properties PublisherId, PublisherName, and Country.
             * 
             *    Join Query:
             *    The booksWithPublishers query joins the books list with the publishers list on the PublisherName property.
             *    It projects a new anonymous object containing Title, Author, Year, Publisher, and Country.
             *    
             * 1. The query syntax is used to select books with a price greater than 8 and order them by year.
             * 2. Method Syntax: Get all Fiction books and transform them into a list using Method Syntax.
             * 3. Select: Get only Titles and Prices of books published before 1950.
             * 4. GroupBy: Group books by Genre.
             * 5. Aggregate: Calculate the total price of all books.
             * 6. Any and All: Check if there are any books from before 1900 and if all books are cheaper than $15.
             * 7. FirstOrDefault: Get the first Dystopian book.
             * 8. Take and Skip: Take the first 3 books and skip the first 2.
             * 9. Distinct: Get distinct genres.
             * 10. Union: Get a union of two collections (in this case, we'll just use the same collection twice for demonstration).
             */
        }
    }
}
