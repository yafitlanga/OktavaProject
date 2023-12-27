using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OktavaProjectEntities.DTO
{
    public class ContactDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Mail { get; set; } = null!;
        public string? Phone { get; set; }
        public string Detailes { get; set; } = null!;
        public DateTime Date { get; set; }
    }
}
