using Microsoft.EntityFrameworkCore;
using OktavaProject.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OktavaProject.DL
{
    public class SkillUserDL:ISkillUserDL
    {
        OktavaDBContext _OktavaContext = new OktavaDBContext();
        public async Task<List<SkillUser>> GetSkillUsers()
        {
            try
            {
                var skillUsers = await _OktavaContext.SkillUsers.ToListAsync();
                return skillUsers;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<bool> AddSkillUser(SkillUser skillUser)
        {
            try
            {
                await _OktavaContext.SkillUsers.AddAsync(skillUser);
                _OktavaContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<bool> UpdateSkillUser(SkillUser skillUser, int id)
        {
            try
            {
                SkillUser skillUserToUpdate = await _OktavaContext.SkillUsers.FirstOrDefaultAsync(x => x.Id == id);
                if (skillUserToUpdate != null)
                {
                    skillUserToUpdate.UserId = skillUser.UserId;
                    skillUserToUpdate.SkillId = skillUser.SkillId;
                }
                else
                {
                    return false;
                }
                _OktavaContext.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<bool> RemoveSkillUser(int id)
        {
            try
            {
                SkillUser skillUserToRemove = await _OktavaContext.SkillUsers.FirstOrDefaultAsync(x => x.Id == id);
                if (skillUserToRemove != null)
                {
                    _OktavaContext.SkillUsers.Remove(skillUserToRemove);
                    _OktavaContext.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
