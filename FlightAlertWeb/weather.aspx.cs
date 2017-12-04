using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FlightAlertWeb
{
    public partial class weather : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            OpenWeatherAPI.OpenWeatherAPI openWeatherAPI = new OpenWeatherAPI.OpenWeatherAPI("28cab4ebdf5237245ef401e8fa51a7f4");
            OpenWeatherAPI.Query query = openWeatherAPI.query("Chicago");
            Label2.Text = string.Format("The temperature in {0}, {1} is currently {2} °F", query.Name, query.Sys.Country, query.Main.Temperature.FahrenheitCurrent);
        }
    }
}