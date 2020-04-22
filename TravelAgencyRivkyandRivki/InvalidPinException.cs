using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgencyRivkyandRivki
{
    class InvalidPinException:Exception //Class invalid pin exception
    {
        public InvalidPinException(string r):base("You have entered an invalid pin")//this is what it displays if this exception is thrown
        {

        }//end of exception

    } //end of class

} //end of namespace
