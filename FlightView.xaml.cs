using System.Windows;
using SkyBooker_Project.ViewModels;

namespace SkyBooker_Project.Views
{
    public partial class FlightView : Window
    {
        public FlightView()
        {
            InitializeComponent();

            // Set the DataContext to the ViewModel
            this.DataContext = new FlightViewModel();  // Or inject the ViewModel using Dependency Injection
        }
    }
}
