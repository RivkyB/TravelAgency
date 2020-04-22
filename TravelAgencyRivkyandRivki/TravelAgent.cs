using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgencyRivkyandRivki
{
    class TravelAgent: Person //Class TravelAgent of Type Person
    {
        public int EmployeeID { get; set; } //Properties of the class
        public double Earnings { get; set; }
        public string Ssn { get; set; }
        public static double commisionRate;  //This is static because it belongs to a class
        public double CommisionRate { get; set; }
        public int countofEmployees;
        public Address ktovet = new Address("a", "b", "c", "d");

        public TravelAgent(string firstName, string lastName, string gender, Address address, string phoneNumber, int empID, double earnings, string socialsn) 
            : base(firstName, lastName, gender, address, phoneNumber) //Constructor
        {
            EmployeeID = empID;
            Earnings = earnings;
            Ssn = socialsn;
            CommisionRate=commisionRate = 0.1D;
            try
            {
                InvalidAddress(address);
                InvalidName(firstName, lastName);
                InvalidPhone(phoneNumber);
            }
            catch (InvalidPerson)
            {
                throw new InvalidPerson("Invalid Travel Agent");
            }
        } //End of constructor

        public TravelAgent(string firstName, string lastName, string phoneNumber, string ssn,string street,string city, string state, string zip,int empID)
            :base(firstName,lastName,new Address(street,city,state,zip), phoneNumber) //Constructor
        {
            this.Ssn = ssn;
            this.EmployeeID = empID;
            try
            {
                InvalidName(firstName, lastName);
                InvalidPhone(phoneNumber);
            }
            catch (InvalidPerson)
            {
                throw new InvalidPerson("Invalid Travel Agent");
            }

        } //End Of Constructor

        public double BookTicket(double price) //Method BookTicket
        {
            double sum = commisionRate * price;
            Earnings = sum + Earnings;
            return Earnings;
        } //End Of Method
        public override string FileString()
        {
            return string.Format("Travel Agent,{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10}", FirstName, LastName, Gender, Address.Street,Address.City,Address.State,Address.Zipcode, PhoneNumber, EmployeeID, Earnings, Ssn);
        }
        public override string ToString() //Override ToString
        {
            return base.ToString()+ " ID: "+EmployeeID + " Earnings: "+Earnings;
        } //End Of Override ToString

    } //Class TravelAgent

} //End Of Namespace
