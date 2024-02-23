namespace DafAirplane.Entities
{
    public class Flight
    {
        public int Id { get; set; }
        public required string Airport { get; set; }
        public required string City { get; set; }
        public required string Flightnumber { get; set; }
        public DateTime Arrival { get; set; }
        public DateTime Departure { get; set; }
    }
}
