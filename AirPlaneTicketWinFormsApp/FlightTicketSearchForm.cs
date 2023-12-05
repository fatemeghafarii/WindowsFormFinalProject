using AirPlaneTicketWinFormsApp.Airlines;
using AirPlaneTicketWinFormsApp.Flights;
using AirPlaneTicketWinFormsApp.UserControls;
using Library.Model.Models;
using Library.Persistence.IRepositories;
using Library.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AirPlaneTicketWinFormsApp
{
    public partial class FlightTicketSearchForm : Form
    {
        private readonly IReadRepository repository;

        private readonly TicketTypeControl1 ticketTypeControl;
        private readonly TicketTypeControl2 multiCityControl;

        private readonly List<TicketTypeControl2> multiCityControls;
        private readonly List<FlightClass> listFlightClass;

        public FlightTicketSearchForm()
        {
            InitializeComponent();
            
            repository = new ReadRepository();
            listFlightClass = new List<FlightClass>();
            LoadData();

            ticketTypeControl = new TicketTypeControl1();
            multiCityControl = new TicketTypeControl2();

            multiCityControls = new List<TicketTypeControl2>();
            
        }

        private void LoadData()
        {
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
            CbFlightClass.SelectedIndex = -1;
            //foreach (var dataRow in flightClassDataTable.Select())
            //{
            //    var obj = new FlightClass()
            //    {
            //        Name = dataRow["SeatClass"].ToString(),
            //        Id = Convert.ToInt32(dataRow["Id"].ToString())
            //    };
            //    listFlightClass.Add(obj);

            //}
            //CbFlightClass.DataSource = listFlightClass;
            //CbFlightClass.ValueMember = "Id";
            //CbFlightClass.DisplayMember = "Name";
            //CbFlightClass.SelectedIndex = -1;
        }

        public RJButton RJButton { get; set; }
        public DateTimePicker DateTime { get; set; }

        private void FlightSelectForm_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Add(ticketTypeControl);
            BtnAddFlight.Visible = false;
        }
        private void BtnOneWay_Click(object sender, EventArgs e)
        {
            var test = new TicketTypeControl1();
            ticketTypeControl.Visible = true;
            flowLayoutPanel1.Controls.Add(ticketTypeControl);
            multiCityControl.Hide();
            multiCityControl.Enabled = false;
            BtnAddFlight.Visible = false;
            multiCityControls.ForEach(x => x.Visible = false);

            ticketTypeControl.DtpDeparture.Visible = false;
            ticketTypeControl.rjToggleButton1.Click += (o, e) => { ticketTypeControl.DtpDeparture.Visible = true; };
        }
        private void BtnRoundTrip_Click(object sender, EventArgs e)
        {
            ticketTypeControl.DtpDeparture.Visible = true;
            ticketTypeControl.Visible = true;
            flowLayoutPanel1.Controls.Add(ticketTypeControl);
            multiCityControl.Hide();
            multiCityControl.Enabled = false;
            BtnAddFlight.Visible = false;
            multiCityControls.ForEach(x => x.Visible = false);
        }
        private void BtnMultiCity_Click(object sender, EventArgs e)
        {
            multiCityControl.Show();
            ticketTypeControl.Visible = false;
            BtnAddFlight.Visible = true;
            multiCityControl.Enabled = true;
            flowLayoutPanel1.Controls.Add(multiCityControl);
        }

        private void BtnAddFlight_Click(object sender, EventArgs e)
        {
            if (multiCityControls.Count < 5)
            {
                var test = new TicketTypeControl2();
                flowLayoutPanel1.Controls.Add(test);
                multiCityControls.Add(test);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddImageLogoAirlineForm frm = new AddImageLogoAirlineForm();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddFlightTicketForm frm = new AddFlightTicketForm();
            frm.Show();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            //CbFlightClass.SelectedItem
            var frm = new FlightTicketSearchResultDisplayForm(ticketTypeControl, this);
            frm.Show();
        }
    }
}
