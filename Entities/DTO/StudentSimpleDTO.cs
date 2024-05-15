using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OktavaProjectEntities.DTO
{
    public class StudentSimpleDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int Gender { get; set; }
        public string StudentId { get; set; } = null!;
        public DateTime? Birthday { get; set; }
        public string? Mail { get; set; }
        public string Address { get; set; } = null!;
        public string Phone { get; set; } = null!;

    }
}
