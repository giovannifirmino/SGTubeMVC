using MongoDB.Bson.Serialization.Attributes;

namespace SGTubeMVC.Mongo.Models
{
    public class Post
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string _id { get; set; }
        public string Title { get; set; }
    }
}
