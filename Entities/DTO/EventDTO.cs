using OktavaProject.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OktavaProjectEntities.DTO
{
    public class EventDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Hour { get; set; } = null!;
        public double? Payment { get; set; }
        public DateTime Date { get; set; }
        public int ResponsibleUserId { get; set; }

        public virtual User ResponsibleUser { get; set; } = null!;
    }
}
