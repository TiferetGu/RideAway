using System;
using System.Collections.Generic;

#nullable disable

namespace RideAway.Models
{
    public partial class Agency
    {
        public int AgencyId { get; set; }
        public string AgencyName { get; set; }
        public string AgencyUrl { get; set; }
        public string AgencyTimezone { get; set; }
        public string AgencyLang { get; set; }
        public string AgencyPhone { get; set; }
        public string AgencyFareUrl { get; set; }
    }
}
