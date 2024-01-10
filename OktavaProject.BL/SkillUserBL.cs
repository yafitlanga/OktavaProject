using AutoMapper;
using OktavaProject.DL.Models;
using OktavaProject.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OktavaProjectEntities.DTO;

namespace OktavaProject.BL
{
    public class SkillUserBL:ISkillUserBL
    {
        private ISkillUserDL skillUserDL;
        private IMapper mapper;

        public SkillUserBL(ISkillUserDL skillUserDL, IMapper _mapper)
        {
            this.skillUserDL = skillUserDL;
            this.mapper = _mapper;
        }
        public async Task<List<SkillUserDTO>> GetSkillUsers()
        {
            List<SkillUser> skillUser1 = await skillUserDL.GetSkillUsers();
            List<SkillUserDTO> skillUser2 = mapper.Map<List<SkillUserDTO>>(skillUser1);
            return skillUser2;
        }
        public async Task<SkillUserDTO> GetSkillUserById(int id)
        {
            SkillUser skillUser1 = await skillUserDL.GetSkillUserById(id);
            SkillUserDTO skillUser2 = mapper.Map<SkillUserDTO>(skillUser1);
            return skillUser2;
        }
        public async Task<bool> AddSkillUser(SkillUserDTO skillUser)
        {
            SkillUser s = mapper.Map<SkillUser>(skillUser);
            bool isAdd = await skillUserDL.AddSkillUser(s);
            return isAdd;
        }
        public async Task<bool> UpdateSkillUser(SkillUserDTO skillUser, int id)
        {
            SkillUser s = mapper.Map<SkillUser>(skillUser);
            bool isUpdate = await skillUserDL.UpdateSkillUser(s, id);
            return isUpdate;
        }
        public async Task<bool> RemoveSkillUser(int id)
        {
            bool isRemove = await skillUserDL.RemoveSkillUser(id);
            return isRemove;
        }
    }
}
