using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgencyRivkyandRivki
{
    public class Passenger:Person
    {
        public Passport Passport { get; set; } //passport of a passenger has get & set because it can be changed and a person can have more then 1 passport
        public Address Address { get; set; }
        public int Id { get; set; }

        public Passenger(int id,string firstName, string lastName,string gender, string phoneNumber,Address addr,Passport pass)
            :base(firstName,lastName,gender, addr, phoneNumber ) //constructor that gets strings and passport
        {
            this.Id = id;
            this.Address = addr;
            Passport = pass;
            try
            {
                InvalidName(firstName, lastName);
                InvalidPhone(phoneNumber);
            }
            catch(InvalidPerson)
            {
                throw new InvalidPerson("Invalid Passenger");
            }
        } //end of constructor

        public Passenger(string firstName, string lastName, string phoneNumber, Passport pass, Address add)
            : base(firstName, lastName, add, phoneNumber) //constructor that gets strings, passport & address
        {
            Passport = pass;
            try
            {
                InvalidName(firstName, lastName);
                InvalidPhone(phoneNumber);
            }
            catch (InvalidPerson)
            {
                throw new InvalidPerson("Invalid Passenger");
            }
        } //end of constructor

        public bool hasPassport() //Method to see if passport is valid
        {
            if (Passport.ExpirationDate < DateTime.Now)
                return false;
            if (Passport == null)
                return false;
            else
                return true;
        } //end of method

        public override string ToString() //Override ToString
        {
            return base.ToString() + " ID: " + Id;
        } //End Of Override ToString

        public override string FileString()
        {
            return string.Format("Passenger,{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}", Id, FirstName, LastName,Gender, PhoneNumber,Passport.PassportID, Passport.CountryOfBirth, Passport.Nationality, base.Address.Street, base.Address.City, base.Address.State, base.Address.Zipcode);
        }
    } //end of class

} //end of namespace
