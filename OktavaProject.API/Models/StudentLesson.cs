using System;
using System.Collections.Generic;

namespace OktavaProject.DL.Models
{
    public partial class StudentLesson
    {
        public int Id { get; set; }
        public int LessonId { get; set; }
        public int? StudentId { get; set; }

        public virtual Lesson? Lesson { get; set; } = null!;
        public virtual Student? Student { get; set; } = null;
    }
}
