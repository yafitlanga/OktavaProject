using OktavaProject.DL.Models;
using OktavaProjectEntities.DTO;

namespace OktavaProject.BL
{
    public interface IStudentBL
    {
        Task<List<StudentDTO>> GetStudents();
        Task<List<StudentDTO>> GetStudentById(int studentId);
        Task<bool> AddStudent(StudentDTO student);
        Task<bool> UpdateStudent(StudentDTO student, int id);
        Task<bool> RemoveStudent(int id);
        Task<List<StudentDTO>> GetStudentByUserId(int userId);
    }
}