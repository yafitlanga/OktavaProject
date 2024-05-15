using OktavaProject.DL.Models;
using OktavaProjectEntities.DTO;

namespace OktavaProject.BL
{
    public interface IStudentLessonBL
    {
        Task<List<StudentLessonDTO>> GetStudentLessons();
        Task<StudentLessonDTO> GetStudentLessonById(int id);
        Task<List<StudentLessonDTO>> GetStudentLessonByStudentId(int id);
        Task<List<StudentLessonDTO>> GetStudentLessons(int lessonId);
        Task<bool> UpdateStudentLesson(StudentLessonDTO studentLesson, int id);
        Task<bool> AddStudentLesson(StudentLessonDTO StudentLesson);
        Task<bool> RemoveStudentLesson(int id);
    }
}