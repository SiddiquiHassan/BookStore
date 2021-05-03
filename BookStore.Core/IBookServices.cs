using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Core
{
    public interface IBookServices
    {
        List<Book> GetBooks();
        Book GetBook(string id);
        Book AddBook(Book book);
        Book UpdateBook(Book book);
        void DeleteBook(string id);
    }
}
