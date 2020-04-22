using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgencyRivkyandRivki
{
    public class Address //Class Address
    {
        public string Street { get; set; } //Properties Of Address
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }

        public Address(string street, string city, string state, string zipcode) //Constructor
        {
            this.Street = street;
            this.City = city;
            this.State = state;
            this.Zipcode = zipcode;
        } //End of constructor

        public void InvalidAddress(string street, string city, string state, string zipcode) //throws exception if invalid address
        {
            try
            {
                if (street==null||city==null||state==null||zipcode == null)
                {
                    throw new InvalidAddress("hello");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        } //end of exception

        public override string ToString() //Override ToString
        {
            return "Address: " + Street + " " + City + ", " + State + " " + Zipcode+" ";
        } //End of ToString

    } //End of class Address

} //End of namespace
