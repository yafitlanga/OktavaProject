﻿using OktavaProject.DL.Models;

namespace OktavaProject.DL
{
    public interface ILessonDL
    {
        Task<List<Lesson>> GetLessons();
        Task<bool> AddLesson(Lesson lesson);
        Task<List<Lesson>> GetLessonsForSelect();
        Task<List<Lesson>> GetLessonWithDetails(int lessonId);
        Task<bool> UpdateLesson(Lesson lesson, int id);
        Task<bool> RemoveLesson(int id);
        Task<Lesson> GetLessonsById(int id);
        Task<List<Lesson>> GetLessonsByUserId(int userId);
    }
}