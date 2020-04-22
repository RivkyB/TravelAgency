using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgencyRivkyandRivki
{
     
    class Customer: Person //Class customer of type Person
    {
        public int CustomerID { get; set; } //Properties of Customer
        public CreditCard CC { get; set; }
        public Address ktovet = new Address("a", "b", "c", "d");

        public Customer(string firstName, string lastName, string gender, Address address, string phoneNumber, int custID, CreditCard cc) 
            : base(firstName, lastName, gender, address, phoneNumber) //Constructor
        {
            CustomerID = custID;
            CC = cc;
           try
            {
                InvalidAddress(address);
                InvalidName(firstName, lastName);
                InvalidPhone(phoneNumber);

            }
            catch (InvalidPerson)
            {
                throw new InvalidPerson("Ivalid Customer");
            }
        } //End of constructor

        public Customer(string firstname, string lastname, string phonenumber, string street, string city, string state, string zip, int custID) 
            :base(firstname, lastname,new Address(street, city, state, zip), phonenumber) //Constructor with strings
        {
            CustomerID = custID;
            try
            {
                InvalidName(firstname, lastname);
                InvalidPhone(phonenumber);
            }
            catch(InvalidPerson)
            {
                throw new InvalidPerson("invalid customer");
            }
        } //end of constructor

        public override string FileString()
        {
            return string.Format("Customer,{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}", FirstName, LastName, Gender, Address.Street, Address.City, Address.State, Address.Zipcode, PhoneNumber, CustomerID, CC.CcID, CC.Pin,CC.expirationDate);
        }
        public void ChargeCard(double amount, DateTime expirationdate) //method to charge the card
        {
            try
            {
                //EnterPin(pin);
                Withdrawl(amount);
                //CC.expirationDate = DateTime.Now.AddYears(2); //this is the expiration date
                CheckDate(expirationdate);
            }
            catch(Exception a)
            {
                throw new Exception(a.Message);
            }
        } //end of method

        public void CheckDate(DateTime dt) //exception thrown if card is expired
        {
            try
            {
                if (dt < DateTime.Now)
                    throw new CardExpiredException("card");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        } //end of exception

        public void Withdrawl(double amount) //exception thrown if amt is more then on card
        {
            try
            {
                if (amount < CC.Balance)
                {
                    CC.Balance -= amount;
                }
                else
                    throw new InsufficientFundsException("Rivky");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        } //end of exception

        public void EnterPin(int pinnum) //exception thrown if invalid pin
        {
            try
            {
                if (pinnum != CC.Pin)
                {
                    throw new InvalidPinException("pin");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        } //end of exception

        public override string ToString() //Override ToString
        {
            return base.ToString()+ " ID: " + CustomerID;
        } //End of ToString

    } //End of class

} //End of Namespace

