using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_App.Entities
{
    public class Transport
    {
        public int TransportId { get; set; }
        public int DriverId { get; set; }
        public int RouteId { get; set; }
        public DateTime Date { get; set; }
        public string LoadDetails { get; set; }

        // Navigation properties
        public virtual Driver Driver { get; set; }
        public virtual Route Route { get; set; }
    }
}
