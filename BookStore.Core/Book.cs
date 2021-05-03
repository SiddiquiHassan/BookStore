using MongoDB.Bson.Serialization.Attributes;
using System;

namespace BookStore.Core
{
    public class Book
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public string title { get; set; }
        public string category { get; set; }
        public double price { get; set; }
        public string author { get; set; }
    }
}
