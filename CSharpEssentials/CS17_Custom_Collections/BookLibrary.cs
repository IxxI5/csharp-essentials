using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharpEssentials.CS17_Custom_Collections
{
    public class BookLibrary : IEnumerable<Book>
    {
        private List<Book> _books = new List<Book>();

        /// <summary>
        /// Method to add a book object to the _books (List<Book>)
        /// </summary>
        /// <param name="book"></param>
        public void Add(Book book)
        {
            _books.Add(book);
        }

        /// <summary>
        /// Method to remove a book object from the _books (List<Book>)
        /// </summary>
        /// <param name="book"></param>
        public void Remove(Book book)
        {
            _books.Remove(book);
        }

        /// <summary>
        /// Generic IEnumerator implementation using yield return
        /// </summary>
        /// <returns></returns>
        public IEnumerator<Book> GetEnumerator()
        {
            foreach (var book in _books)
            {
                yield return book;
            }
        }

        /// <summary>
        /// Non-generic IEnumerator implementation using a custom enumerator.
        /// It uses BookLibraryEnumerator to develop iterable collections through a while-loop and methods MoveNext, Current
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return new BookLibraryEnumerator(_books.ToArray());
        }

        /// <summary>
        /// Using yield return to filter books by author
        /// </summary>
        /// <param name="author"></param>
        /// <returns></returns>
        public IEnumerable<Book> FindByAuthor(string author)
        {
            foreach (var book in _books)
            {
                if (book.Author == author)
                {
                    yield return book;
                }
            }
        }
    }
}
