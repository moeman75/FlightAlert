using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightAlert
{
    public partial class weather : Form
    {
        public weather()
        {
            InitializeComponent();
        }

        private void weather_Load(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Continue_Click(object sender, EventArgs e)
        {
            var response = "Result Goes Here";
            ResultTextField.Text = response;
        }
    }
}
