using System;
using System.Collections.Generic;

namespace OktavaProject.DL.Models
{
    public partial class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Mail { get; set; } = null!;
        public string? Phone { get; set; }
        public string Detailes { get; set; } = null!;
        public DateTime Date { get; set; }
    }
}
