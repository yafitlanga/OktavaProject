using OktavaProject.DL.Models;
using OktavaProject.DL;
using OktavaProjectEntities.DTO;

namespace OktavaProject.BL
{
    public interface ILookUpBL
    {
        Task<List<SkillDTO>> GetSkills();
        Task<List<DayDTO>> GetDay();
        Task<List<HourDTO>> GetHour();
        Task<List<AcademicDegreeDTO>> GetAcademicDegrees();

    }
}