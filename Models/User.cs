using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyBooker_Project.Models
{
    public class User
    {
        public string UserID { get; set; }  // Unique ID for the user
        public string UserName { get; set; }  // Full name of the user
        public string Email { get; set; }  // User's email address
        public string Password { get; set; }  // Password for the user
        public int FrequentFlyerPoints { get; set; }  // Points the user has accumulated
        public string PreferredAirline { get; set; }  // The user's preferred airline
    }
}