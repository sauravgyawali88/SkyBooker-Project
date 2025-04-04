using System;
using System.ComponentModel.DataAnnotations;  // Import DataAnnotations namespace

namespace SkyBooker_Project.Models
{
    public class User
    {
        [Key]
        public string UserID { get; set; }  // Unique ID for the user

        [Required(ErrorMessage = "Full name is required.")]
        public string UserName { get; set; }  // Full name of the user

        [Required(ErrorMessage = "Email address is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }  // User's email address

        [Required(ErrorMessage = "Password is required.")]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters long.")]
        public string Password { get; set; }  // Password for the user

        public int FrequentFlyerPoints { get; set; }  // Points the user has accumulated

        public string PreferredAirline { get; set; }  // The user's preferred airline

        // Override ToString method to return user details as a string 
        public override string ToString()
        {
            return $"UserID: {UserID}, User
