using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgencyRivkyandRivki
{
    class InvalidDataException:Exception
    {
        public InvalidDataException(string s):base("You have entered invalid data") //displays this when this exception is thrown
        {
            
        } //end of exception

    } //end of class

} //end of namespace
