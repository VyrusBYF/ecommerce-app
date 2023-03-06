using Ecommerce_App_BE.Data;
using Ecommerce_App_BE.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce_App_BE
{
    public class EcommerceContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Cart> Carts { get; set; }
        //public DbSet<Notification> Notifications { get; set; }

        public EcommerceContext(DbContextOptions<EcommerceContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>().ToTable("User", "Users");
            builder.Entity<Product>().ToTable("Product", "Products");
            builder.Entity<Cart>().ToTable("Cart", "Shopping");
        }
    }
}
