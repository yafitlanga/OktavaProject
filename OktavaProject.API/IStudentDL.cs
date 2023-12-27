using OktavaProject.DL.Models;

namespace OktavaProject.DL
{
    public interface IStudentDL
    {
        Task<List<Student>> GetStudents();
        Task<Student> GetStudentById(int id);
        Task<bool> AddStudent(Student student);
        Task<bool> UpdateStudent(Student student, int id);
        Task<bool> RemoveStudent(int id);
    }
}