using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgencyRivkyandRivki
{
    class InvalidAddress:InvalidDataException
    {
        public InvalidAddress(string s):base("You have entered an invalid address") //displays this when there is an invalid address
        {

        } //end of exception

    } //end of class

} //end of namespace
