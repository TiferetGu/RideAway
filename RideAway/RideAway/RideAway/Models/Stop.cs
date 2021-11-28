using System;
using System.Collections.Generic;

#nullable disable

namespace RideAway.Models
{
    public partial class Stop
    {
        public int StopId { get; set; }
        public int StopCode { get; set; }
        public string StopName { get; set; }
        public string StopDesc { get; set; }
        public double StopLat { get; set; }
        public double StopLon { get; set; }
        public int LocationType { get; set; }
        public string ParentStation { get; set; }
        public int ZoneId { get; set; }
    }
}
