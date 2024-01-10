using OktavaProject.DL.Models;
using OktavaProjectEntities.DTO;

namespace OktavaProject.BL
{
    public interface ILessonBL
    {
        Task<List<Lesson>> GetLessons();
        Task<bool> RemoveLesson(int id);
        Task<bool> UpdateLesson(LessonDTO lesson, int id);
        Task<bool> AddLessons(LessonDTO lesson);
        Task<LessonDTO> GetLessonById(int id);

    }
}