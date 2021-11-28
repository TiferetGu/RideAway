using System;
using System.Collections.Generic;

#nullable disable

namespace RideAway.Entities.Models
{
    public partial class Calendar
    {
        public Calendar()
        {
            Trips = new HashSet<Trip>();
        }

        public int ServiceId { get; set; }
        public int Sunday { get; set; }
        public int Monday { get; set; }
        public int Tuesday { get; set; }
        public int Wednesday { get; set; }
        public int Thursday { get; set; }
        public int Friday { get; set; }
        public int Saturday { get; set; }
        public int StartDate { get; set; }
        public int EndDate { get; set; }

        public virtual ICollection<Trip> Trips { get; set; }
    }
}
