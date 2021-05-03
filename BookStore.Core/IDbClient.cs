using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Core
{
    public interface IDbClient
    {
        IMongoCollection<Book> GetBooksCollection();
    }
}
