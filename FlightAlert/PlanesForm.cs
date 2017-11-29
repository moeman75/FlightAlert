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
            // TODO: This line of code loads data into the 'airportDataSet1.Plane' table. You can move, or remove it, as needed.
            this.planeTableAdapter1.Fill(this.airportDataSet1.Plane);
            datetimelabel.Text = "";



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                datetimelabel.Text = "Arrival Time";
                destarrivelabel.Text = "Arriving From";
            }
            else
            {
                datetimelabel.Text = "Departure Time";
                destarrivelabel.Text = "Destination";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
