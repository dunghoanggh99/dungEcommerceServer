using dungAPI.DAL.Entities.Concrea;
using Microsoft.EntityFrameworkCore;

namespace dungAPI.DAL.Context
{
    public class dungContext : DbContext
    {
        public dungContext(DbContextOptions<dungContext> options):base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Coupon> Coupons { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderSale> OrderSales { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
