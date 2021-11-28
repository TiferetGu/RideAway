using System;
using System.Collections.Generic;

//#nullable disable

namespace RideAway.Models
{
    public partial class Route
    {
        public int RouteId { get; set; }
        public int AgencyId { get; set; }
        public string RouteShortName { get; set; }
        public string RouteLongName { get; set; }
        public string RouteDesc { get; set; }
        public int RouteType { get; set; }
        public string RouteColor { get; set; }
    }
}
