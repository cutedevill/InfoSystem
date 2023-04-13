using Microsoft.EntityFrameworkCore;
using OrderService.Models;

public class OrderContext : DbContext
{
    public OrderContext(DbContextOptions<OrderContext> options) : base(options) { }

    public DbSet<Order> Orders { get; set; }

    public OrderContext()
    {
        Database.EnsureCreated();
    }
}
