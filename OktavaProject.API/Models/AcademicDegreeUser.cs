using System;
using System.Collections.Generic;

namespace OktavaProject.DL.Models
{
    public partial class AcademicDegreeUser
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int AcademicDegreeId { get; set; }

        public virtual AcademicDegree AcademicDegree { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
