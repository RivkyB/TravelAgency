using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgencyRivkyandRivki
{
    class InvalidPhoneNumber:InvalidDataException
    {
        public InvalidPhoneNumber(string s):base("You have entered an invalid phone number") //Displays this when this exception is thrown
        {

        } //end of exception

    } //end of class

} //end of namespace
