using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            // TODO: This line of code loads data into the 'myAirportDataSet.OutgoingPlanes' table. You can move, or remove it, as needed.
            this.outgoingPlanesTableAdapter.Fill(this.myAirportDataSet.OutgoingPlanes);
            // TODO: This line of code loads data into the 'myAirportDataSet.IncomingPlanes' table. You can move, or remove it, as needed.
            this.incomingPlanesTableAdapter.Fill(this.myAirportDataSet.IncomingPlanes);

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
            MyAirportEntities dbcon = new MyAirportEntities();
            DateTime dayoflight = DateTime.Today;
            int index2 = comboBox2.SelectedIndex;
            IncomingPlane plane = new IncomingPlane();
            plane.Arrival_Datetime = dayoflight;
            plane.Arriving_From = "Chicago";
            plane.Delayed = 0;
            plane.Name = "Flight123";
            plane.Plane_ID = 1;
            dbcon.IncomingPlanes.Add(plane);
            dbcon.SaveChanges();

            
            
            /*
            if (name == "")
            {
                warninglabel1.Text = "Name cannot be blank";
                return;
            }
            else if (!allarechar)
            {
                warninglabel1.Text = "No Special Characters allowed";
                return;
            }
            else
                warninglabel1.Text = "";

            

            int index = comboBox1.SelectedIndex;

            if (index == -1)
            {
                warninglabel2.Text = "Must choose if flight is arriving or departing";
                return;
            }
            else
                warninglabel2.Text = "";

            

            if (index2 == -1 && index == 0)
            {
                warninglabel4.Text = "Must choose where flight is arriving from";
            }
            else if (index2 == -1 && index == 1)
            {
                warninglabel4.Text = "Must choose destination";
            }
            

            
            
           
            

            //dbcon.SaveChanges();
            */

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingSource2_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
