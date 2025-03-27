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
}
}
