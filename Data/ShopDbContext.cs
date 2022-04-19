using Microsoft.EntityFrameworkCore;
using Shop.Areas.Admin.Models;
using Shop.Areas.Order.Models;

namespace Shop.Data
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext(DbContextOptions<ShopDbContext> dbContextOptions):base(dbContextOptions)
        {

        }

        public DbSet<Group> Groups { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductGroup> ProductGroups { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrdersDetail { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductGroup>().HasKey(ky => new { ky.ProductId, ky.GroupId });
            base.OnModelCreating(modelBuilder);
        }
    }
}
