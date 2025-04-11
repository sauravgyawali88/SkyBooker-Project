using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyBooker_Project.Models
{
    public class Booking
    {
        public string BookingID { get; set; }  // Unique ID for the booking
        public string UserID { get; set; }  // ID of the user who made the booking
        public string FlightID { get; set; }  // ID of the flight that was booked
        public DateTime BookingDate { get; set; }  // Date and time when the booking was made
        public bool PaymentStatus { get; set; }  // Whether the payment was successful (true/false)
        public decimal TotalAmount { get; set; }  // Total cost of the booking

        // Navigation properties to link to the User and Flight models
        public User User { get; set; }  // The user who made the booking
        public Flight Flight { get; set; }  // The flight that was booked

        public string BookingStatus => PaymentStatus ? "Completed" : "Pending";  // Returns the booking status based on payment status
  
        public bool IsRefundEligible() => !PaymentStatus && (DateTime.Now - BookingDate).TotalHours < 24;

public void CancelBooking()
{
    PaymentStatus = false;
    // Additional cancellation logic here (e.g., notify user, update seat availability)
}

public decimal CalculateDiscount(decimal discountRate) => TotalAmount * (1 - discountRate);

public string GetSummary() => $"Booking {BookingID} for Flight {FlightID} - Status: {BookingStatus}";

    }
}


