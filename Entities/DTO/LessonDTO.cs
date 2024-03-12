using OktavaProject.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OktavaProjectEntities.DTO
{
    public class LessonDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int DayId { get; set; }
        public int HourId { get; set; }
        public int SkillId { get; set; }
        public virtual SkillDTO? Skill { get; set; } = null!;
        public virtual DayDTO? Day { get; set; } = null!;
        public virtual HourDTO? Hour { get; set; } = null!;
        public virtual UserDTO? User { get; set; }
    }
}
