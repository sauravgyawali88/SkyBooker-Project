using System.Windows;
using SkyBooker.ViewModels;

namespace SkyBooker.Views
{
    public partial class PaymentView : Window
    {
        public PaymentView()
        {
            InitializeComponent();

            // Set the DataContext to the PaymentViewModel
            this.DataContext = new PaymentViewModel();  // Or inject the ViewModel using Dependency Injection
        }
    }
}
