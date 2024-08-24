using System;
using System.Collections;

namespace CSharpEssentials.CS17_Custom_Collections
{
    public class BookLibraryEnumerator : IEnumerator
    {
        private readonly Book[] _books;             // The array of books to enumerate over
        private int _position = -1;                 // The current position in the collection

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="books"></param>
        public BookLibraryEnumerator(Book[] books)
        {
            _books = books;
        }

        /// <summary>
        /// Moves to the next item in the collection
        /// </summary>
        /// <returns></returns>
        public bool MoveNext()
        {
            _position++;
            return _position < _books.Length;
        }

        /// <summary>
        /// Resets the enumerator to its initial position
        /// </summary>
        public void Reset()
        {
            _position = -1;
        }

        /// <summary>
        /// Returns the current item (object)
        /// </summary>
        public object Current
        {
            get
            {
                if (_position < 0 || _position >= _books.Length)
                {
                    throw new InvalidOperationException();
                }
                return _books[_position];
            }
        }

        /* BookLibraryEnumerator Class:
         * This class implements the non-generic IEnumerator interface, allowing it to iterate over an array of Book objects.
         * It keeps track of the current position in the array using the _position field.
         * The MoveNext method advances the position and returns true if there are more elements to iterate over.
         * The Current property returns the current Book at the current position.
         * 
         * e.g.
         * IEnumerator enumerator = ((IEnumerable)library).GetEnumerator();
           while (enumerator.MoveNext())
           {
               Book book = (Book)enumerator.Current;
               Console.WriteLine(book);
           }
         */
    }
}
