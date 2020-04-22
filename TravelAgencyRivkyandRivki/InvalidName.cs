using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgencyRivkyandRivki
{
    class InvalidName:InvalidDataException
    {
        public InvalidName(string s) : base("You have entered an invalid name") //displays this when this exception is thrown
        {

        } //end of exception

    } //end of class

} //end of namespace
