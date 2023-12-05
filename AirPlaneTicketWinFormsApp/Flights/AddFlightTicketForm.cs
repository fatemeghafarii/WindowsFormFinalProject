using Library.Model.Models;
using Library.Persistence.Repositories;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;
using Library.Persistence.ConnectionStrings;

namespace AirPlaneTicketWinFormsApp.Flights
{
    public partial class AddFlightTicketForm : Form
    {

        private readonly SqlConnection sqlConnection;
        private readonly ReadRepository repository;
        public AddFlightTicketForm()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(ConnectionString.LibararyConnectionString);
            repository = new ReadRepository();
            LoadData();
        }
        private void LoadData()
        {
            var airplaneDataTable = repository.Get("Usp_Airplane_GetAirplanes");

            var airplanes = airplaneDataTable.Select().Select(row =>
            new Airplane
            {
                Id = Convert.ToInt32(row["Id"].ToString()),
                Name = row["Model"].ToString()
            });

            CbAirplane.DataSource = airplanes.ToList();
            CbAirplane.ValueMember = "Id";
            CbAirplane.DisplayMember = "Name";


            var flightClassDataTable = repository.Get("Usp_FlightClass_GetFlightClasses");

            var flightClasses = flightClassDataTable.Select().Select(row =>
            new FlightClass
            {
                Id = Convert.ToInt32(row["Id"].ToString()),
                Name = row["SeatClass"].ToString()
            });

            CbFlightClass.DataSource = flightClasses.ToList();
            CbFlightClass.ValueMember = "Id";
            CbFlightClass.DisplayMember = "Name";

            var airportDataTable = repository.Get("Usp_City_GetCities");

            var cities = airportDataTable.Select().Select(row =>
            new City
            {
                Id = Convert.ToInt32(row["Id"].ToString()),
                Name = row["CityName"].ToString()
            });

            CbOrigin.Items.Clear();
            CbOrigin.DataSource = cities.ToList();
            CbOrigin.ValueMember = "Id";
            CbOrigin.DisplayMember = "Name";

            CbDestination.Items.Clear();
            CbDestination.DataSource = cities.ToList();
            CbDestination.ValueMember = "Id";
            CbDestination.DisplayMember = "Name";

        }
        public int Add(Flight flight)
        {
            //string cbFlightClass = "";
            //string cbOrigin = "";
            //string cbDestination = "";
            //if (CbFlightClass.SelectedIndex >= 0)
            //    cbFlightClass = CbFlightClass.Items[CbFlightClass.SelectedIndex].ToString()!;
            //if (CbOrigin.SelectedIndex >= 0)
            //    cbOrigin = CbOrigin.Items[CbOrigin.SelectedIndex].ToString()!;
            //if (CbDestination.SelectedIndex >= 0)
            //    cbDestination = CbDestination.Items[CbDestination.SelectedIndex].ToString()!;

            //string command = "INSERT INTO Flight(FlightClassId,IdAirportOrigin,IdAirportDestination)VALUES" +
            //    "('" + CbFlightClass.SelectedText.ToString() + "','" + CbOrigin.SelectedText.ToString() +
            //    "','" + CbDestination.SelectedText.ToString() + "')";

            //string command = "INSERT INTO Flight(FlightClassId,IdAirportOrigin,IdAirportDestination)VALUES" +
            //   "('" + cbFlightClass + "','" + cbOrigin + "','" + cbDestination + "')";

            //var sqlCommand = new SqlCommand(command, sqlConnection);
            //sqlCommand.CommandType = CommandType.Text;
            //sqlCommand.CommandText = command;

            var sqlCommand = new SqlCommand("Usp_Flight_InsertFlight", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            //sqlCommand.Parameters.Add("@FlightClassId", CbFlightClass.GetItemText(CbFlightClass.SelectedItem));
            //sqlCommand.Parameters.Add("@Origin", CbOrigin.GetItemText(CbOrigin.SelectedItem));
            //sqlCommand.Parameters.Add("@Destination", CbDestination.GetItemText(CbDestination.SelectedItem));var sqlCommand = new SqlCommand("Usp_Flight_InsertFlight", sqlConnection);

            //sqlCommand.CommandType = CommandType.Text;
            //sqlCommand.Parameters.AddWithValue("@FlightClassId", CbFlightClass.GetItemText(CbFlightClass.SelectedItem));
            //sqlCommand.Parameters.AddWithValue("@Origin", CbOrigin.GetItemText(CbOrigin.SelectedItem));
            //sqlCommand.Parameters.AddWithValue("@Destination", CbDestination.GetItemText(CbDestination.SelectedItem)); 

            ////sqlCommand.Parameters.AddWithValue("@FlightDate", DtpFlightDate.Value.ToString("yyyy/MM/dd"));
            sqlCommand.Parameters.AddWithValue("@FlightDate", DtpFlightDate.Value.Date);
            //sqlCommand.Parameters.AddWithValue("@FlightDate", DtpFlightDate.Value.ToShortDateString());
            //sqlCommand.Parameters.AddWithValue("@LandingDate", DtpLandingDate.Value.Date);
            sqlCommand.Parameters.AddWithValue("@AirplaneId", CbAirplane.SelectedValue);
            sqlCommand.Parameters.AddWithValue("@FlightClassId", CbFlightClass.SelectedValue);
            sqlCommand.Parameters.AddWithValue("@CityOriginId", CbOrigin.SelectedValue);
            sqlCommand.Parameters.AddWithValue("@CityDestinationId", CbDestination.SelectedValue);
            sqlCommand.Parameters.AddWithValue("@FlightTime", TimeSpan.Parse(TxtFlightTime.Text));
            sqlCommand.Parameters.AddWithValue("@LandingTime", TimeSpan.Parse(TxtLandingTime.Text));
            //sqlCommand.Parameters.AddWithValue("@LandingTime", DateTime.ParseExact(TxtLandingTime.Text, "HH:mm", null));
            sqlCommand.Parameters.AddWithValue("@Price", flight.Price);
            
            //string flightClass = Convert.ToString(CbFlightClass.SelectedItem)!;
            //string origin = Convert.ToString(CbOrigin.SelectedItem)!;
            //string destination = Convert.ToString(CbDestination.SelectedItem)!;
            //string command  = "INSERT INTO Flight (FlightClassId,IdAirportOrigin,IdAirportDestination) values('"
            //    + flightClass + "','" + origin + "','" + destination + "')";

            //string command = "INSERT INTO Flight(FlightClassId,IdAirportOrigin,IdAirportDestination)VALUES" +
            //    "('" + CbFlightClass.SelectedValue + "','" + CbOrigin.SelectedValue +
            //    "','" + CbDestination.SelectedValue + "')";

            //for(int i = 0; i < CbFlightClass.Items.Count; i++)
            //{
            //    string command = "INSERT INTO Flight(FlightClassId)VALUES(@FlightClassId)";
            //    var sqlCommand = new SqlCommand(command, sqlConnection);
            //    sqlCommand.Parameters.AddWithValue("FlightClassId", CbFlightClass.Items[i]);
            //    sqlConnection.Open();

            //    var result = sqlCommand.ExecuteNonQuery();

            //    sqlConnection.Close();

            //}


            //sqlCommand.Parameters.AddWithValue("@FlightClassId", CbFlightClass.Text.ToString());
            //sqlCommand.Parameters.AddWithValue("@Origin", CbOrigin.Text.ToString());
            //sqlCommand.Parameters.AddWithValue("@Destination", CbDestination.Text.ToString());

            sqlConnection.Open();
            var result = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return result;
        }

        private void BtnAddFlightTicket_Click(object sender, EventArgs e)
        {
            Flight flight = new Flight()
            {
                Price = Convert.ToDecimal(TxtPrice.Text),
            };

            int rowsAffected =  Add(flight);
            if (rowsAffected > 0)
            {
                MessageBox.Show("Success");
                this.Close();
            }
        }

        private void dateTimePicker1_MouseDown(object sender, MouseEventArgs e)
        {
            ////dateTimePicker1.CustomFormat = "HH:mm";
        }
    }
}
