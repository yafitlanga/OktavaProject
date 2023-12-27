using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OktavaProjectEntities.DTO
{
    public class HourDTO
    {
        public int Id { get; set; }
        public string Desc { get; set; } = null!;
        public int Orders { get; set; }
    }
}
