using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgencyRivkyandRivki
{
    class CreditCard //Class Credit card
    {
        public double Balance { get; set; } //Properties of class CreditCard
        public int CcID { get; set; }
        public double CreditLimit { get; set; }
        public int Pin { get; set; }
        public DateTime expirationDate;

        public CreditCard(int ccID, int pin,DateTime expirationdate) //Constructor
        {
            Balance = 30000;
            CcID = ccID;
            CreditLimit = 5000;
            this.expirationDate = expirationdate;
            //expirationdate = DateTime.Now.AddYears(2);
            this.Pin = pin;
        } //End of constructor

        //public CreditCard()
        public void Withdrawl(double amount) //throws this exception if there are not enough funds on the card
        {
            try
            {
                if (amount < Balance)
                {
                    Balance -= amount;
                }
                else
                    throw new InsufficientFundsException("Rivky");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        } //end of exception

        public void EnterPin(int pinnum) //throws this exception if the incorrect pin was entered
        {
            try
            {
                if(pinnum!=Pin)
                {
                    throw new InvalidPinException("pin");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        } //end of exception

        public void CheckDate(DateTime dt) //throws this exception if card is expired
        { 
            try
            {
                if (DateTime.Now > dt)
                    throw new CardExpiredException("Your Card has Expired");
            } 
  
            catch (Exception e)  
            {
                Console.WriteLine(e.Message); 
            } 
        } //end of exception

        //We are not sure how to change this, will ask you in class
        public void AddCharge(double charge, int pinnumber, DateTime dt) //method to charge the credit card
        {
            //cardexpired
            CheckDate(dt);          
           //insufficientfunds
            Withdrawl(charge);
            //invalidpin
            EnterPin(pinnumber);
        } //end of method

        public override string ToString() //Override ToString
        {
            return "balance "+Balance+" , expiration: "+expirationDate;
        } //End Of override ToString

    } //End of class CreditCard
    
}//End Of Namespace
