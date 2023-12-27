using OktavaProject.DL.Models;
using OktavaProjectEntities.DTO;

namespace OktavaProject.BL
{
    public interface IAcademicDegreeUserBL
    {
        Task<List<AcademicDegreeUserDTO>> GetAcademicDegreeUsers();
        Task<bool> RemoveAcademicDegreeUser(int id);
        Task<bool> UpdateAcademicDegreeUser(AcademicDegreeUserDTO AcademicDegreeUser, int id);
        Task<bool> AddAcademicDegreeUser(AcademicDegreeUserDTO _AcademicDegreeUser);
    }
}