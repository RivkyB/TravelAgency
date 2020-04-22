using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgencyRivkyandRivki
{
    class InvalidSeatType:InvalidDataException
    {
        public InvalidSeatType(string s) : base("You have entered an invalid seat type!") //displays this when this exception is thrown
        {

        } //end of exception

    } //end of class

} //end of namespace
