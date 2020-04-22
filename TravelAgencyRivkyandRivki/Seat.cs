using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgencyRivkyandRivki
{
    public class Seat
    {
        public bool Available { get; set; }
        public Passenger Pass1 { get; set; }
        public string SeatType { get; set; }
        public int SeatNumber { get; set; }

        public Seat(string seattype, int seatnumber) //Constructor
        {
            SeatType = seattype;
            SeatNumber = seatnumber;
            InvalidSeatType(SeatType);
            Available = true;
            //Pass1 = null;  
        } //end of constructor
        public void BookSeat(Seat seat) //method to book a seat
        {
            if (seat.Available == true)
                seat.Available = false;
            //it becomes not available
            else
                IsSeatAvailable(seat.Available);
        } //end of method

        public void CancelReservation() //method to cancel reservation
        {
            if (Available == false)
                Available = true;
            else
                IsSeatAvailable(Available);
        } //end of method

        public void InvalidSeatType(string seatType) //throws exception if invalid number
        {
            try
            {
                if (seatType == null)
                {
                    throw new InvalidSeatType("Invalid SeatType");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        } //end of exception

        public void IsSeatAvailable(bool available) //throws exception if invalid number
        {
            try
            {
                if (available == false)
                {
                    throw new SeatNotAvailableException("SeatNotAvailable");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        } //end of exception

        //public void IsSeatAvailable1(bool available) //throws exception if seat was available because otherwise the seat was never booked
        //{
        //    try
        //    {
        //        if (available == true)
        //        {
        //            throw new SeatNotAvailableException("Your seat was never booked!");
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }

        //} //end of exception

        public override string ToString() //Override ToString
        {
            return "Your Seat Type: " + SeatType;
        } //End of ToString

    }//end of class

}//end of namespace
