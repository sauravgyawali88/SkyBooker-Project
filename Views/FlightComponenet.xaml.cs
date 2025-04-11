using SkyBooker_Project.Models;

namespace SkyBooker_Project.Components
{
    public partial class FlightListComponent : ContentView
    {
        public static readonly BindableProperty FlightsProperty =
            BindableProperty.Create(
                nameof(Flights),
                typeof(List<Flight>),
                typeof(FlightListComponent),
                propertyChanged: OnFlightsChanged);

        public List<Flight> Flights
        {
            get => (List<Flight>)GetValue(FlightsProperty);
            set => SetValue(FlightsProperty, value);
        }

        public FlightListComponent()
        {
            InitializeComponent();
        }

        private static void OnFlightsChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (FlightListComponent)bindable;
            if (newValue is List<Flight> flights)
            {
                control.FlightsCollectionView.ItemsSource = flights;
            }
        }
    }
}
