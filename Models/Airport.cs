namespace SkyBooker.Models
{
    public class Airport
    {
        public string AirportID { get; set; }  // Unique ID for the airport
        public string Name { get; set; }  // Name of the airport
        public string Location { get; set; }  // Location or city where the airport is located
        public string Code { get; set; }  // The IATA or ICAO code for the airport (e.g., JFK, LHR)

        // Navigation properties to link flights to airports
        public ICollection<Flight> DepartingFlights { get; set; }  // Flights departing from this airport
        public ICollection<Flight> ArrivingFlights { get; set; }  // Flights arriving at this airport
    }
}
