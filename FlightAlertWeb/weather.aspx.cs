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
        int risk = 0;
        AirportEntities dbcon = new AirportEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            Label2.Text = "";
            Label3.Text = "";
            Label4.Text = "";
            Label5.Text = "";
            Label6.Text = "";
            Label7.Text = "Risk: ";
            Label7.BackColor = System.Drawing.Color.White;
            Label7.ForeColor = System.Drawing.Color.Black;
            Label8.Text = "Todays Date and Time: " + DateTime.Now;
            risk = 0;

            foreach (OutGoingPlane plane in dbcon.OutGoingPlanes)
            {
                DateTime flightday = plane.Departure_Date;
                if (flightday.CompareTo(today) < 0)
                {
                    dbcon.OutGoingPlanes.Remove(plane);
                }


            }
            dbcon.SaveChanges();
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int airportID = Convert.ToInt16(DropDownList1.SelectedValue);
            double lat = 0, lon = 0;
            string latlong = "";
            
            var airports =
                from item in dbcon.Airports
                where item.Airport_ID.Equals(airportID)
                select item;
                
            foreach (Airport item in airports)
            {
                lat = item.Latitude;
                lon = item.Longitude;
            }
            latlong = string.Format("lat={0}&lon={1}",lat, lon);

            //lat=35&lon=139
            try
            {
                query = openWeatherAPI.query(latlong);
                Label2.Text = string.Format("City Neighborhood: {0}    Country: {1}", query.Name, query.Sys.Country);
                Label3.Text = string.Format("Tempurature: {0} °F", query.Main.Temperature.FahrenheitCurrent);
                Label4.Text = string.Format("Wind speed (mph): {0}", (query.Wind.SpeedFeetPerSecond * 0.681818));
                Label5.Text = string.Format("Percipitation: {0}%", query.Main.Humdity);
                Label6.Text = string.Format("Cloudiness: {0}%", query.Clouds.All);

                if ((query.Wind.SpeedFeetPerSecond * 0.681818) > 28.7695)
                {
                    risk += 4;

                }
                if ((query.Main.Temperature.FahrenheitCurrent < 32) && (query.Main.Humdity > 50))
                {
                    risk += 4;
                }
                if (((query.Main.Temperature.FahrenheitCurrent > 24) && (query.Main.Temperature.FahrenheitCurrent < 40)) && (query.Main.Humdity > 50))
                {
                    risk += 4;
                }
                if (query.Clouds.All >= 90)
                {
                    risk += 1;
                }
            }
            catch { }//Does squat


            if (risk < 4)
            {
                Label7.ForeColor = System.Drawing.Color.Green;
            }
            else if (risk < 7)
            {
                Label7.ForeColor = System.Drawing.Color.Yellow;
            }
            else
            {
                Label7.ForeColor = System.Drawing.Color.Red;
            }
            Label7.BackColor = System.Drawing.Color.Gray;
            Label7.Text = "Risk: " + risk.ToString() + " ";



        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Button2.Visible = true;
            Button4.Visible = true;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int planeID = (int)GridView1.SelectedValue;
            var planes =
                from item in dbcon.OutGoingPlanes
                where item.Plane_ID.Equals(planeID)
                select item;
            foreach (OutGoingPlane item in planes)
            {
                item.Delayed = 1;
            }
            dbcon.SaveChanges();
            GridView1.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string airport = DropDownList2.SelectedValue;
            var flights =
                from item in dbcon.OutGoingPlanes
                where item.Destination.Equals(airport)
                select item;
            foreach(OutGoingPlane item in flights)
            {
                DateTime flight = item.Departure_Date.Date;
                if(flight.CompareTo(DateTime.Today) == 0)
                {
                    item.Delayed = 1;
                }

            }
            dbcon.SaveChanges();
            GridView1.DataBind();

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int planeID = (int)GridView1.SelectedValue;
            var planes =
                from item in dbcon.OutGoingPlanes
                where item.Plane_ID.Equals(planeID)
                select item;
            foreach (OutGoingPlane item in planes)
            {
                item.Delayed = 0;
            }
            dbcon.SaveChanges();
            GridView1.DataBind();
        }
    }
}