using System;
using System.Collections.Generic;

namespace OktavaProject.DL.Models
{
    public partial class EventUpdateUser
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime Date { get; set; }
        public string? Mail { get; set; }
    }
}
