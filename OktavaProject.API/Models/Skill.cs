using System;
using System.Collections.Generic;

namespace OktavaProject.DL.Models
{
    public partial class Skill
    {
        public Skill()
        {
            Lessons = new HashSet<Lesson>();
            SkillUsers = new HashSet<SkillUser>();
        }

        public int Id { get; set; }
        public string Desc { get; set; } = null!;

        public virtual ICollection<Lesson> Lessons { get; set; }
        public virtual ICollection<SkillUser> SkillUsers { get; set; }
    }
}
