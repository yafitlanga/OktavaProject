using System;
using System.Collections.Generic;

namespace OktavaProject.DL.Models
{
    public partial class Hour
    {
        public Hour()
        {
            Lessons = new HashSet<Lesson>();
        }

        public int Id { get; set; }
        public string Desc { get; set; } = null!;
        public int Orders { get; set; }

        public virtual ICollection<Lesson> Lessons { get; set; }
    }
}
