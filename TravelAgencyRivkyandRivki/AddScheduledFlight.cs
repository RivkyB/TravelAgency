using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgencyRivkyandRivki
{
    public partial class AddScheduledFlight : Form
    {
        public AddScheduledFlight()
        {
            InitializeComponent();
        }

        public void AddScheduledFlightMethod(DateTime d, int flightnum)
        {
            ScheduledFlight flight1 = new ScheduledFlight(d, flightnum);
            TravelAgency.scheduledflights.Add(flight1);
            //foreach (ScheduledFlight flight in TravelAgency.scheduledflights)
            //{
            //    if (flight.FlightID == flightnum && flight.DepartureDate == d)
            //    {
            //        TravelAgency.scheduledflights.Add(flight1);
            //    }
            //    else
            //    {
            //        TravelAgency.FindFlight(flightnum, d);
            //    }
            //}
        }

        private void ScheduleFlightbutton_Click(object sender, EventArgs e)
        {
            AddScheduledFlightMethod(DateTime.Parse(SchedFlightdateTimePicker1.Text), int.Parse(FlightNumbertextBox1.Text));
            MessageBox.Show("Flight " + FlightNumbertextBox1.Text + " was added");
            SchedFlightdateTimePicker1.ResetText();
            FlightNumbertextBox1.Clear();
        }
    }
}
