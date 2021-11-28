using System;
using System.Collections.Generic;

#nullable disable

namespace RideAway.Models
{
    public partial class Passenger
    {
        public int Id { get; set; }
        public int? IdentityNumber { get; set; }
        public string RavKavId { get; set; }
        public DateTime ValidationDate { get; set; }
        public int? ReasonOfDelayId { get; set; }
        public int SourceStationId { get; set; }
        public int? DestinationStationId { get; set; }
        public int? DestinationRouteId { get; set; }
    }
}
