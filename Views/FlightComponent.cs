namespace SkyBooker.Views
{
    public class FlightListComponent
    {
        public List<Flight> Flights { get; set; }

        public FlightListComponent(Airport airport)
        {
            // Assuming we are displaying both departing and arriving flights
            Flights = airport.DepartingFlights.Concat(airport.ArrivingFlights).ToList();
        }

        public void DisplayFlights()
        {
            foreach (var flight in Flights)
            {
                Console.WriteLine($"Flight {flight.FlightNumber} - {flight.Status}");
            }
        }
    }
}
