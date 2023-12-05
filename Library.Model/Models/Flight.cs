using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model.Models
{
    public class Flight
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public int TicketTypeId { get; set; }
        public string Airline { get; set; }
        public string Airplane { get; set; }
        public int FlightClassId { get; set; }
        public string SeatClass { get; set; }
        public DateTime FlightDate { get; set; }
        public string FlightDateString { get; set; }
        public DateTime LandingDate { get; set; }
        public string CityOrigin { get; set; }
        public string CityDestination { get; set; }
        public int CityOriginId { get; set; }
        public int CityDestinationId { get; set; }
        public string IATAOrigin { get; set; }
        public string IATADestination { get; set; }
        public DateTime FlightTime { get; set; }
        public DateTime LandingTime { get; set; }
        public DateTime TimeDifference { get; set; }
        public decimal Price { get; set; }

    }
}
