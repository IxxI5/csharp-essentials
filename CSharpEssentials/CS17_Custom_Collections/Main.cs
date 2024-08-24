using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharpEssentials.CS17_Custom_Collections
{
    public class Main
    {
        /// <summary>
        /// We create a custom collection BookLibrary that holds a collection of Book objects. The collection is iterable and provides additional methods to manage the library.
        /// When creating a custom collection in C# using IEnumerable, you are implementing a collection that supports iteration over a sequence of objects. This is useful when 
        /// you want to define how your collection is iterated over, or when you want to create a collection with custom logic for accessing its elements.
        /// </summary>
        public static void Demo()
        {
            Console.WriteLine("CS17_Custom_Collections");

            BookLibrary library = new BookLibrary();

            // Adding books to the library
            library.Add(new Book("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565"));
            library.Add(new Book("1984", "George Orwell", "9780451524935"));
            library.Add(new Book("To Kill a Mockingbird", "Harper Lee", "9780061120084"));
            library.Add(new Book("Animal Farm", "George Orwell", "9780451526342"));

            // Displaying all books using the generic enumerator
            Console.WriteLine("All books in the library (using generic IEnumerator):");
            foreach (var book in library)
            {
                Console.WriteLine(book);
            }

            // Displaying all books using the non-generic enumerator
            Console.WriteLine("\nAll books in the library (using non-generic IEnumerator):");
            IEnumerator enumerator = ((IEnumerable)library).GetEnumerator();
            while (enumerator.MoveNext())
            {
                Book book = (Book)enumerator.Current;
                Console.WriteLine(book);
            }

            // Using yield return to find books by George Orwell
            Console.WriteLine("\nBooks by George Orwell:");
            foreach (var book in library.FindByAuthor("George Orwell"))
            {
                Console.WriteLine(book);
            }
        }
    }
}
