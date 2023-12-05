using Library.Persistence.IRepositories;
using Library.Persistence.Repositories;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using Library.Model.Models;
using System.Collections.Generic;
using System;
using System.IO;
using System.Drawing;

namespace AirPlaneTicketWinFormsApp.Airlines
{
    public partial class AddImageLogoAirlineForm : Form
    {
        private string ImagePhysicalPath;
        private string ImageFileName;
        private readonly IAirlineRepository repository;
        private readonly List<Airline> Airlines;
        public AddImageLogoAirlineForm()
        {
            InitializeComponent();
            repository = new AirlineRepository();
            Airlines = new List<Airline>();
        }
        private void SaveImagePath()
        {
            if (!string.IsNullOrEmpty(ImageFileName))
            {
                var currentDirectory = Directory.GetCurrentDirectory();
                var targetDirectory = string.Concat(currentDirectory, "/Images/");
                var imagePath = string.Concat(targetDirectory, ImageFileName);

                if (!Directory.Exists(targetDirectory))
                    Directory.CreateDirectory(targetDirectory);


                File.Copy(ImagePhysicalPath, imagePath, true);
            }
        }
        private void BtnAddImageLogoAirline_Click(object sender, EventArgs e)
        {
            SaveImagePath();

            Airline airline = new Airline()
            {
                Image = ImageFileName
            };

            int rowsAffected = repository.Add(airline);
            if (rowsAffected > 0)
            {
                MessageBox.Show("Success");
                this.Close();
            }
        }

        private void BtnBrowsePicture_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
                ImagePhysicalPath = openFileDialog1.FileName;
                ImageFileName = openFileDialog1.SafeFileName;
            }
        }
    }
}
