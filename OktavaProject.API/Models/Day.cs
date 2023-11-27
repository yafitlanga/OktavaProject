using System;
using System.Collections.Generic;

namespace OktavaProject.DL.Models
{
    public partial class Day
    {
        public Day()
        {
            Lessons = new HashSet<Lesson>();
        }

        public int Id { get; set; }
        public string Desc { get; set; } = null!;

        public virtual ICollection<Lesson> Lessons { get; set; }
    }
}
