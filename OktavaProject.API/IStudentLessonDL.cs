using OktavaProject.DL.Models;

namespace OktavaProject.DL
{
    public interface IStudentLessonDL
    {
        Task<List<StudentLesson>> GetStudentLessons();
        Task<List<StudentLesson>> GetStudentLessons(int lessonId);
        Task<List<StudentLesson>> GetStudentLessonByStudentId(int id);
        Task<StudentLesson> GetStudentLessonById(int id);
        Task<bool> AddStudentLesson(StudentLesson studentLesson);
        Task<bool> UpdateStudentLesson(StudentLesson studentLesson,int id);
        Task<bool> RemoveStudentLesson(int id);
        
    }
}