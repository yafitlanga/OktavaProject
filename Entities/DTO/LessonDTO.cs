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

    }
}
