using Library.Model.Models;
using Library.Persistence.IRepositories;
using Library.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirPlaneTicketWinFormsApp.UserControls
{
    public partial class UserFlightSearchControl : UserControl
    {
        public UserFlightSearchControl(Flight flight)
        {
            InitializeComponent();
            LblFlightClass.Text = flight.SeatClass;
            LblFlightDate.Text = flight.FlightDate.ToShortDateString();
            LblCityOrigin.Text = flight.CityOrigin;
            LblCityDestination.Text = flight.CityDestination;
            //LoadData();
            //LblFlightClass.Text = flight.FlightClass.ToString();
            //LblFlightDate.Text = flight.FlightDate.ToShortDateString();
            //LblCityOrigin.Text = flight.CityOrigin;
            //LblCityDestination.Text = flight.CityDestination;

        }
        //private void LoadData()
        //{
        //    var dataTable = repository.GetById("Usp_Flight_UserFlightSearch");
        //    var row = dataTable.Select().FirstOrDefault();
        //    LblFlightClass.Text = row["SeatClass"].ToString();
        //    LblCityOrigin.Text = row["CityOrigin"].ToString();
        //    //LblCityDestination.Text = row["CityDestination"].ToString();
        //}
    }
}
