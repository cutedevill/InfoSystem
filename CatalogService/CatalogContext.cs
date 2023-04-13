using Microsoft.EntityFrameworkCore;
using CatalogService.Models;

public class CatalogContext : DbContext
{
    public CatalogContext(DbContextOptions<CatalogContext> options) : base(options) { }

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Brand> Brands { get; set; }

    public CatalogContext()
    {
        Database.EnsureCreated();
    }
}
