using Microsoft.EntityFrameworkCore;
using Elif.Models; // Models klasöründeki sınıfları kullanabilmek için

namespace Elif.Data
{
    public class ApplicationDbContext : DbContext
    {
        // Constructor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Veritabanı tablosunu temsil eden DbSet
        public DbSet<Product> Products { get; set; }
    }
}
