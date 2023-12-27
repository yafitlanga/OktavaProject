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
        public int UserId { get; set; }
        public int LessonId { get; set; }
    }
}
