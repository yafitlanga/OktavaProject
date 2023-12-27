using OktavaProject.DL.Models;
using OktavaProjectEntities.DTO;

namespace OktavaProject.BL
{
    public interface IStudentBL
    {
        Task<List<StudentDTO>> GetStudents();
        Task<StudentDTO> GetStudentById(int id);
        Task<bool> AddStudent(StudentDTO student);
        Task<bool> UpdateStudent(StudentDTO student, int id);
        Task<bool> RemoveStudent(int id);
    }
}