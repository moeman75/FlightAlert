using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightAlert
{
    public partial class PlanesForm : Form
    {
        public PlanesForm()
        {
            InitializeComponent();
        }

        private void PlanesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airportDataSet.MajorAirports' table. You can move, or remove it, as needed.
            this.majorAirportsTableAdapter.Fill(this.airportDataSet.MajorAirports);
            datetimelabel.Text = "";
            warninglabelmaster.Text = "";
            warninglabel1.Text = "";
            warninglabel2.Text = "";
            warninglabel3.Text = "";
            warninglabel4.Text = "";
            warninglabel5.Text = "";


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            warninglabel2.Text = "";

            if (comboBox1.SelectedIndex == 0)
            {
                datetimelabel.Text = "Arrival Time";
                destarrivelabel.Text = "Arriving From";
                Timelebel.Text = "Estimated Time of Arrival";
                
            }
            else
            {
                datetimelabel.Text = "Departure Time";
                destarrivelabel.Text = "Destination";
                Timelebel.Text = "Estimated Time of Departure";
            }
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) //Time combobox
        {
            warninglabel5.Text = "";
        }
        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)//destination arrival combobox
        {
            warninglabel4.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            bool allarechar = name.All(Char.IsLetterOrDigit);
            AirportEntities1 dbcon = new AirportEntities1();
            Plane newentry = new Plane();

            if (name == "")
            {
                warninglabel1.Text = "Name cannot be blank";
            }
            else if (!allarechar)
            { 
                warninglabel1.Text = "No Special Characters allowed";
            }
            else
            {
                newentry.Name = name;

                int index = comboBox1.SelectedIndex;
                
                if(index == -1)
                {
                    warninglabel2.Text = "Must choose if flight is arriving or departing";
                }
                else
                {
                    DateTime dayoflight = dateTimePicker1.Value;
                    int index2 = comboBox2.SelectedIndex;

                    if (index2 == -1 && index == 0)
                    {
                        warninglabel4.Text = "Must choose where flight is arriving from";
                    }
                    else if (index2 == -1 && index == 1)
                    {
                        warninglabel4.Text = "Must choose destination";
                    }
                    else
                    {

                    }
                }

            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            bool allarechar = name.All(Char.IsLetterOrDigit);

            if (!allarechar)
                warninglabel1.Text = "No Special Characters allowed";
            else
                warninglabel1.Text = "";
            
        }

        
    }
}
