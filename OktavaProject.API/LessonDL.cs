using Microsoft.EntityFrameworkCore;
using OktavaProject.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OktavaProject.DL
{
    public class LessonDL: ILessonDL
    {
        OktavaDBContext _OktavaContext = new OktavaDBContext();
        public async Task<List<Lesson>> GetLessons()
        {
            return await _OktavaContext.Lessons.ToListAsync();
        }
        public async Task<Lesson> GetLessonsById(int id)
        {
            try
            {
                var lesson = await _OktavaContext.Lessons.FirstOrDefaultAsync(lesson => lesson.Id == id);
                return lesson;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> AddLesson(Lesson lesson)
        {
            try
            {
                await _OktavaContext.Lessons.AddAsync(lesson);
                _OktavaContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Lesson>> GetLessonsByUserId(int userId)
        {
            var a = await _OktavaContext.Lessons.Where(l => l.UserId == userId)
                .Include(x => x.Skill)
                .Include(x => x.Hour)
                .OrderBy(x => x.DayId)
                .ThenBy(x => x.HourId).ToListAsync();
            // var b = await _OktavaContext.Lessons.Where(l => l.UserId == userId).Include(x => x.Skill).Include(x => x.Hour).GroupBy(x=> x.DayId).ToListAsync();
            return a;
        }

        public async Task<bool> UpdateLesson(Lesson lesson, int id)
        {
            try
            {
                Lesson lessonToUpdate = await _OktavaContext.Lessons.FirstOrDefaultAsync(x => x.Id == id);
                if (lessonToUpdate != null)
                {
                    lessonToUpdate.UserId =lesson.UserId;
                    lessonToUpdate.SkillId = lesson.SkillId;
                    lessonToUpdate.HourId = lesson.HourId;  
                    lessonToUpdate.DayId = lesson.DayId;
                    lessonToUpdate.Id = lesson.Id;
                    
                }
                else
                {
                    return false;
                }
                _OktavaContext.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<bool> RemoveLesson(int id)
        {
            try
            {
                Lesson lessonToRemove = await _OktavaContext.Lessons.FirstOrDefaultAsync(x => x.Id == id);
                if (lessonToRemove != null)
                {
                    _OktavaContext.Lessons.Remove(lessonToRemove);
                    _OktavaContext.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
                _OktavaContext.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

