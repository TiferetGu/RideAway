using System;
using System.Collections.Generic;

#nullable disable

namespace RideAway.Entities.Models
{
    public partial class StationByLine
    {
        public string TripId { get; set; }
        public int RouteId { get; set; }
        public string RouteDesc { get; set; }
        public string Line { get; set; }
        public int StopId { get; set; }
        public string StopDesc { get; set; }
        public string ArrivalTime { get; set; }
        public int StopSequence { get; set; }
    }
}
