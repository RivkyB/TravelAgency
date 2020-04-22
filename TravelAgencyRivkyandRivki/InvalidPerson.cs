using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgencyRivkyandRivki
{
    class InvalidPerson:Exception
    {
        public InvalidPerson(string r) : base("the information for the person is not valid")
        {

        }
    }
}
