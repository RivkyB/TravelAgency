using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgencyRivkyandRivki
{
    public class SeatNotAvailableException:Exception
    {
        public SeatNotAvailableException(string s):base("The seat is not available")
        {

        }

    } //end of class

} //end of class
