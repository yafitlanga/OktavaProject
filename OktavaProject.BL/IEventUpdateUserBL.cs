using OktavaProject.DL.Models;
using OktavaProjectEntities.DTO;

namespace OktavaProject.BL
{
    public interface IEventUpdateUserBL
    {
        Task<List<EventUpdateUserDTO>> GetEventUpdateUsers();
        Task<bool> AddEventUpdateUser(EventUpdateUserDTO eventUpdateUser);
        Task<bool> RemoveEventUpdateUser(int id);
        Task<bool> UpdateEventUpdateUser(EventUpdateUserDTO eventUpdateUser, int id);
        Task<EventUpdateUserDTO> GetEventUpdateUserById(int id);
    }
}