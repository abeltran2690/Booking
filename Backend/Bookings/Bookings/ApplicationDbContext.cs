using Bookings.Entities;
using Microsoft.EntityFrameworkCore;

namespace Bookings
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options): base(options)
        {
           
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
