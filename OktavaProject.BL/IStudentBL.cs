using OktavaProject.DL.Models;
using OktavaProjectEntities.DTO;

namespace OktavaProject.BL
{
    public interface IStudentBL
    {
        Task<List<StudentDTO>> GetStudents();
        Task<bool> AddStudent(StudentDTO student);
        Task<bool> UpdateStudent(StudentDTO student, int id);
        Task<bool> RemoveStudent(int id);
    }
}