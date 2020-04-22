using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgencyRivkyandRivki
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                string gender;
                if (FemaleradioButton1.Checked)
                    gender = FemaleradioButton1.Text;
                else
                    gender = MaleradioButton2.Text;
                Address addr = new Address(StreetTextBox.Text, CityTextBox.Text, StateTextBox.Text, ZipTextBox.Text);
                CreditCard cc = new CreditCard(int.Parse(CardNumbertextBox1.Text), int.Parse(PintextBox1.Text), DateTime.Parse(ExpirationDatedateTimePicker1.Text));
                Customer cust1 = new Customer(FirstNameTextBox.Text, LastNameTextBox.Text,gender,addr,PhoneNumberTextBox.Text,  int.Parse(IDNumberTextBox.Text),cc);
                
                foreach (Person p in TravelAgency.people)
                {
                    if (cust1.isEqual(p))
                        throw new DuplicateDataExcception("Sorry! This Customer already exists!");
                }
                string s = " ";
                if (FirstNameTextBox.Text == s || LastNameTextBox.Text == s)
                    throw new InvalidName("Invalid Name");

                if (PhoneNumberTextBox.Text == s)
                    throw new InvalidPhoneNumber("Invalid PhoneNumber");

                if (StreetTextBox.Text == s || CityTextBox.Text == s || StateTextBox.Text == s || ZipTextBox.Text == s)
                    throw new InvalidAddress("Invalid Address");

                if (IDNumberTextBox.Text == s)
                    throw new InvalidDataException("Invalid ID");

                if (CardNumbertextBox1.Text == s || PintextBox1.Text == s)
                    throw new InvalidDataException("invalid card");

                if (!FemaleradioButton1.Checked && !MaleradioButton2.Checked)
                    throw new InvalidDataException("Invalid Gender");

                TravelAgency.people.Add(cust1);
                MessageBox.Show("Customer "+FirstNameTextBox.Text+" "+LastNameTextBox.Text+" was added");
                FirstNameTextBox.Clear();
                LastNameTextBox.Clear();
                PhoneNumberTextBox.Clear();
                StreetTextBox.Clear();
                CityTextBox.Clear();
                StateTextBox.Clear();
                ZipTextBox.Clear();
                IDNumberTextBox.Clear();
                FemaleradioButton1.Checked = false;
                MaleradioButton2.Checked = false;
                PintextBox1.Clear();
                ExpirationDatedateTimePicker1.ResetText();
                CardNumbertextBox1.Clear();
            }
            catch (InvalidName)
            {
                MessageBox.Show("Invalid Name");
            }
            catch (InvalidPhoneNumber)
            {
                MessageBox.Show("Invalid phone Number");
            }
            catch (DuplicateDataExcception ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(OverflowException oe)
            {
                MessageBox.Show(oe.Message);
            }
            catch (Exception q)
            {
                MessageBox.Show(q.Message);
            }
        }
    }
}
