using OktavaProject.DL.Models;

namespace OktavaProject.DL
{
    public interface ILookUpDL
    {
         Task<List<Skill>> GetSkills();
         Task<List<AcademicDegree>> GetAcademicDegrees();
         Task<List<Day>> GetDays();
         Task<List<Hour>> GetHours();
    }
}