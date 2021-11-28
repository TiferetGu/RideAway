using System;
using System.Collections.Generic;

#nullable disable

namespace RideAway.Entities.Models
{
    public partial class Comment
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime? FromTime { get; set; }
        public DateTime? ToTime { get; set; }
        public bool IsActive { get; set; }
        public int? FromStopId { get; set; }
        public int? ToStopId { get; set; }
    }
}
