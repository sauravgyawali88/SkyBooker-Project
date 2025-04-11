using SkyBooker_Project.Models;
using SkyBooker_Project.Services;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace SkyBooker_Project.ViewModels
{
    public class FlightViewModel : BaseViewModel
    {
        private readonly FlightService flightService;
        public ObservableCollection<Flight> Flights { get; set; } = new();

        public ICommand LoadFlightsCommand { get; }

        public FlightViewModel()
        {
            flightService = new FlightService();
            LoadFlightsCommand = new Command(async () => await LoadFlightsAsync());
        }

        private async Task LoadFlightsAsync()
        {
            var list = await flightService.GetAvailableFlightsAsync();
            Flights.Clear();
            foreach (var flight in list)
                Flights.Add(flight);
        }
    }
}
