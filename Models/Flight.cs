using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyBooker_Project.Models
{
    public class Flight
    {
        public string FlightID { get; set; }  // Unique ID for the flight
        public DateTime DepartureDate { get; set; }  // Departure date and time
        public DateTime ArrivalDate { get; set; }  // Arrival date and time
        public string Airline { get; set; }  // Airline name
        public decimal Price { get; set; }  // Price of the flight ticket
        public int AvailableSeats { get; set; }  // Number of available seats for booking

        public TimeSpan FlightDuration => ArrivalDate - DepartureDate;  // Calculates the duration of the flight

        // Method to check if the flight has available seats
        public bool HasAvailableSeats()
        {
            return AvailableSeats > 0;
        }

        // Method to get a brief summary of the flight
        public string GetFlightSummary()
        {
            return $"Flight {FlightID} operated by {Airline} from {DepartureDate} to {ArrivalDate}, Price: {Price:C}, Available Seats: {AvailableSeats}.";
        }

        // Method to calculate the price based on available seats (for example, dynamic pricing based on availability)
        public decimal GetDynamicPrice()
        {
            // Example of dynamic pricing: if less than 10 seats are available, increase the price by 10%
            if (AvailableSeats < 10)
            {
                return Price * 1.10m;  // Increase price by 10% if less than 10 seats
            }
            return Price;
        }

    }
}
