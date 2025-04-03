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
        // Method to check if an airport has flights departing or arriving
        public bool HasDepartingFlights()
        {
            return DepartingFlights != null && DepartingFlights.Any();
        }

        public bool HasArrivingFlights()
        {
            return ArrivingFlights != null && ArrivingFlights.Any();
        }

        // Method to display airport information and flight counts
        public string GetAirportInfo()
        {
            return $"{Name} ({Code}) in {Location} has {DepartingFlights?.Count ?? 0} departing flights and {ArrivingFlights?.Count ?? 0} arriving flights.";
        }
    }
}
    

