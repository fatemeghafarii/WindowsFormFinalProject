using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model.Models
{
    public class FlightClass
    {
        public FlightClass()
        {
            Flights = new HashSet<Flight>();
        }
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<Flight> Flights { get; set; }
    }
}
