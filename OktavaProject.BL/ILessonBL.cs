using OktavaProject.DL.Models;
using OktavaProjectEntities.DTO;

namespace OktavaProject.BL
{
    public interface ILessonBL
    {
        Task<List<LessonDTO>> GetLessons();
        Task<bool> RemoveLesson(int id);
        Task<List<LessonDTO>> GetLessonWithDetails(int lessonId);
        Task<List<LessonDTO>> GetLessonsForSelect();
        Task<bool> UpdateLesson(LessonDTO lesson, int id);
        Task<bool> AddLessons(LessonDTO lesson);
        Task<LessonDTO> GetLessonById(int id);
        Task<List<LessonDTO>> GetLessonByUserId(int UserId);

    }
}