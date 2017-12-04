using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FlightAlertWeb
{
    
    public partial class Addplane : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            warningLabel1.Text = "";
            warningLabel2.Text = "";
            warningLabel3.Text = "";
            warningLabel4.Text = "";
            warningLabel5.Text = "";
            ArriveDepartLabel.Text = "Destination/Arriving from";
            DateLabel.Text = "Date of flight";
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            DateTime selected = Calendar1.SelectedDate;

            if (selected.CompareTo(today) < 0)
            {
                warningLabel5.Text = "Cannot pick a day in the past";
            }
            else
                warningLabel5.Text = "";

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            AirportEntities dbcon = new AirportEntities();
            int delayed = DropDownList1.SelectedIndex;
            string name = TextBox1.Text;
            int arrivedepart = DropDownList2.SelectedIndex;
            string airport = DropDownList3.SelectedValue;
            DateTime date = Calendar1.SelectedDate;
            DateTime today = DateTime.Today;
            bool allchars = name.All(Char.IsLetterOrDigit);
            int hour = Convert.ToInt16(HourDropDownList.SelectedValue);
            int min = Convert.ToInt16(MinDropDownList.SelectedValue);
            int AMPM = AMPMDropDownList.SelectedIndex;
            if (AMPM == 1)
                hour = hour + 12;
            TimeSpan time = new TimeSpan(hour, min, 0);
            
            //Name validation
            if (name == "")
            {
                warningLabel1.Text = "Must have a flight name";
                return;
            }
            else if(!allchars)
            {
                warningLabel1.Text = "No special characters or spaces allowed";
                return;
            }
            else
                warningLabel1.Text = "";

            //Validating date time
            if (date.CompareTo(today) < 0)
            {
                warningLabel5.Text = "Cannot pick a day in the past";
                return;
            }
            else
                warningLabel5.Text = "";
            date = date.Date + time;
            warningLabel5.Text = date.ToString();

            if (arrivedepart == 0)
            {
                IncomingPlane plane = new IncomingPlane();
                plane.Arrival_Date = date;
                plane.Arriving_From = airport;
                plane.Delayed = delayed;
                plane.Name = name;
                dbcon.IncomingPlanes.Add(plane);
            }
            else
            {
                OutGoingPlane plane = new OutGoingPlane();
                plane.Departure_Date = date;
                plane.Destination = airport;
                plane.Delayed = delayed;
                plane.Name = name;
                dbcon.OutGoingPlanes.Add(plane);
            }

            dbcon.SaveChanges();
            IncomingGridView.DataBind();
            OutgoingGridView.DataBind();
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int arrivedepart = Convert.ToInt16(DropDownList2.SelectedValue);

            if (arrivedepart == 0)
            {
                ArriveDepartLabel.Text = "Arriving from";
                DateLabel.Text = "Arrival date";
                TimeLabel.Text = "Time of arrival:";
            }
            else
            {
                ArriveDepartLabel.Text = "Destination";
                DateLabel.Text = "Departure date";
                TimeLabel.Text = "Time of departure";
            }

        }

        protected void HourDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}