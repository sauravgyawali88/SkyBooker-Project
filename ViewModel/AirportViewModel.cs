namespace SkyBooker.ViewModels
{
    public class AirportViewModel
    {
        public Airport Airport { get; set; }

        public AirportViewModel(Airport airport)
        {
            Airport = airport;
        }

        // Command for displaying flights at the airport
        public void DisplayAirportInfo()
        {
            Console.WriteLine(Airport.GetAirportInfo());
        }
    }
}
