using System;
using System.Collections.Generic;

namespace OktavaProject.DL.Models
{
    public partial class Lesson
    {
        public Lesson()
        {
            StudentLessons = new HashSet<StudentLesson>();
        }

        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? DayId { get; set; }
        public int? HourId { get; set; }
        public int? SkillId { get; set; }

        public virtual Day? Day { get; set; }
        public virtual Hour? Hour { get; set; }
        public virtual Skill? Skill { get; set; }
        public virtual User? User { get; set; }
        public virtual ICollection<StudentLesson> StudentLessons { get; set; }
    }
}
