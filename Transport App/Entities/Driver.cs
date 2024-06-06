using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_App.Entities
{
    public class Driver
    {

        public int DriverId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string LicenseNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
