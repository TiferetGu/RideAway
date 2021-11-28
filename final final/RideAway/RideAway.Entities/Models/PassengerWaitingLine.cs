using System;
using System.Collections.Generic;

#nullable disable

namespace RideAway.Entities.Models
{
    public partial class PassengerWaitingLine
    {
        public int PassengerId { get; set; }
        public int RouteId { get; set; }
    }
}
