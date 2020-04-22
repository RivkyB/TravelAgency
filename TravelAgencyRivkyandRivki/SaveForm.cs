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
    public partial class SaveForm : Form
    {
        public SaveForm()
        {
            InitializeComponent();
        }

        private void Savebutton1_Click(object sender, EventArgs e)
        {
            string fileName = txtFileName.Text;
            StreamWriter writer = new StreamWriter(fileName);

            try
            {
                using (writer)
                {
                    foreach (Person person1 in TravelAgency.people)
                    {  
                        writer.WriteLine(person1.FileString());
                    }
                }
                MessageBox.Show("your file was saved");
                this.Close();
            }
            catch(FileNotFoundException)
            {
                MessageBox.Show("your file could not be found", "File Not Found");
            }
            catch(Exception q)
            {
                MessageBox.Show("your file is not available");
                MessageBox.Show(q.Message);
            }
           
        }
    }
}
