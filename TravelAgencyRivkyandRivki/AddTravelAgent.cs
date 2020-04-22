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
    public partial class AddTravelAgent : Form
    {
        public AddTravelAgent()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {            
            try //throw this exception if this passenger already exists
            {
                string gender;
                if (FemaleradioButton1.Checked)
                    gender = FemaleradioButton1.Text;
                else
                    gender = MaleradioButton2.Text;

                Address addr = new Address(StreetTextBox.Text, CityTextBox.Text, StateTextBox.Text, ZipTextBox.Text);
                TravelAgent trav1 = new TravelAgent(FirstNameTextBox.Text, LastNameTextBox.Text, gender, addr, PhoneNumberTextBox.Text, int.Parse(IDNumberTextBox.Text), double.Parse(EarningstextBox1.Text), SsnTextBox.Text);
                trav1.countofEmployees++;
                foreach (Person p in TravelAgency.people)
                {
                    if (trav1.isEqual(p))
                        throw new DuplicateDataExcception("Sorry! This Passenger already exists!");
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

                if (SsnTextBox.Text == s)
                    throw new InvalidDataException("Invalid Passport Number");

                if (!FemaleradioButton1.Checked && !MaleradioButton2.Checked)
                    throw new InvalidDataException("Invalid Gender");
                TravelAgency.people.Add(trav1);
                MessageBox.Show("Travel Agent " + FirstNameTextBox.Text + " " + LastNameTextBox.Text + " was added");
                FirstNameTextBox.Clear();
                LastNameTextBox.Clear();
                PhoneNumberTextBox.Clear();
                StreetTextBox.Clear();
                SsnTextBox.Clear();
                CityTextBox.Clear();
                StateTextBox.Clear();
                ZipTextBox.Clear();
                FemaleradioButton1.Checked = false;
                MaleradioButton2.Checked = false;
                IDNumberTextBox.Clear();
                EarningstextBox1.Clear();

            }
            catch (InvalidName)
            {
                MessageBox.Show("Invalid Name");
            }
            catch(InvalidPhoneNumber)
            {
                MessageBox.Show("Invalid phone Number");
            }
            catch (DuplicateDataExcception ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (OverflowException oe)
            {
                MessageBox.Show(oe.Message);
            }
            catch(FormatException f)
            {
                MessageBox.Show(f.Message);
            }
            catch (Exception q)
            {
                MessageBox.Show(q.Message);
            }

        }

    }
}
