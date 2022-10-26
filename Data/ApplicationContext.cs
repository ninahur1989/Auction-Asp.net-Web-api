using MarketPlace.Models;
using Microsoft.EntityFrameworkCore;

namespace MarketPlace.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Sale> Sales { get; set; }
    }
}
