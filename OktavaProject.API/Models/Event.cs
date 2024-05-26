using System;
using System.Collections.Generic;

namespace OktavaProject.DL.Models
{
    public partial class Event
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Hour { get; set; } = null!;
        public double? Payment { get; set; }
        public DateTime Date { get; set; }
        public int? ResponsibleUserId { get; set; }
        public string? Urlimg { get; set; }
        public bool Active { get; set; }

        public virtual User? ResponsibleUser { get; set; }
    }
}
