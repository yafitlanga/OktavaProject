using System;
using System.Collections.Generic;

namespace OktavaProject.DL.Models
{
    public partial class StudentLesson
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int LessonId { get; set; }

        public virtual Lesson Lesson { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
