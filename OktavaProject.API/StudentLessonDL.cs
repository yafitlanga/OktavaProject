using Microsoft.EntityFrameworkCore;
using OktavaProject.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;


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

        public async Task<List<StudentLesson>> GetStudentLessons(int lessonId)
        {
            try
            {
                var students = await _OktavaContext.StudentLessons.Include(sl => sl.Student).Where(sl => sl.LessonId == lessonId)
                    .Select(sl => new StudentLesson
                    {
                        Id = sl.Id,
                        LessonId = sl.LessonId,
                        StudentId = sl.StudentId,
                        Student = new Student
                        {
                            FirstName = sl.Student.FirstName,
                            LastName = sl.Student.LastName,
                            Phone = sl.Student.Phone,
                            Birthday = sl.Student.Birthday,
                            Address = sl.Student.Address,
                            StudentId = sl.Student.StudentId,
                            Mail = sl.Student.Mail,
                            Gender = sl.Student.Gender,
                        }
                    }).ToListAsync();
                return students;
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

        public async Task<List<StudentLesson>> GetStudentLessonByStudentId(int id)
        {
            try
            {
                var studentLesson = await _OktavaContext.StudentLessons
                    .Where(sl => sl.StudentId == id).Include(sl => sl.Student)
                    .Select(sl => new StudentLesson
                    {
                        Id = sl.Id,
                        LessonId = sl.LessonId,
                        StudentId = sl.StudentId,
                        Lesson = new Lesson
                        {
                            Id = sl.Lesson.Id,
                            UserId = sl.Lesson.UserId,
                            DayId = sl.Lesson.DayId,
                            HourId = sl.Lesson.HourId,
                            SkillId = sl.Lesson.SkillId,
                            Day = sl.Lesson.Day,
                            Hour = sl.Lesson.Hour,
                            Skill = sl.Lesson.Skill,
                           // User = sl.Lesson.User,
                        }
                    }).ToListAsync();
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
                    studentLessonToUpdate.StudentId = studentLessonToUpdate.StudentId;
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

        public async Task<bool> RemoveStudentLessonsByStudentId(int StudentId)
        {
            try
            {
                List<StudentLesson> studentLessonToRemove = await _OktavaContext.StudentLessons.Where(x => x.StudentId == StudentId).ToListAsync();
                if (studentLessonToRemove != null)
                {
                    foreach (var item in studentLessonToRemove)
                    {
                        _OktavaContext.StudentLessons.Remove(item);
                        _OktavaContext.SaveChanges();
                    }
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

