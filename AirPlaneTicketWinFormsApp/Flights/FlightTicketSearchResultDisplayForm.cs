using AirPlaneTicketWinFormsApp.UserControls;
using Library.Model.Models;
using Library.Persistence.IRepositories;
using Library.Persistence.Repositories;
using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AirPlaneTicketWinFormsApp.Flights
{
    public partial class FlightTicketSearchResultDisplayForm : Form
    {
        private readonly IReadRepository repository;
        private readonly Flight flight;
        private readonly int flightClassId;
        private readonly DateTime flightDate;
        private readonly int cityOriginId;
        private readonly int cityDestinationId;
        public FlightTicketSearchResultDisplayForm(TicketTypeControl1 ticketTypeControl1, FlightTicketSearchForm flightTicketSearchForm)
        {
            InitializeComponent();

            flight = new Flight();
            flight.FlightDate = ticketTypeControl1.DtpDepart.Value.Date;
            //flight.FlightDate = ticketTypeControl1.DtpDepart.Value.Date.GetDateTimeFormats();
            ////var time  = DateTime.ParseExact(ticketTypeControl1.DtpDepart.Value.ToString(), "yyyy/MM/dd", CultureInfo.InvariantCulture);
            //var time  = DateTime.Parse(ticketTypeControl1.DtpDepart.Value.ToString());
            //var test = time.ToString("yyyy/MM/dd");
            //var test1 = Convert.ToDateTime(test);
            //flight.FlightDate = test1;
            ////flight.LandingDate = ticketTypeControl1.DtpDeparture.Value.Date;
            flight.CityOriginId = (int)ticketTypeControl1.CbOrigin.SelectedValue;
            flight.CityDestinationId = (int)ticketTypeControl1.CbDestination.SelectedValue;
            flight.FlightClassId = (int)flightTicketSearchForm.CbFlightClass.SelectedValue;

            repository = new ReadRepository();
            
            this.flightClassId = flight.FlightClassId;
            this.flightDate = flight.FlightDate;
            ////this.landingDate = flight.LandingDate;
            this.cityOriginId = flight.CityOriginId;
            this.cityDestinationId = flight.CityDestinationId;
            LoadData();
            Test();
           
        }
        private void LoadData()
        {
            var dataTable = repository.GetFlightTicketSearchResult(flightClassId, flightDate/*, landingDate*/, cityOriginId, cityDestinationId, "Usp_Flight_GetFlightTicketSearchResult");


            var flights = dataTable.Select().Select(row =>
            new Flight()
            {
                Airline = row["AirlineName"].ToString(),
                Airplane = row["Model"].ToString(),
                SeatClass = row["SeatClass"].ToString(),
                FlightDate = Convert.ToDateTime(row["FlightDate"].ToString()),
                /////LandingTime = Convert.ToDateTime(row["LandingDate"].ToString()),
                CityOrigin = row["CityOrigin"].ToString(),
                CityDestination = row["CityDestination"].ToString(),
                IATAOrigin = row["IATA"].ToString(),
                IATADestination = row["IATA"].ToString(),
                FlightTime = Convert.ToDateTime(row["FlightTime"].ToString()),
                LandingTime = Convert.ToDateTime(row["LandingTime"].ToString()),
                TimeDifference = Convert.ToDateTime(row["TimeDifference"].ToString()),
                Price = Convert.ToDecimal(row["Price"].ToString()),
                Image = row["LogoImage"].ToString() == string.Empty
                ? ""
                : string.Concat(Directory.GetCurrentDirectory(), "\\Images\\", row["LogoImage"].ToString()),

            }).ToList();

            groupBox1.Controls.Add(Flp);

            

            flights.ForEach(row =>
            Flp.Controls.Add(new FlightTicketSearchResultDisplayControl(row)));
        }
        private void Test()
        {
            var dataTable = repository.GetUserSearch(cityOriginId, cityDestinationId, flightClassId, "Usp_Flight_GetUserSearch");
            var row = dataTable.Select().First();
            flight.CityOrigin = row["CityOrigin"].ToString();
            flight.CityDestination = row["CityDestination"].ToString();
            flight.SeatClass = row["SeatClass"].ToString();
            groupBox1.Controls.Add(new UserFlightSearchControl(flight));
            //flight.CityDestination = row["CityDestination"].ToString();
        }
    }
}