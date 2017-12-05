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
        OpenWeatherAPI.OpenWeatherAPI openWeatherAPI = new OpenWeatherAPI.OpenWeatherAPI("28cab4ebdf5237245ef401e8fa51a7f4");
        OpenWeatherAPI.Query query;

        protected void Page_Load(object sender, EventArgs e)
        {
            Label2.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try {
                if (citytb.Text != null || citytb.Text != "")
                {
                    query = openWeatherAPI.query(citytb.Text);
                    Label2.Text = string.Format("The temperature in {0}, {1} is currently {2} °F", query.Name, query.Sys.Country, query.Main.Temperature.FahrenheitCurrent);
                }
            }
            catch{
                Label2.Text = "Error Finding City";
            }
        }
    }
}