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
        private ISkillUserDL skillUserDL;
        private IAcademicDegreeUserDL academicDegreeUserDL;
        private IMapper mapper;

        public UserBL(IUserDL userDL,ISkillUserDL skillUserDL, 
            IAcademicDegreeUserDL academicDegreeUserDL, IMapper _mapper)
        {
            this.userDL = userDL;
            this.skillUserDL = skillUserDL;
            this.academicDegreeUserDL = academicDegreeUserDL;
            this.mapper = _mapper;
        }
        public async Task<List<UserDTO>> GetUsers()
        {
            List<User> user1 =await userDL.GetUsers();
            List<UserDTO> user2 = mapper.Map<List<UserDTO>>(user1);
            return user2;
        }
        public async Task<UserDTO> GetUserById(int userId)
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
        public async Task<int> AddUser(UserDTO user)
        {
            User u = mapper.Map<User>(user);
            int userId = await userDL.AddUser(u);
            return userId;
        }
        public async Task<bool> UpdateUser(UserDTO user, int id)
        {
            User u = mapper.Map<User>(user);
            bool isUpdate = await userDL.UpdateUser(u, id);
            return isUpdate;
        }
        //public async Task<bool> UpdateUser(UserDTO user, int id)
        //{
        //    User u = mapper.Map<User>(user);
        //    bool isUpdate = await userDL.UpdateUser(u, id);
        //    return isUpdate;
        //}
        public async Task<bool> RemoveUser(int id)
        {
            //   bool isRemoveSkillUser =  await skillUserDL.RemoveSkillUserByUserId(id);
            //if (isRemoveSkillUser)
            //{
            //    bool isRemoveAcademicUser = await academicDegreeUserDL.RemoveAcademicDegreeUserByUserId(id);
            //    if (isRemoveAcademicUser)
            //    {
                    bool isRemove = await userDL.RemoveUser(id);
                    if (isRemove)
                    {
                        return true;
                    }
            //}
        
            return false;

        }

    }
}





