using DafAirplane.Data;
using DafAirplane.Entities;
using Microsoft.EntityFrameworkCore;

namespace DafAirplane.Services
{
    public class FlightService : IFlightService
    {
        private readonly DataContext _context;

        public FlightService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Flight>> GetAllFlights()
        {
            var flights = await _context.Flights.ToListAsync();
            return flights;
        }
    }
}
