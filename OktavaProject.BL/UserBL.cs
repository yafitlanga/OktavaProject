using AutoMapper;
using OktavaProject.DL;
using OktavaProject.DL.Models;
using OktavaProjectEntities;
using OktavaProjectEntities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
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
        public async Task<List<UserDTO>> GetUsers()
        {
            List<User> user1 =await userDL.GetUsers();
            List<UserDTO> user2 = mapper.Map<List<UserDTO>>(user1);
            return user2;
        }
        public async Task<UserDTO> GetUserById(string userId)
        {
            User user1 = await userDL.GetUserById(userId);
            if (user1 == null) { return null; }
            UserDTO user2 = mapper.Map<UserDTO>(user1);
            return user2;
        }
        public async Task<UserDTO> Login(string userId, string password)
        {
            var user = await userDL.Login(userId, password);
            return mapper.Map<UserDTO>(user);
        }
        public async Task<bool> AddUser(UserDTO user)
        {
            User u = mapper.Map<User>(user);
            bool isAdd = await userDL.AddUser(u);
            return isAdd;
        }
        public async Task<bool> UpdateUser(UserDTO user, int id)
        {
            User u = mapper.Map<User>(user);
            bool isUpdate = await userDL.UpdateUser(u, id);
            return isUpdate;
        }
        public async Task<bool> RemoveUser(int id)
        {
            bool isRemove = await userDL.RemoveUser(id);
            return isRemove;
        }
       
    }
}





