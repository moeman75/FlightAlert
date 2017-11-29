using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenWeatherAPI.OpenWeatherAPI openWeatherAPI = new OpenWeatherAPI.OpenWeatherAPI("28cab4ebdf5237245ef401e8fa51a7f4");
            OpenWeatherAPI.Query query = openWeatherAPI.query("London");
            Console.WriteLine(string.Format("The temperature in {0}, {1} is currently {2} °F", query.Name, query.Sys.Country, query.Main.Temperature.FahrenheitCurrent));
        }
    }
}
