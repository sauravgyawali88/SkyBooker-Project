using SkyBooker_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkyBooker_Project.Services
{
    public class FlightService
    {
        private List<Flight> flights = new()
        {
            new Flight
            {
                FlightID = "FL001",
                Airline = "SkyJet",
                DepartureDate = DateTime.Now.AddDays(2).AddHours(3),
                ArrivalDate = DateTime.Now.AddDays(2).AddHours(6),
                Price = 199.99m,
                AvailableSeats = 12
            },
            new Flight
            {
                FlightID = "FL002",
                Airline = "AeroSwift",
                DepartureDate = DateTime.Now.AddDays(3).AddHours(5),
                ArrivalDate = DateTime.Now.AddDays(3).AddHours(9),
                Price = 149.99m,
                AvailableSeats = 8
            }
        };

        public Task<List<Flight>> GetAvailableFlightsAsync()
        {
            var available = flights.Where(f => f.HasAvailableSeats()).ToList();
            return Task.FromResult(available);
        }

        public Task<Flight> GetFlightByIdAsync(string flightId)
        {
            var flight = flights.FirstOrDefault(f => f.FlightID == flightId);
            return Task.FromResult(flight);
        }
    }
}
