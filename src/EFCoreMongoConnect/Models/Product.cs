using MongoDB.Bson;

namespace EFCoreMongoConnet;

public class Product
{
    public ObjectId Id { get; set;}
    public required string Name { get; set;}
    public required string Description { get; set;}
    public required double Price { get; set;}
}
