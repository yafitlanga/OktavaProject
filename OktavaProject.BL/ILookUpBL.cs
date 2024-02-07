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
        Task<AcademicDegreeDTO> GetAcademicDegreeById(int id);
        Task<HourDTO> GetHourById(int id);
        Task<DayDTO> GetDayById(int id);
        Task<SkillDTO> GetSkillById(int id);
        Task<List<SkillDTO>> GetSkillsByUserId(int userId);
        
    }
}