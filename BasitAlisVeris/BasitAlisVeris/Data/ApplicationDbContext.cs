using BasitAlisVeris.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace BasitAlisVeris.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public IEnumerable Cateories { get; internal set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure Category -> SubCategories (one-to-many)
            modelBuilder.Entity<Category>()
                .HasMany(c => c.SubCategories)
                .WithOne(sc => sc.Category)
                .HasForeignKey(sc => sc.Category_Id);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.SubCategory)
                .WithMany(sc => sc.Products)
                .HasForeignKey(p => p.SubCategory_Id)
                .OnDelete(DeleteBehavior.NoAction);  // Or DeleteBehavior.Restrict

            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.Category_Id)
                .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<Product>()
                .Property(p => p.Product_Price)
                .HasPrecision(18, 2);
        }
    }
}
