using Microsoft.EntityFrameworkCore;
using OktavaProject.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OktavaProject.DL
{
    public class EventUpdateUserDL : IEventUpdateUserDL
    {
        OktavaDBContext _OktavaContext = new OktavaDBContext();
        public async Task<List<EventUpdateUser>> GetEventUpdateUsers()
        {
            try
            {
                var eventUpdateUsers = await _OktavaContext.EventUpdateUsers.ToListAsync();
                return eventUpdateUsers;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<EventUpdateUser> GetEventUpdateUserById(int id)
        {
            try
            {
                var eventUpdateUser = await _OktavaContext.EventUpdateUsers.FirstOrDefaultAsync(eventUpdateUser => eventUpdateUser.Id == id);
                return eventUpdateUser;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<bool> AddEventUpdateUser(EventUpdateUser eventUpdateUser)
        {
            try
            {
                await _OktavaContext.EventUpdateUsers.AddAsync(eventUpdateUser);
                _OktavaContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<bool> UpdateEventUpdateUser(EventUpdateUser eventUpdateUser, int id)
        {
            try
            {
                EventUpdateUser eventUpdateUserToUpdate = await _OktavaContext.EventUpdateUsers.FirstOrDefaultAsync(x => x.Id == id);
                if (eventUpdateUserToUpdate != null)
                {
                    eventUpdateUserToUpdate.Name = eventUpdateUser.Name;
                    eventUpdateUserToUpdate.Date = eventUpdateUser.Date;
                    eventUpdateUserToUpdate.Mail = eventUpdateUser.Mail;
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
        public async Task<bool> RemoveEventUpdateUser(int id)
        {
            try
            {
                EventUpdateUser eventUpdateUserToRemove = await _OktavaContext.EventUpdateUsers.FirstOrDefaultAsync(x => x.Id == id);
                if (eventUpdateUserToRemove != null)
                {
                    _OktavaContext.EventUpdateUsers.Remove(eventUpdateUserToRemove);
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