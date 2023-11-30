using AutoMapper;
using OktavaProject.DL.Models;
using OktavaProjectEntities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OktavaProjectEntities
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<User, UserDTO>();
           
        }
    }
}
