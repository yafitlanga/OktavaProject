using System;
using System.Collections.Generic;

namespace OktavaProject.DL.Models
{
    public partial class AcademicDegree
    {
        public AcademicDegree()
        {
            AcademicDegreeUsers = new HashSet<AcademicDegreeUser>();
        }

        public int Id { get; set; }
        public string Desc { get; set; } = null!;

        public virtual ICollection<AcademicDegreeUser> AcademicDegreeUsers { get; set; }
    }
}
