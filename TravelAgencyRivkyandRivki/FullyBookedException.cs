using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgencyRivkyandRivki
{
    class FullyBookedException:Exception
    {
        public FullyBookedException(string s) : base("the flight is fully booked")
        {

        }
    }
}
