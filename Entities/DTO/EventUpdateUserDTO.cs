using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OktavaProjectEntities.DTO
{
    public class EventUpdateUserDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime Date { get; set; }
        public string? Mail { get; set; }
    }
}
