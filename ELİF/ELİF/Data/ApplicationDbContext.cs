using ELİF.Models;
using Microsoft.EntityFrameworkCore;
using ELİF.Models;

namespace ELİF.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<CartItem> CartItems { get; set; } // Sepet öğelerini veritabanında saklamak için DbSet
                                                      

        // Sepet öğelerini döndüren metot
        public IQueryable<CartItem> GetCartItems()
        {
            return CartItems;
        }

        // OnModelCreating metodu
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Laptop", Description = "High performance laptop", Price = 1500, ImageUrl = "laptop.jpg" },
                new Product { Id = 2, Name = "Smartphone", Description = "Latest model smartphone", Price = 800, ImageUrl = "smartphone.jpg" }
            );
        }
    }
}
