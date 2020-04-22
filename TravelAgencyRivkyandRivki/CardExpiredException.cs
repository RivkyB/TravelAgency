using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgencyRivkyandRivki
{
    class CardExpiredException:Exception
    {
        public CardExpiredException(string s) : base("Your card has expired") //displays this when the card is expired
        {

        } //end of exception

    } //end of class

} //end of namespace
