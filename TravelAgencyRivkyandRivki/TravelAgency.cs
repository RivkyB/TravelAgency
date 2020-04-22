using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TravelAgencyRivkyandRivki
{
    public partial class TravelAgency : Form
    {
        public static List<Person> people = new List<Person>(); //list of type ppl
        public static List<ScheduledFlight> scheduledflights = new List<ScheduledFlight>();//listofscheduledflights

        public static bool whoToSearch = true; //if true, search customer else if false search passenger

        public TravelAgency()
        {
            InitializeComponent(); 
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomer cust = new AddCustomer();
            cust.MdiParent = this;
            cust.Show();
        }

        private void addTravelAgentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTravelAgent trav = new AddTravelAgent();
            trav.MdiParent = this;
            trav.Show();
            
        }

        private void addPassengerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPassenger adam = new AddPassenger();
            adam.MdiParent = this;
            adam.Show();
        }

        private void TravelAgency_Load(object sender, EventArgs e)
        {
            
        }

        private void allPassengersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayPeopleForm displayso = new DisplayPeopleForm();

            displayso.Text = "Display All Passengers";
            displayso.EnterIDNumberLabel.Visible = false;
            displayso.EnterIDNumberTextBox.Visible = false;
            displayso.SearchButton.Visible = false;
            displayso.MdiParent = this;
            displayso.Show();
        }

        private void displayAPassengerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayPeopleForm displayso = new DisplayPeopleForm();
            displayso.Text = "Display A Passenger";
            displayso.MdiParent = this;
            displayso.Displayallbutton1.Visible = false;
            displayso.Show();
            whoToSearch = false;
            displayso.PassengerListBox.Items.Clear();
            displayso.EnterIDNumberTextBox.Clear();

        }
        private void DisplayACustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayPeopleForm displayso = new DisplayPeopleForm();
            displayso.Text = "Display A Customer";
            displayso.MdiParent = this;
            displayso.Displayallbutton1.Visible = false;
            displayso.Show();
            whoToSearch = true;
            displayso.PassengerListBox.Items.Clear();
            displayso.EnterIDNumberTextBox.Clear();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm loadinfor = new LoadForm();
            loadinfor.MdiParent = this;
            loadinfor.Show();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveForm saveinfo = new SaveForm();
            saveinfo.MdiParent = this;
            saveinfo.Show();
        }

        private void AddAScheduledFlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddScheduledFlight asfform = new AddScheduledFlight();
            asfform.MdiParent = this;
            asfform.Show();
        }
        
        private void BookASeatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookSeatOnFlight bsfform = new BookSeatOnFlight();
            bsfform.MdiParent = this;
            bsfform.Show();
        }
        public static void FindFlight(int flightnum, DateTime departuredate)
        {
            foreach(ScheduledFlight flight in scheduledflights)
            {
                if (flight.FlightID!=flightnum||flight.DepartureDate!=departuredate)
                {
                    throw new NotFoundException("flight not found");
                }
            }
        }

        private void CancelAReservationOnAFlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CancelReservationOnFlight crf = new CancelReservationOnFlight();
            crf.MdiParent = this;
            crf.Show();
        }

        private void DisplayAScheduledFlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayScheduledFlight dsf = new DisplayScheduledFlight();
            dsf.MdiParent = this;
            dsf.Show();
        }

        private void DisplayAllPeopleOnFlightsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayAllPeopleAndFlights peopleandflights = new DisplayAllPeopleAndFlights();
            peopleandflights.MdiParent = this;
            peopleandflights.Show();
        }
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
