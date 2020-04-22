using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TravelAgencyRivkyandRivki
{
    public partial class LoadForm : Form
    {
        public LoadForm()
        {
            InitializeComponent();
        }

        private void Loadbutton1_Click(object sender, EventArgs e)
        {
            string[] words;
            string fileName = txtFileName2.Text;

            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        words = line.Split(',');


                        string type = words[0];

                        Person person = null;
                        switch (words[0])
                        {
                            case "Customer":
                                Address a = new Address(words[4], words[5], words[6], words[7]);
                                CreditCard c = new CreditCard(int.Parse(words[10]), int.Parse(words[11]), DateTime.Parse(words[12]));

                                person = new Customer(words[1], words[2], words[3], a, words[8], int.Parse(words[9]), c);
                                break;

                            case "Passenger":
                                Passport pass = new Passport(int.Parse(words[6]), words[7], words[8]);
                                Address addr = new Address(words[9], words[10], words[11], words[12]);
                                person = new Passenger(int.Parse(words[1]), words[2], words[3], words[4], words[5], addr, pass);
                                break;

                            case "Travel Agent":
                                Address b = new Address(words[4], words[5], words[6], words[7]);
                                person = new TravelAgent(words[1], words[2], words[3], b, words[8], int.Parse(words[9]), double.Parse(words[10]), words[11]);
                                break;
                        }
                        TravelAgency.people.Add(person);
                        
                    }
                    
                }
                MessageBox.Show("your file has been loaded");
                this.Close();
            }
            catch (Exception w)
            {
                MessageBox.Show("your file could not be read");
                MessageBox.Show(w.Message);
            }
        }
    }
}


