using OktavaProject.DL.Models;
using OktavaProjectEntities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OktavaProjectEntities.DTO
{
    public class StudentLessonDTO
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int LessonId { get; set; }
        public LessonDTO? Lesson { get; set; } = null!;
        public Student? Student { get; set; } = null;
    }
}