using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Library
    {
        private List<Book> _books;
        public Library(List<Book> books)
        {
            _books = books;
        }
        public void StoreBook(Book book)
        {
            _books.Add(book);
        }

        public bool IsBookAvailable(long isbn)
        {
            foreach (Book book in _books)
            {
                if (book.ISBNNumber == isbn)
                    return true;
            }
            return false;
        }
        public Book TakeOutBook(long isbn)
        {
            foreach (Book book in _books)
            {
                if(book.ISBNNumber==isbn)
                {
                    _books.Remove(book);
                    return book;
                }
            }
            return null;
        }
       
    }

}

