using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryManagementSystem;

namespace LibraryManagementTestCases
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IssueBook()
        {
            List<string> authorname = new List<string>();
            authorname.Add("Eric Leepart");
            authorname.Add("Eric Freeman");
            Book book = new Book("Head First Java",Genre.Selfhelp,12333342,authorname,5,Status.Available);
            List<Book> books = new List<Book>();
            books.Add(book);
            Library library = new Library(books);
            Assert.AreSame(book, library.TakeOutBook(book.ISBNNumber));
        }
    }
}
