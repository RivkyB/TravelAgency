using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgencyRivkyandRivki
{
    public class Passport
    {
        public int PassportID { get; set; } //If someone gets a new passport the ID may change so it needs a get and a set
        public string FirstName { get; } //no set because it can't change
        public string LastName { get; } //no set because it can't change
        public DateTime BirthDate { get; }
        public string CountryOfBirth { get; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; } //needs a get and set because if passport expires then passenger gets a new passport
        public string Nationality { get; set; } //A persons nationality can change if he immigrates...

        public Passport(string firstName, string lastName, string countryOfBirth, string nationality) //constructor with only strings
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.CountryOfBirth = countryOfBirth;
            this.Nationality = nationality;
            InvalidName(firstName, lastName);
        } //end of constructor

        public Passport(int passportID,  string countryOfBirth, string nationality)//construcor with all instance variables
        {
            PassportID = passportID;
            //FirstName = firstName;
           // LastName = lastName;
            //DateTime b1 = Convert.ToDateTime(birthDate);
            //BirthDate = b1;
            CountryOfBirth = countryOfBirth;
            //DateTime b2 = Convert.ToDateTime(birthDate);
            //IssueDate = b2;
            //DateTime b3 = Convert.ToDateTime(birthDate);
            //ExpirationDate = b3;
            Nationality = nationality;
            InvalidInfo();
        }

        public bool isExpired() //method to check if passport is expired
        {
            if(ExpirationDate < DateTime.Now)
                return false;
            return true;
        } // end of method

        public void InvalidName(string firstname, string lastname)  //Throws exception if invalid name
        {
            try
            {
                if (firstname == null || lastname == null)
                {
                    throw new InvalidName("Invalid Name");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        } //end of exception

        public void InvalidInfo() //If invalid information it throws this exception
        {
            try
            {
                if (PassportID == 0 || BirthDate == null || CountryOfBirth == null || IssueDate == null || ExpirationDate == null || Nationality == null)
                    throw new InvalidDataException("invalid data");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }//end of invalid info exception


        // We were not sure how to do this exception:

        //public void InvalidConversion() //throws this exception if conversion of string to type DateTime was invalid
        //{
        //    try
        //    {
        //        if (BirthDate != DateTime.TryParse())
        //            throw new InvalidDataException("invalid data");
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //}//end of exception
        
        public override string ToString() //Override ToString
        {
            return "Name: " + FirstName + "  " + LastName + "/n Passport Number: " + PassportID;
        } //End Of Override ToString

    } //end of class

} //end of namespace
