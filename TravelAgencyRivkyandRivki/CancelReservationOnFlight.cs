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
    public partial class CancelReservationOnFlight : Form
    {
        public CancelReservationOnFlight()
        {
            InitializeComponent();
        }

        public void CancelReservationOnFlightMethod(int flightnum, DateTime deptdate, int passID, int seatnum)
        {
            foreach(Person prsn in TravelAgency.people)
            {
                if(prsn is Passenger)
                {
                    Passenger pass = prsn as Passenger;
                    if(pass.Id == passID)
                    {
                        foreach (ScheduledFlight flight in TravelAgency.scheduledflights)
                        {
                            if (flight.FlightID == flightnum && flight.DepartureDate == deptdate)
                            {
                                flight.CancelReservationFlight(pass, seatnum);
                            }
                            else
                            {
                                TravelAgency.FindFlight(flightnum, deptdate);
                            }
                         
                        }                        
                    }
                    else
                    {
                        throw new NotFoundException("Passenger Not Found");
                    }
                }
            }
        }

        private void CancelRservationbutton1_Click(object sender, EventArgs e)
        {
            CancelReservationOnFlightMethod(int.Parse(flightNumbertextBox1.Text), DateTime.Parse(depDatedateTimePicker1.Text), int.Parse(PasengerIDtextBox1.Text), int.Parse(SeatNumbertextBox1.Text));
            MessageBox.Show("Passenger " +PasengerIDtextBox1.Text + " - Your Reservation was cancelled!");
            flightNumbertextBox1.Clear();
            depDatedateTimePicker1.ResetText();
            PasengerIDtextBox1.Clear();
            SeatNumbertextBox1.Clear();
        
        }
    }
}
