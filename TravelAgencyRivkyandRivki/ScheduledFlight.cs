using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgencyRivkyandRivki
{
    public class ScheduledFlight
    {
        public DateTime DepartureDate { get; }
        public int FlightID { get; set; }
        public int AvailFirstClass { get; set;}
        public int AvailEconomyClass { get; set; }
        public static Seat[] seats = new Seat[10];

        public static List<Passenger> passengers = new List<Passenger>();

        public ScheduledFlight(DateTime departureDate, int flightID)
        {
            DepartureDate = departureDate;
            FlightID = flightID;
            AvailFirstClass = 5;
            AvailEconomyClass = 5;

            
            for(int i=0;i<seats.Length;i++)
            {
                if(i<5)
                {
                    seats[i] = new Seat("First Class",i);
                }
                else
                {
                    seats[i] = new Seat("Economy Class",i);
                }
            }

        }
        public string GetSeatType(int seatnum)
        {
            return seats[seatnum].SeatType;
        }

        public void BookSeatFlight(Passenger p, int seatnum)
        {
            try
            {
                int count = 0;
                foreach (Seat seat in seats)
                {
                    if (count == seats.Length)
                        throw new FullyBookedException("full flight");
                    if(count==seatnum)
                    {
                        if (!seats[seatnum].Available)
                            throw new SeatNotAvailableException("seat not available");

                        if (seat.Pass1 == p)
                            throw new DuplicateDataExcception("cannot book");
                        if (seats[seatnum].Available)
                        {
                            passengers.Add(p);
                            seats[seatnum].Pass1 = p;
                            seat.BookSeat(seat);
                            if (seatnum < 5)
                                AvailFirstClass--;
                            else
                                AvailEconomyClass--;
                        }
                    }
                    if (seat.Available)
                    {
                        count++;
                    }
                }             
            }
            catch(Exception e)
            {
               // MessageBox.Show(e.Message);
            }

        }
        public void CancelReservationFlight(Passenger p, int seatnum)
        {
            if (seats[seatnum].Pass1 != p)
                throw new InvalidDataException("invalid data");
            else
            {
                seats[seatnum].CancelReservation();
                passengers.Remove(p);
                if (seatnum < 5)
                    AvailFirstClass++;
                else
                    AvailEconomyClass++;
            }

        }
        public List<string> ViewPlaneLayout(ScheduledFlight flight)
        {
            try
            {
                List<string> es = new List<string>();

                foreach (Seat seat in seats)
                {
                    if (seat.Available)
                    {
                        es.Add("Seat " + seat.SeatNumber + ": " + seat.SeatType + "- Available");
                    }
                    else
                    {
                        es.Add("Seat " + seat.SeatNumber + " Is Occupied by: " +  seat.Pass1.FirstName + " " + seat.Pass1.LastName);
                    }
                    
                }
                return es;
            }
            catch (FormatException)
            {
                throw new FormatException("not valid");
            }
        }

        public override string ToString()
        {
            return "Flight " + FlightID + " "  + DepartureDate;
        }

    }
}
