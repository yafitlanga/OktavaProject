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
                var students = await _OktavaContext.Students.ToListAsync();
                return students;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<Student> GetStudentById(int id)
        {
            try
            {
                var student = await _OktavaContext.Students.FirstOrDefaultAsync(student => student.Id == id);
                return student;
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

