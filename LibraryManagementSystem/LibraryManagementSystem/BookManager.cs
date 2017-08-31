using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class BookManager
    {
        private Library _library;
        public BookManager(Library library)
        {
            _library = library;
        }
        
        public Book IssueBook(long isbn)
        {
            if(_library.IsBookAvailable(isbn))
            {
                return _library.TakeOutBook(isbn);
            }
            return null;
        }

        public void CollectReturnedBook(Book book)
        {
            _library.StoreBook(book);
        }

 }
}
