using Microsoft.EntityFrameworkCore;
using OnlineStore.Domain;

namespace OnlineStore.Infrastructure.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
            Database.EnsureCreated();
        }


    }
}
