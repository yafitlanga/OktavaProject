using OktavaProject.DL.Models;
using OktavaProjectEntities.DTO;

namespace OktavaProject.BL
{
    public interface IStudentBL
    {
        Task<List<StudentDTO>> GetStudents();
        Task<StudentDTO> GetStudentById(string studentId);
        Task<bool> AddStudent(StudentDTO student);
        Task<bool> UpdateStudent(StudentDTO student, int id);
        Task<bool> RemoveStudent(int id);
        Task<List<StudentDTO>> GetStudentByUserId(int userId);
    }
}