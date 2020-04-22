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
    public partial class BookSeatOnFlight : Form
    {
        public BookSeatOnFlight()
        {
            InitializeComponent();
        }
        public void BookSeatOnFlightMethod(int flightnum, DateTime dt, int custid, int passengerid, int seatnum, int empid, double price)
        //custid pays for the flight passengerid flighs
        {
            try
            {
                foreach (Person p in TravelAgency.people)
                {
                    if (p is Passenger)
                    {
                        Passenger ps = p as Passenger;
                        if (ps.Id == passengerid)
                        {
                            foreach(Passenger pas in ScheduledFlight.passengers)
                            {
                                if(pas.Passport==ps.Passport)//if the passenger is already booked with this passport then throw an exception
                                {
                                    throw new DuplicateDataExcception("already booked!");
                                }
                            }
                            foreach (ScheduledFlight flight in TravelAgency.scheduledflights)
                            {
                                if (flight.FlightID == flightnum && flight.DepartureDate == dt)
                                {
                                    flight.BookSeatFlight(ps, seatnum);
                                    foreach (Person per in TravelAgency.people)
                                    {
                                        if (per is TravelAgent)
                                        {
                                            TravelAgent ta = per as TravelAgent;
                                            if (ta.EmployeeID == empid)
                                            {
                                                ta.BookTicket(price);
                                                foreach (Person pers in TravelAgency.people)
                                                {
                                                    if (pers is Customer)
                                                    {
                                                        Customer cust = pers as Customer;
                                                        if (cust.CustomerID == custid)
                                                        {
                                                            cust.ChargeCard(price, cust.CC.expirationDate);
                                                            MessageBox.Show("Passenger " + ps.FirstName + " " + ps.LastName + " was added to flight " + FlightNumbertextBox.Text);
                                                            MessageBox.Show("your balance is now " +cust.CC.Balance);
                                                            MessageBox.Show("Travel Agents Earnings is now: " + ta.Earnings);
                                                        }//charge card
                                                        else
                                                        {
                                                            throw new NotFoundException("not found");
                                                        }
                                                    }//if pers is customer
                                                }//foreach person pers in people
                                            }//if travel agent ==empid
                                            else
                                            {
                                                throw new NotFoundException("not found");
                                            }
                                        }//if per is travelagent
                                    }//foreach person per in people
                                }//if flightid and dep date
                                else
                                {
                                    TravelAgency.FindFlight(flightnum, dt);
                                }//exception
                            }//foreach scheduled flight in flights
                        }//if id==id
                        else
                        {
                            throw new NotFoundException("no such person");
                        }//exception
                    }//if p is passenger
                }//foreach person p in peopl
            }//method bookseatonflight
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }
        private void BookSeatbutton1_Click(object sender, EventArgs e)
        {
            try
            {
                BookSeatOnFlightMethod(int.Parse(FlightNumbertextBox.Text), DateTime.Parse(DepartureDatedateTimePicker.Text), int.Parse(CustIDtextBox.Text),
                    int.Parse(PassIDtextBox1.Text), int.Parse(SeatNumtextBox.Text), int.Parse(EmpIDtextBox.Text), double.Parse(PricetextBox1.Text));
                FlightNumbertextBox.Clear();
                DepartureDatedateTimePicker.ResetText();
                CustIDtextBox.Clear();
                PassIDtextBox1.Clear();
                SeatNumtextBox.Clear();
                EmpIDtextBox.Clear();
                PricetextBox1.Clear();
            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message);
            }

        }
    }
}
