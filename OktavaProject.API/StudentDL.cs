﻿using Microsoft.EntityFrameworkCore;
using OktavaProject.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OktavaProject.DL
{
    public class StudentDL : IStudentDL
    {
        OktavaDBContext _OktavaContext = new OktavaDBContext();
        public async Task<List<Student>> GetStudents()
        {
            try
            {
                var students = await _OktavaContext.Students.Select(s => s).

                            Include(student => student.StudentLessons).
                            ThenInclude(lesson => lesson.Lesson).
                            ThenInclude(skill => skill.Skill).
                            Include(student => student.StudentLessons).
                            ThenInclude(lesson => lesson.Lesson).
                            ThenInclude(day => day.Day).
                            Include(student => student.StudentLessons).
                            ThenInclude(lesson => lesson.Lesson).
                            ThenInclude(hour => hour.Hour).
                            Include(student => student.StudentLessons).
                            ThenInclude(lesson => lesson.Lesson).
                            ThenInclude(user => user.User).
                            ToListAsync();
                return students;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public async Task<Student> GetStudentById(string studentId)
        {
            try
            {
                var student = await _OktavaContext.Students.FirstOrDefaultAsync(student => student.StudentId == studentId);
                return student;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<List<Student>> GetStudentByUserId(int userId)
        {
            try
            {
                var students = await _OktavaContext.Lessons
                    .Where(l => l.UserId == userId)
                    .SelectMany(l => l.StudentLessons)
                    .Select(sl => sl.Student)
                    .ToListAsync();
                return students;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<bool> AddStudent(Student student)
        {
            try
            {
                await _OktavaContext.Students.AddAsync(student);
                _OktavaContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> UpdateStudent(Student student, int id)
        {
            try
            {
                Student studentToUpdate = await _OktavaContext.Students.FirstOrDefaultAsync(x => x.Id == id);
                if (studentToUpdate != null)
                {
                    studentToUpdate.FirstName = student.FirstName;
                    studentToUpdate.LastName = student.LastName;
                    studentToUpdate.Gender = student.Gender;
                    studentToUpdate.Address = student.Address;
                    studentToUpdate.Birthday = student.Birthday;
                    studentToUpdate.Mail = student.Mail;
                    studentToUpdate.StudentId = student.StudentId;
                    studentToUpdate.Phone = student.Phone;
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
        public async Task<bool> RemoveStudent(int id)
        {
            try
            {
                Student studentToRemove = await _OktavaContext.Students.FirstOrDefaultAsync(x => x.Id == id);
                StudentLessonDL studentLesson = new StudentLessonDL();
                await studentLesson.RemoveStudentLessonsByStudentId(studentToRemove.Id);
                if (studentToRemove != null)
                {
                    _OktavaContext.Students.Remove(studentToRemove);
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

