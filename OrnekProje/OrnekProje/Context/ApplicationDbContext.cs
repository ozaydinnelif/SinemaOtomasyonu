using Microsoft.EntityFrameworkCore;
using OrnekProje.Models;

namespace OrnekProje.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Contact> Contacts { get; set; }
    }
}
