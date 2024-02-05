using System;
using System.Collections.Generic;

namespace OktavaProject.DL.Models
{
    public partial class Student
    {
        public Student()
        {
            StudentLessons = new HashSet<StudentLesson>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int Gender { get; set; }
        public string StudentId { get; set; } = null!;
        public DateTime? Birthday { get; set; }
        public string? Mail { get; set; }
        public string Address { get; set; } = null!;
        public string Phone { get; set; } = null!;

        public virtual ICollection<StudentLesson> StudentLessons { get; set; }
    }
}
