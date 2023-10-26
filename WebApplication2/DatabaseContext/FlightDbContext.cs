
using WebApplication2.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplication2.DatabaseDbContext
{
    public class FlightDbContext : DbContext
    {


        public FlightDbContext(DbContextOptions options) : base(options) 
        {

        }

        public DbSet<Flight> Flights { get; set; }
    }
}
