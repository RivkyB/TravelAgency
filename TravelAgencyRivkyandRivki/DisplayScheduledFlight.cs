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
    public partial class DisplayScheduledFlight : Form
    {
        public DisplayScheduledFlight()
        {
            InitializeComponent();
        }

        public void DisplayScheduledFlightMethod(int flightID, DateTime deptdate)
        {
            bool found = false;
            foreach (ScheduledFlight fl in TravelAgency.scheduledflights)
            {
                if (fl.FlightID == flightID && fl.DepartureDate == deptdate)
                {
                    found = true;
                    List<string> layout = fl.ViewPlaneLayout(fl);
                    layout.Insert(0,"Flight: "+ Convert.ToString(flightID) + " " + Convert.ToString(deptdate));
                    displayflightlistBox1.Items.AddRange(layout.ToArray());
                    break;
                }
            }
            if (!found)
            {
                MessageBox.Show("this flight does not exist");
            }

        }
        private void Displayschedflightbutton1_Click(object sender, EventArgs e)
        {
            DisplayScheduledFlightMethod(int.Parse(flightIdtextBox1.Text), DateTime.Parse(deptdatedateTimePicker1.Text));
        }
    }
}
