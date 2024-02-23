using DafAirplane.Entities;

namespace DafAirplane.Services
{
    public interface IFlightService
    {
        Task<List<Flight>> GetAllFlights();
    }
}
