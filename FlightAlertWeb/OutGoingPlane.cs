//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FlightAlertWeb
{
    using System;
    using System.Collections.Generic;
    
    public partial class OutGoingPlane
    {
        public int Plane_ID { get; set; }
        public string Name { get; set; }
        public int Delayed { get; set; }
        public System.DateTime Departure_Date { get; set; }
        public string Destination { get; set; }
    }
}