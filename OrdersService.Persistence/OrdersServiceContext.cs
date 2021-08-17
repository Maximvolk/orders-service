using Microsoft.EntityFrameworkCore;
using OrdersService.Core.Entities;

namespace OrdersService.Persistence
{
    public class OrdersServiceContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }

        public OrdersServiceContext(DbContextOptions<OrdersServiceContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Order>().ToTable("Orders");
            builder.Entity<Order>().Property(o => o.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Order>().Property(o => o.SourceCity).HasMaxLength(100);
            builder.Entity<Order>().Property(o => o.SourceAddress).HasMaxLength(100);
            builder.Entity<Order>().Property(o => o.DestinationCity).HasMaxLength(100);
            builder.Entity<Order>().Property(o => o.DestinationAddress).HasMaxLength(100);
        }
    }
}