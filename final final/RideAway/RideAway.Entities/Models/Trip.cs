using System;
using System.Collections.Generic;

#nullable disable

namespace RideAway.Entities.Models
{
    public partial class Trip
    {
        public int RouteId { get; set; }
        public int ServiceId { get; set; }
        public string TripId { get; set; }
        public string TripHeadsign { get; set; }
        public int DirectionId { get; set; }
        public int? ShapeId { get; set; }

        public virtual Route Route { get; set; }
        public virtual Calendar Service { get; set; }
    }
}
