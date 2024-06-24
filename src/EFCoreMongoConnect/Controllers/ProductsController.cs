using EFCoreMongoConnet;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCoreMongoConnect.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductsController : ControllerBase
{
    private readonly MongoDbContext _context;
    public ProductsController(MongoDbContext context)
    { 
        _context = context;
    }

    [HttpGet(Name = "Get")]
    public async Task<ActionResult<IEnumerable<Product>>>  Get()
    {
        return await _context.Products.ToListAsync();
    }

    [HttpPost(Name = "Post")]
    public async Task Post(Product product)
    {
        await _context.Products.AddAsync(product);
        await _context.SaveChangesAsync();
    }
}
