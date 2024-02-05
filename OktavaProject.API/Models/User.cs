using System;
using System.Collections.Generic;

namespace OktavaProject.DL.Models
{
    public partial class User
    {
        public User()
        {
            AcademicDegreeUsers = new HashSet<AcademicDegreeUser>();
            Events = new HashSet<Event>();
            Lessons = new HashSet<Lesson>();
            SkillUsers = new HashSet<SkillUser>();
        }

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

        public virtual ICollection<AcademicDegreeUser> AcademicDegreeUsers { get; set; }
        public virtual ICollection<Event> Events { get; set; }
        public virtual ICollection<Lesson> Lessons { get; set; }
        public virtual ICollection<SkillUser> SkillUsers { get; set; }
    }
}
