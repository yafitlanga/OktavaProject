﻿using OktavaProject.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OktavaProjectEntities.DTO
{
    public class EventSimpleDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Hour { get; set; } = null!;
        public double? Payment { get; set; }
        public DateTime Day { get; set; }
        public bool Active { get; set; }    
        public int? ResponsibleUserId { get; set; }
        public string? Urlimg { get; set; }        
    }
}
