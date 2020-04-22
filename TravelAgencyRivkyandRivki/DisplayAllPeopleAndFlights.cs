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
    public partial class DisplayAllPeopleAndFlights : Form
    {
        public DisplayAllPeopleAndFlights()
        {
            InitializeComponent();
        }

        private void DisplayAllbutton1_Click(object sender, EventArgs e)
        {
            foreach (Person p in TravelAgency.people)
            {
                DisplayAlllistBox1.Items.Add(p);
            }

            foreach (ScheduledFlight sf in TravelAgency.scheduledflights)
            {
                DisplayAlllistBox1.Items.Add(sf);
            }
        }
    }
}
