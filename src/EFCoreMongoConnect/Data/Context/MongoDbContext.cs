using EFCoreMongoConnet;
using Microsoft.EntityFrameworkCore;
using MongoDB.EntityFrameworkCore.Extensions;

namespace EFCoreMongoConnect;

public class MongoDbContext : DbContext
{
    public DbSet<Product> Products { get; set;}

    public MongoDbContext(DbContextOptions<MongoDbContext> options)
    : base(options)
    {

    }

    override protected void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Product>().ToCollection("products");
    }    
}