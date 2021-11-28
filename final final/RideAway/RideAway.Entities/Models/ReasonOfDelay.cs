using System;
using System.Collections.Generic;

#nullable disable

namespace RideAway.Entities.Models
{
    public partial class ReasonOfDelay
    {
        public int ReasonId { get; set; }
        public string ReasonDescription { get; set; }
        public bool? IsResetWaitingTime { get; set; }
    }
}
