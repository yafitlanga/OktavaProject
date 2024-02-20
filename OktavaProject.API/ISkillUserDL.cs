using OktavaProject.DL.Models;

namespace OktavaProject.DL
{
    public interface ISkillUserDL
    {
        Task<List<SkillUser>> GetSkillUsers();
        Task<bool> AddSkillUser(SkillUser[] skillsUser);
        Task<bool> RemoveSkillUser(int id);
        Task<bool> UpdateSkillUser(SkillUser skillUser, int id);
        Task<SkillUser> GetSkillUserById(int id);
        Task<bool> RemoveSkillUserByUserId(int id);

    }
}