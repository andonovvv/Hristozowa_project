using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_journey
{
    public partial class Form1 : Form
    {
        public double distance { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click_Click(object sender, EventArgs e)
        {
            try
            {

                //get journey distance in miles
                Double distance = Convert.ToDouble(txtDistance.Text);
                if (rbtnKm.Checked == true)
                {
                    distance = distance * 0.621;
                }
            }
            catch
            {
                MessageBox.Show("Incorrect data entered");
            }
            //calculate fuel required
            Double mpg = Convert.ToDouble(txtMpg.Text);
            //fuel required in gallons
            Double fuelRequired = distance / mpg;
            //convert to litres
            fuelRequired = fuelRequired * 4.546;
            //output litres of fuel (1 decimal place)
            string output = fuelRequired.ToString("f1");
            txtLitres.Text = output;
            //calculate cost of fuel
            Double fuelPrice = Convert.ToDouble(txtFuelPrice.Text);
            Double totalCost = fuelRequired * fuelPrice;
            //output fuel cost (2 decimal places)
            output = totalCost.ToString("f2");
            txtJourneyCost.Text = Convert.ToString(output);
            //get % motorway travel and number of town centres crossed
            Double motorwayPercent = Convert.ToDouble(txtMotorways.Text);
            int townCentres = Convert.ToInt16(txtTowns.Text);
            //calculate number of miles travelled on motorways and other roads
            Double motorwayMiles = distance * motorwayPercent / 100;
            Double otherMiles = distance - motorwayMiles;
            //calculate road journey in hours, then multiply by 60 to convert to minutes
            Double totalMinutes = (motorwayMiles / 60 + otherMiles / 35) * 60;
            //add 20 minutes for each town centre crossed
            totalMinutes = totalMinutes + (townCentres * 20);
            //find the journey time in hours and minutes
            int hours = Convert.ToInt16(totalMinutes) / 60;
            int minutes = Convert.ToInt16(totalMinutes) % 60;
            //output the results
            txtHours.Text = Convert.ToString(hours);
            txtMinutes.Text = Convert.ToString(minutes);
        }
    }
}

