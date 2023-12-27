using Microsoft.EntityFrameworkCore;
using OktavaProject.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OktavaProject.DL
{
    public class StudentLessonDL : IStudentLessonDL
    {
        OktavaDBContext _OktavaContext = new OktavaDBContext();
        public async Task<List<StudentLesson>> GetStudentLessons()
        {
            try
            {
                var studentLessons = await _OktavaContext.StudentLessons.ToListAsync();
                return studentLessons;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<StudentLesson> GetStudentLessonById(int id)
        {
            try
            {
                var studentLesson = await _OktavaContext.StudentLessons.FirstOrDefaultAsync(studentLesson => studentLesson.Id == id);
                return studentLesson;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<bool> AddStudentLesson(StudentLesson studentLesson)
        {
            try
            {
                await _OktavaContext.StudentLessons.AddAsync(studentLesson);
                _OktavaContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<bool> UpdateStudentLesson(StudentLesson studentLesson, int id)
        {
            try
            {
                StudentLesson studentLessonToUpdate = await _OktavaContext.StudentLessons.FirstOrDefaultAsync(x => x.Id == id);
                if (studentLessonToUpdate != null)
                {
                    studentLessonToUpdate.UserId = studentLessonToUpdate.UserId;
                    studentLessonToUpdate.LessonId = studentLessonToUpdate.LessonId;
                    _OktavaContext.SaveChanges(); 
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<bool> RemoveStudentLesson(int id)
        {
            try
            {
                StudentLesson studentLessonToRemove = await _OktavaContext.StudentLessons.FirstOrDefaultAsync(x => x.Id == id);
                if (studentLessonToRemove != null)
                {
                    _OktavaContext.StudentLessons.Remove(studentLessonToRemove);
                    _OktavaContext.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

