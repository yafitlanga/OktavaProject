using OktavaProject.DL.Models;

namespace OktavaProject.DL
{
    public interface IEventDL
    {
        Task<List<Event>> GetEvents();
        Task<bool> AddEvent(Event _event);
        Task<bool> UpdateEvent(Event _event, int id);
        Task<bool> RemoveEvent(int id);
        Task<Event> GetEventById(int id);
    }
}