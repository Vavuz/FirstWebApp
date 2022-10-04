using FirstWebApp.Core;
using Microsoft.EntityFrameworkCore;

namespace FirstWebApp.Data
{
    public class FirstWebAppDbContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }

        public FirstWebAppDbContext(DbContextOptions<FirstWebAppDbContext> options) : base(options) { }
    }
}