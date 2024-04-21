using Microsoft.EntityFrameworkCore;
using OktavaProject.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OktavaProject.DL
{
    public class EventDL : IEventDL
    {
        OktavaDBContext _OktavaContext = new OktavaDBContext();
        public async Task<List<Event>> GetEvents()
        {
            try
            {
                var events = await _OktavaContext.Events
                    .Include(e => e.ResponsibleUser)
                    .ToListAsync();

                return events;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Event> GetEventById(int id)
        {
            try
            {
                var events = await _OktavaContext.Events.FirstOrDefaultAsync(events => events.Id == id);
                return events;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<int> AddEvent(Event _event)
        {
            try
            {
               await _OktavaContext.Events.AddAsync(_event);
                _OktavaContext.SaveChanges();
                return _event.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> UpdateEvent(Event _event, int id)
        {
            try
            {
                Event eventToUpdate = await _OktavaContext.Events.FirstOrDefaultAsync(x => x.Id == id);
                if (eventToUpdate != null)
                {
                    eventToUpdate.Name = _event.Name;
                    eventToUpdate.Address = _event.Address;
                    eventToUpdate.Hour = _event.Hour;
                    eventToUpdate.Payment = _event.Payment;
                    eventToUpdate.Date = _event.Date;
                    eventToUpdate.ResponsibleUserId = _event.ResponsibleUserId;
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
        public async Task<bool> RemoveEvent(int id)
        {
            try
            {
                Event eventToRemove = await _OktavaContext.Events.FirstOrDefaultAsync(x => x.Id == id);
                if (eventToRemove != null)
                {
                    _OktavaContext.Events.Remove(eventToRemove);
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
