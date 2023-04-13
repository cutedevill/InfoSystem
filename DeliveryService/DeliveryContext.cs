using Microsoft.EntityFrameworkCore;
using DeliveryService.Models;

namespace DeliveryService
{
    public class DeliveryContext : DbContext
    {
        public DeliveryContext(DbContextOptions<DeliveryContext> options) : base(options) { }

        public DbSet<Delivery> Deliveries { get; set; }

        public DeliveryContext()
        {
            Database.EnsureCreated();
        }
    }
}
