using OktavaProject.DL.Models;

namespace OktavaProject.DL
{
    public interface IStudentDL
    {
        Task<List<Student>> GetStudents();
        Task<Student> GetStudentById(string studentId);
        Task<bool> AddStudent(Student student);
        Task<bool> UpdateStudent(Student student, int id);
        Task<bool> RemoveStudent(int id);
        Task<List<Student>> GetStudentByUserId(int userId);

    }
}