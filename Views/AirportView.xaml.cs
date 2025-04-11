using SkyBooker.ViewModels;
using SkyBooker.Models;

namespace SkyBooker.Views
{
    public partial class AirportView : Window
    {
        public AirportView()
        {
            InitializeComponent();

            // Create an Airport model instance (for demonstration)
            var airport = new Airport
            {
                Name = "Example Airport",
                Code = "EXA",
                Location = "Example City",
                DepartingFlights = new List<Flight>(),
                ArrivingFlights = new List<Flight>()
            };

            // Set the DataContext to the ViewModel
            this.DataContext = new AirportViewModel(airport);
        }
    }
}
