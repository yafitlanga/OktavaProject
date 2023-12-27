using OktavaProject.DL.Models;
using OktavaProjectEntities.DTO;

namespace OktavaProject.BL
{
    public interface IEventBL
    {
        Task<List<EventDTO>> GetEvents();
        Task<bool> AddEvent(EventDTO _event);
        Task<bool> UpdateEvent(EventDTO _event, int id);
        Task<bool> RemoveEvent(int id);  

    }
}