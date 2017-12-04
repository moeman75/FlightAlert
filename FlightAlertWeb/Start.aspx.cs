using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FlightAlertWeb
{
    public partial class Start : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Airport currentairport = new Airport();
            currentairport.Name = "Portland International Airport";
            currentairport.Latitude = 45.589769;
            currentairport.Longitude = -122.595094;
        }

        
    }
}