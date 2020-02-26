using Microsoft.EntityFrameworkCore;

namespace asp.net_core_store.Models
{
    public class OrderContext : DbContext
    {
        public OrderContext(DbContextOptions<OrderContext> options) : base(options)
        {
        }


        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<Order>().HasData(
                new Order { Id = 1, ItemName = "Product1", Price = 100, Cost = 90, Status = false},
                new Order { Id = 2, ItemName = "Product2", Price = 120, Cost = 100, Status = false},
                new Order { Id = 3, ItemName = "Product3", Price = 200, Cost = 150, Status = false },
                new Order { Id = 4, ItemName = "Product4", Price = 150, Cost = 120, Status = false }
            );
        }
    }
}