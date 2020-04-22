using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgencyRivkyandRivki
{
    public abstract class Person //Class Person
    {
        public string FirstName { get; set; } //Properties of class Person
        public string LastName { get; set; }
        public string Gender { get; set; }
        public Address Address { get; set; }
        public string PhoneNumber { get; set; }

        public Person(string firstName, string lastName, string gender, Address address, string phoneNumber) //Constructor
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Address = address;
            PhoneNumber = phoneNumber;
        } //End Of constructor

        public Person(string firstname, string lastname, Address addr, string phonenumber) //Constructor with only strings and Address
        {
            try
            {
                InvalidName(firstname, lastname);
                InvalidAddress(addr);
                InvalidPhone(phonenumber);
            }catch(InvalidPerson)
            {
                
            }
        }  //end of constructor

        public abstract string FileString();

        public bool isEqual(Person other) //To see if 2 ppl are =
        {
            return this.GetType() == other.GetType() && this.FirstName == other.FirstName && this.LastName == other.LastName && this.PhoneNumber == other.PhoneNumber;
            
    
        } //end of method

        public void InvalidAddress(Address addr) //Throw Exception if Invalid Address
        {
            try
            {
                if (addr==null)
                {
                    throw new InvalidAddress("Invalid Address");
                }
                else
                {
                    this.Address = addr;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        } //End of exception

        public void InvalidName(string firstname, string lastname)  //Throws exception if invalid name
        {
            try
            {
                if (firstname == null||lastname==null)
                {
                    throw new InvalidName("Invalid Name");
                }
                else
                {
                    this.FirstName = firstname;
                    this.LastName = lastname;
                }
            }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } //end of exception

        public void InvalidPhone(string phonenumber) //throws exception if invalid number
        {
            try
            {
                if (phonenumber == null)
                {
                    throw new InvalidPhoneNumber("Invalid Number");
                }
                else
                {
                    this.PhoneNumber = phonenumber;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        } //end of exception

        public override string ToString() //Override ToString
        {
            return " " + FirstName + " " + LastName + " (" + Gender + ") "+ Address + "  " + PhoneNumber + " ";
        } //End of ToString

    } //End of class

} //End of namespace
