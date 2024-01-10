using OktavaProject.DL.Models;
using OktavaProjectEntities.DTO;

namespace OktavaProject.BL
{
    public interface ISkillUserBL
    {
        Task<List<SkillUserDTO>> GetSkillUsers();
        Task<bool> AddSkillUser(SkillUserDTO skillUser);
        Task<bool> UpdateSkillUser(SkillUserDTO skillUser, int id);
        Task<bool> RemoveSkillUser(int id);
        Task<SkillUserDTO> GetSkillUserById(int id);
    }
}