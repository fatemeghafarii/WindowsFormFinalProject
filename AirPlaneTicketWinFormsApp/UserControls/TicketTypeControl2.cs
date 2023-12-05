using Library.Model.Models;
using Library.Persistence.IRepositories;
using Library.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AirPlaneTicketWinFormsApp.UserControls
{
    public partial class TicketTypeControl2 : UserControl
    {
        private readonly ICityRepository airportRepository;
        private readonly List<City> listOrigin;
        private readonly List<City> listDestination;
        public TicketTypeControl2()
        {
            InitializeComponent();
            airportRepository = new CityRepository();
            var airportDataTable = airportRepository.Get("Usp_City_GetCities");
            listOrigin = new List<City>();
            foreach (var dataRow in airportDataTable.Select())
            {
                var obj = new City()
                {
                    Name = dataRow["CityName"].ToString(),
                    Id = Convert.ToInt32(dataRow["Id"].ToString())
                };
                listOrigin.Add(obj);

            }

            listDestination = new List<City>();
            foreach (var dataRow in airportDataTable.Select())
            {
                var obj = new City()
                {
                    Name = dataRow["CityName"].ToString(),
                    Id = Convert.ToInt32(dataRow["Id"].ToString())
                };
                listDestination.Add(obj);

            }
            CbOrigin.DataSource = listOrigin;
            CbOrigin.ValueMember = "Id";
            CbOrigin.DisplayMember = "Name";
            CbOrigin.SelectedIndex = -1;

            CbDestination.DataSource = listDestination;
            CbDestination.ValueMember = "Id";
            CbDestination.DisplayMember = "Name";
            CbDestination.SelectedIndex = -1;
        }

        private void LbOrigin_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbOrigin.SelectedItem = LbOrigin.SelectedItem;
            LbOrigin.Visible = false;
        }

        private void LbDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbDestination.SelectedItem = LbDestination.SelectedItem;
            LbDestination.Visible = false;
        }

        private void CbOrigin_TextChanged(object sender, EventArgs e)
        {
            // get the keyword to search
            string textToSearch = CbOrigin.Text.ToLower();

            LbOrigin.Visible = false; // hide the listbox, see below for why doing that
            if (String.IsNullOrEmpty(textToSearch))
                return; // return with listbox's Visible set to false if the keyword is empty
                        //search
            string[] result = (from i in listOrigin
                               where i.Name.ToLower().Contains(textToSearch)
                               select i.Name).ToArray();
            if (result.Length == 0)
                return; // return with listbox's Visible set to false if nothing found

            LbOrigin.Items.Clear(); // remember to Clear before Add
            LbOrigin.Items.AddRange(result);
            LbOrigin.Visible = false; // show the listbox again
        }

        private void CbDestination_TextChanged(object sender, EventArgs e)
        {
            // get the keyword to search
            string textToSearch = CbDestination.Text.ToLower();

            LbDestination.Visible = false; // hide the listbox, see below for why doing that
            if (String.IsNullOrEmpty(textToSearch))
                return; // return with listbox's Visible set to false if the keyword is empty
                        //search
            string[] result = (from i in listDestination
                               where i.Name.ToLower().Contains(textToSearch)
                               select i.Name).ToArray();
            if (result.Length == 0)
                return; // return with listbox's Visible set to false if nothing found

            LbDestination.Items.Clear(); // remember to Clear before Add
            LbDestination.Items.AddRange(result);
            LbDestination.Visible = false; // show the listbox again
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            //this.Controls.Remove(this);
        }
    }
}
