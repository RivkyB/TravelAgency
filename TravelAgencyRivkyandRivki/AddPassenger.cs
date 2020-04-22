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
    public partial class AddPassenger : Form
    {
        public AddPassenger()
        {
            InitializeComponent();
        }

        public void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                string gender;
                if (FemaleradioButton1.Checked)
                    gender = FemaleradioButton1.Text;
                else
                    gender = MaleradioButton2.Text;
                Passport pass = new Passport(FirstNameTextBox.Text, LastNameTextBox.Text, CountryOfBirthTextBox.Text, NationalityTextBoox.Text);
                Address adr = new Address(StreetTextBox.Text, CityTextBox.Text, StateTextBox.Text, ZipTextBox.Text);
                Person adam1 = new Passenger(int.Parse(IDNumberTextBox.Text), FirstNameTextBox.Text, LastNameTextBox.Text,gender, PhoneNumberTextBox.Text,adr, pass);
                foreach (Person p in TravelAgency.people)
                {
                    if (adam1.isEqual(p))
                        throw new DuplicateDataExcception("Sorry! This Passenger already exists");
                }

                string s = " ";

                if (FirstNameTextBox.Text == s || LastNameTextBox.Text == s)
                    throw new InvalidName("Invalid Name");

                if (PhoneNumberTextBox.Text == s)
                    throw new InvalidPhoneNumber("Invalid PhoneNumber");

                if (StreetTextBox.Text == s || CityTextBox.Text == s || StateTextBox.Text == s || ZipTextBox.Text == s)
                    throw new InvalidAddress("Invalid Address");

                if (CountryOfBirthTextBox.Text == s)
                    throw new InvalidDataException("Invalid Country of Birth");

                if (NationalityTextBoox.Text == s)
                    throw new InvalidDataException("Invalid Nationality");

                if (IDNumberTextBox.Text == s)
                    throw new InvalidDataException("Invalid ID");

                if (PassportNumberTextBox.Text == s)
                    throw new InvalidDataException("Invalid Passport Number");

                if (!FemaleradioButton1.Checked && !MaleradioButton2.Checked)
                    throw new InvalidDataException("Invalid Gender");
                
                TravelAgency.people.Add(adam1);
                MessageBox.Show("Passenger " + FirstNameTextBox.Text + " " + LastNameTextBox.Text + " was added");
                IDNumberTextBox.Clear();
                FirstNameTextBox.Clear();
                LastNameTextBox.Clear();
                PhoneNumberTextBox.Clear();
                StreetTextBox.Clear();
                CityTextBox.Clear();
                StateTextBox.Clear();
                ZipTextBox.Clear();
                CountryOfBirthTextBox.Clear();
                NationalityTextBoox.Clear();
                FemaleradioButton1.Checked = false;
                MaleradioButton2.Checked = false;
                PassportTextBox.Clear();
            }
            catch(InvalidName)
            {
                MessageBox.Show("Invalid Name");
            }
            catch(InvalidPhoneNumber)
            {
                MessageBox.Show("invalid Phone Number");
            }
            catch(DuplicateDataExcception ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (OverflowException oe)
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
