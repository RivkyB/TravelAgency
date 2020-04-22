using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgencyRivkyandRivki
{
    class DuplicateDataExcception:Exception
    {
        public DuplicateDataExcception(string s) : base("You have already been entered.") //displays this when the card is expired
        {

        } //end of exception

    } //end of class

} //end of namespace

