using OktavaProject.DL.Models;

namespace OktavaProject.DL
{
    public interface ILookUpDL
    {
         Task<List<Skill>> GetSkills();
         Task<List<AcademicDegree>> GetAcademicDegrees();
         Task<List<Day>> GetDays();
         Task<List<Hour>> GetHours();
        Task<Skill> GetSkillById(int id);
        Task<Day> GetDayById(int id);
        Task<AcademicDegree> GetAcademicDegreeById(int id);
        Task<Hour> GetHourById(int id);
    }
}