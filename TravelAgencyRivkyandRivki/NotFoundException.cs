using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgencyRivkyandRivki
{
    class NotFoundException:Exception
    {
        public NotFoundException(string s) : base("This Person/Flight does not exist!") //displays this when the card is expired
        {

        } //end of exception

    } //end of class

} //end of namespace
