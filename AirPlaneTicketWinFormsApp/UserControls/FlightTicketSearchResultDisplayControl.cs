using Library.Model.Models;
using System.Drawing;
using System.Windows.Forms;

namespace AirPlaneTicketWinFormsApp.UserControls
{
    public partial class FlightTicketSearchResultDisplayControl : UserControl
    {
        //private readonly int flightClassId;
        //private readonly DateTime flightDate;
        //private readonly DateTime landingDate;
        //private readonly int idCitytOrigin;
        //private readonly int idCityDestination;

        //private readonly IReadRepository repository;
        public FlightTicketSearchResultDisplayControl(Flight flight)
        {
            InitializeComponent();
            //repository = new ReadRepository();
            //this.flightClassId = flight.FlightClassId;
            //this.flightDate = flight.FlightDate;
            //this.landingDate = flight.LandingDate;
            //this.idCitytOrigin = flight.IdCityOrigin;
            //this.idCityDestination = flight.IdCityDestination;

            
            LblAirlineName.Text = flight.Airline;
            LblAirplaneModel.Text = flight.Airplane;
            LblFlightClass.Text = flight.SeatClass;
            LblFlightDate.Text = flight.FlightDate.ToShortDateString();
            ////LblLandingDate.Text = flight.LandingDate.ToShortDateString();
            LblCityOrigin.Text = flight.CityOrigin;
            LblCityDestination.Text = flight.CityDestination;
            LblIATAOrigin.Text = flight.IATAOrigin;
            LblIATADestination.Text = flight.IATADestination;
            LblFlightTime.Text = flight.FlightTime.ToShortTimeString();
            LblLandingTime.Text = flight.LandingTime.ToShortTimeString();
            LblTimeDifference.Text = flight.TimeDifference.ToShortTimeString();
            LblPrice.Text = flight.Price.ToString();
            var imagePath = PbxLogoImage.ImageLocation = flight.Image;
            PbxLogoImage.BackgroundImageLayout = ImageLayout.None;
            //repository = new ReadRepository();
            //LoadData(); 
        }
        private void LoadData()
        {
            //var dataTable = repository.FlightTicketSearch(flightClassId ,flightDate, landingDate, idCitytOrigin, idCityDestination, "Usp_Flight_FlightTicketSearch");


            //var flightTicketsSearchResult = dataTable.Select().Select(row =>
            //new Flight()
            //{
            //    Airline = row["AirlineName"].ToString(),
            //    Airplane = row["Model"].ToString(),
            //    FlightClass = row["SeatClass"].ToString(),
            //    FlightDate = Convert.ToDateTime(row["FlightDate"].ToString()),
            //    LandingTime = Convert.ToDateTime(row["LandingDate"].ToString()),
            //    CityOrigin = row["CityName"].ToString(),
            //    CityDestination = row["CityName"].ToString(),
            //    IATAOrigin = row["IATA"].ToString(),
            //    IATADestination = row["IATA"].ToString(),
            //    FlightTime = Convert.ToDateTime(row["FlightTime"].ToString()),
            //    LandingDate = Convert.ToDateTime(row["LandingTime"].ToString()),
            //    Price = Convert.ToDecimal(row["Price"].ToString())
            //}).ToList();


            //var row = dataTable.Select().ToList().First();
            //if (flightTicketsSearchResult  != null)/* row != null*/ 
            //{
            //    LblAirlineName.Text = row["AirlineName"].ToString();
            //    LblAirplaneModel.Text = row["Model"].ToString();
            //    LblFlightClass.Text = row["SeatClass"].ToString();
            //    LblFlightDate.Text = row["FlightDate"].ToString();
            //    LblLandingDate.Text = row["LandingDate"].ToString();
            //    LblCityOrigin.Text = row["CityName"].ToString();
            //    LblCityDestination.Text = row["CityName"].ToString();
            //    LblIATAOrigin.Text = row["IATA"].ToString();
            //    LblIATADestination.Text = row["IATA"].ToString();
            //    LblFlightTime.Text = row["FlightTime"].ToString();
            //    LblLandingTime.Text = row["LandingTime"].ToString();
            //    LblPrice.Text = row["Price"].ToString();
            //    LblTimeDifference.Text = row["DiffTime"].ToString();
            //    var imagePath = row["LogoImage"].ToString() == string.Empty
            //        ? ""
            //        : string.Concat(Directory.GetCurrentDirectory(), "\\Images\\", row["LogoImage"].ToString());

            //    if (!string.IsNullOrEmpty(imagePath))
            //        PbxLogoImage.BackgroundImage = Image.FromFile(imagePath);

            //}
            //else
            //    MessageBox.Show("No Flight");
        }

        private void GbxFlightTicket_Enter(object sender, System.EventArgs e)
        {

        }
    }
}
//row.ForEach(r =>
//{
//    var newGroupbox = new GroupBox();
//    var LblAirlineName = new Label();
//    LblAirlineName.Text = r["AirlineName"].ToString();
//    var LblAirplaneModel = new Label();
//    LblAirplaneModel.Text = r["Model"].ToString();
//    newGroupbox.Controls.Add(LblAirlineName);
//    newGroupbox.Controls.Add(LblAirplaneModel);
//    this.Controls.Add(newGroupbox);

//});