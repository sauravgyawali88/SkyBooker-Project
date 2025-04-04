using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using SkyBooker_Project.Models;

namespace SkyBooker_Project.ViewModels
{
    public class FlightViewModel : BaseViewModel
    {
        private Flight _selectedFlight;
        public ObservableCollection<Flight> Flights { get; set; }
        
        public Flight SelectedFlight
        {
            get { return _selectedFlight; }
            set
            {
                _selectedFlight = value;
                OnPropertyChanged(nameof(SelectedFlight));
            }
        }

        // Command for booking a flight (For example, when a button is clicked)
        public ICommand BookFlightCommand { get; set; }

        public FlightViewModel()
        {
            // Sample data for Flights
            Flights = new ObservableCollection<Flight>
            {
                new Flight
                {
                    FlightID = "AB123",
                    DepartureDate = new DateTime(2025, 5, 1, 14, 30, 0),
                    ArrivalDate = new DateTime(2025, 5, 1, 16, 30, 0),
                    Airline = "SkyAir",
                    Price = 200.00m,
                    AvailableSeats = 5
                },
                new Flight
                {
                    FlightID = "XY456",
                    DepartureDate = new DateTime(2025, 5, 2, 10, 30, 0),
                    ArrivalDate = new DateTime(2025, 5, 2, 12, 30, 0),
                    Airline = "FlyHigh",
                    Price = 180.00m,
                    AvailableSeats = 10
                }
            };

            // Initialize the command
            BookFlightCommand = new RelayCommand(BookFlight, CanBookFlight);
        }

        // Book flight method
        private void BookFlight(object parameter)
        {
            if (SelectedFlight != null && SelectedFlight.HasAvailableSeats())
            {
                SelectedFlight.AvailableSeats -= 1;  // Decrease available seats
                OnPropertyChanged(nameof(SelectedFlight));  // Notify that the AvailableSeats property changed
            }
        }

        // Command can be executed only if there is a selected flight
        private bool CanBookFlight(object parameter)
        {
            return SelectedFlight != null && SelectedFlight.HasAvailableSeats();
        }
    }
}
