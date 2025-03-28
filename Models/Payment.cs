using System;

namespace SkyBooker.Models
{
    public class Payment
    {
        public string PaymentID { get; set; }  // Unique ID for the payment
        public string BookingID { get; set; }  // ID of the booking associated with this payment
        public decimal Amount { get; set; }  // Total amount of the payment
        public DateTime PaymentDate { get; set; }  // Date and time the payment was made
        public string PaymentMethod { get; set; }  // Payment method (e.g., Credit Card, PayPal, etc.)
        public bool PaymentStatus { get; set; }  // Whether the payment was successful (true/false)

        // Navigation property to link to the Booking model
        public Booking Booking { get; set; }  // The booking associated with this payment
    }
}
