using FirstWebApp.Core;
using FirstWebApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace FirstWebApp.Data
{
    public class FirstWebAppDbContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }

        public FirstWebAppDbContext(DbContextOptions<FirstWebAppDbContext> options) : base(options)
        {

        }
    }
}