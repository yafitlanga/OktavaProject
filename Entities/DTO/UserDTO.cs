using OktavaProject.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OktavaProjectEntities.DTO
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string PhoneOne { get; set; } = null!;
        public string? PhoneTwo { get; set; }
        public string UsersId { get; set; } = null!;
        public string Mail { get; set; } = null!;
        public int Gender { get; set; }
        public DateTime Birthday { get; set; }
        public string Address { get; set; } = null!;
        public int Level { get; set; }
        public string Password { get; set; } = null!;
        public virtual ICollection<SkillUserDTO> SkillUsers { get; set; }
    }
}
