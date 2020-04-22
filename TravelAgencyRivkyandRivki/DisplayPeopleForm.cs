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
    public partial class DisplayPeopleForm : Form
    {
        public DisplayPeopleForm()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            PassengerListBox.Items.Clear();
            int idnum = int.Parse(EnterIDNumberTextBox.Text);

            try
            {
                foreach (Person p in TravelAgency.people)
                {
                    if (TravelAgency.whoToSearch && p is Customer)
                    {
                        Customer c = p as Customer;

                        if (idnum == c.CustomerID)
                        {
                            PassengerListBox.Visible = true;
                            PassengerListBox.Items.Add("Customer "+p);
                        }
                    }
                    else if (!TravelAgency.whoToSearch && p is Passenger)
                    {
                        Passenger c = p as Passenger;

                        if (idnum == c.Id)
                        {
                            PassengerListBox.Visible = true;
                            PassengerListBox.Items.Add("Passenger "+p);
                        }
                    }

                }

                if (PassengerListBox.Items.Count == 0)
                {
                    throw new NotFoundException("There is no such person!");
                }
            }

            catch (NotFoundException na)
            {
                MessageBox.Show(na.Message);
            }
        }

        private void Displayallbutton1_Click(object sender, EventArgs e)
        {
            foreach (Person p in TravelAgency.people)
            {
                Passenger pass = p as Passenger;
                if (p is Passenger)
                {    
                    PassengerListBox.Items.Add(p);
                }
            }
        }
    }
}
