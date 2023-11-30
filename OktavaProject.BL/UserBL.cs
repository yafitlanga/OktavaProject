using AutoMapper;
using OktavaProject.DL;
using OktavaProject.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OktavaProject.BL
{
    public class UserBL : IUserBL
    {
        private IUserDL userDL;
        private IMapper mapper;

        public UserBL(IUserDL userDL, IMapper _mapper)
        {
            this.userDL = userDL; 
            this.mapper = _mapper;  
        }
        public List<User> GetUsers()
        {
            return userDL.GetUsers();
        }
    }
}




    
