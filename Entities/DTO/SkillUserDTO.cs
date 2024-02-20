using OktavaProject.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OktavaProjectEntities.DTO
{
    public class SkillUserDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int SkillId { get; set; }

        public virtual SkillDTO ?Skill { get; set; } = null!;
        //public virtual StudentDTO User { get; set; } = null!;
    }
}
