using Microsoft.EntityFrameworkCore;
using OktavaProject.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OktavaProject.DL
{
    public class UserDL : IUserDL
    {
        OktavaDBContext _OktavaContext = new OktavaDBContext();
        public async Task<List<User>> GetUsers()
        {
            try
            {
                var users = await _OktavaContext.Users.Select(s => s).
                            Include(user => user.SkillUsers).
                            ThenInclude(skill => skill.Skill).
                            Include(user => user.AcademicDegreeUsers).
                            ThenInclude(academicDegree => academicDegree.AcademicDegree).ToListAsync();
                return users;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public async Task<User> GetUserById(string userId)
        {
            try
            {
                var user = await _OktavaContext.Users.FirstOrDefaultAsync(user => user.UsersId == userId);
                return user;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<User> Login(string userId, string password)
        {
            try
            {
                var user = await _OktavaContext.Users.FirstOrDefaultAsync(u => u.Password == password && u.UsersId == userId);
                if (user == null)
                {
                    return null;
                }
                return user;
            }
            catch (Exception ex)
            {
                throw new Exception("the user is undifind", ex);
            }
        }

        public async Task<int> AddUser(User user)
        {
            try
            {
                await _OktavaContext.Users.AddAsync(user);        

                _OktavaContext.SaveChanges();
                return user.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> UpdateUser(User user, int id)
        {
            try
            {
                User userToUpdate = await _OktavaContext.Users.FirstOrDefaultAsync(x => x.Id == id);
                if (userToUpdate != null)
                {
                    userToUpdate.FirstName = user.FirstName;
                    userToUpdate.LastName = user.LastName;
                    userToUpdate.PhoneOne = user.PhoneOne;
                    userToUpdate.PhoneTwo = user.PhoneTwo;
                    userToUpdate.UsersId = user.UsersId;
                    userToUpdate.Mail = user.Mail;
                    userToUpdate.Password = user.Password;
                    userToUpdate.Level = user.Level;
                    userToUpdate.Lessons = user.Lessons;
                    userToUpdate.Birthday = user.Birthday;
                    userToUpdate.Address = user.Address;
                    //TODO - עדכון תארים ומיומניות
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
        public async Task<bool> RemoveUser(int id)
        {
            try
            {             
                var userToRemove = await _OktavaContext.Users
                              .Include(u => u.SkillUsers)
                              .Include(u => u.AcademicDegreeUsers)
                              .Include(u => u.Events)
                              .Include(u => u.Lessons)
                              .FirstOrDefaultAsync(u => u.Id == id);

                if (userToRemove != null)
                {
                    foreach (var evt in userToRemove.Events)
                    {
                        evt.ResponsibleUserId = null;
                    }
                    _OktavaContext.SaveChanges();

                    foreach (var evt in userToRemove.Lessons)
                    {
                        evt.UserId = null;
                    }
                    _OktavaContext.SaveChanges();

                    _OktavaContext.AcademicDegreeUsers.RemoveRange(userToRemove.AcademicDegreeUsers);
                    _OktavaContext.SkillUsers.RemoveRange(userToRemove.SkillUsers);
                    _OktavaContext.Users.Remove(userToRemove);
                    await _OktavaContext.SaveChangesAsync();
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


