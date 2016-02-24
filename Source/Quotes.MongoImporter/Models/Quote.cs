using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Quotes.MongoImporter.Models
{
    [BsonIgnoreExtraElements]
    public class Quote
    {
        [BsonElement("_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("text")]
        [BsonRepresentation(BsonType.String)]
        public string Text { get; set; }

        [BsonElement("author")]
        [BsonRepresentation(BsonType.String)]
        public string Author { get; set; }

        [BsonElement("imageUrl")]
        [BsonRepresentation(BsonType.String)]
        public string AuthorImageUrl { get; set; }

        [BsonElement("tags")]
        public IEnumerable<string> Tags { get; set; }

        [BsonElement("favoritesCount")]
        [BsonRepresentation(BsonType.String)]
        public int FavoritesCount { get; set; }
    }
}
