using DafAirplane.Entities;
using Microsoft.EntityFrameworkCore;

namespace DafAirplane.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Flight> Flights { get; set; }
    }
}
