using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgencyRivkyandRivki
{
    class InsufficientFundsException:Exception
    {
        public InsufficientFundsException(string s):base ("There is not enough money in your account") //displays this when there are not wnough funds on the card
        {

        } //end of exception

    } //end of class

} //end of namespace
