using SkyBooker.Models;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace SkyBooker.ViewModels
{
    public class PaymentViewModel : BaseViewModel
    {
        private Payment _selectedPayment;
        public ObservableCollection<Payment> Payments { get; set; }  // List of payments
        public Payment SelectedPayment
        {
            get { return _selectedPayment; }
            set
            {
                _selectedPayment = value;
                OnPropertyChanged(nameof(SelectedPayment));
            }
        }

        // Command for processing the payment
        public ICommand ProcessPaymentCommand { get; set; }

        public PaymentViewModel()
        {
            Payments = new ObservableCollection<Payment>
            {
                new Payment
                {
                    PaymentID = "P001",
                    BookingID = "B001",
                    Amount = 150.00m,
                    PaymentDate = DateTime.Now,
                    PaymentMethod = "Credit Card",
                    PaymentStatus = false  // Payment not completed yet
                },
                new Payment
                {
                    PaymentID = "P002",
                    BookingID = "B002",
                    Amount = 200.00m,
                    PaymentDate = DateTime.Now.AddMinutes(-30),
                    PaymentMethod = "PayPal",
                    PaymentStatus = true  // Payment completed
                }
            };

            // Initialize the ProcessPayment command
            ProcessPaymentCommand = new CommandHandler((obj) => ProcessPayment(), (obj) => CanProcessPayment());
        }

        // Process the payment (e.g., mark as completed)
        private void ProcessPayment()
        {
            if (SelectedPayment != null && !SelectedPayment.PaymentStatus)
            {
                SelectedPayment.PaymentStatus = true;  // Mark the payment as successful
                OnPropertyChanged(nameof(SelectedPayment));  // Notify that the PaymentStatus changed
            }
        }

        // Command can only execute if a payment is selected and hasn't been processed
        private bool CanProcessPayment()
        {
            return SelectedPayment != null && !SelectedPayment.PaymentStatus;
        }
    }
}
