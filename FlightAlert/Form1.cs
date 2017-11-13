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
    public partial class Form1 : Form
    {
        weather form = new weather();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //weatherCheckButton
        private void button1_Click(object sender, EventArgs e)
        {
            weather form = new weather();
            form.Show();
        }
    }
}
