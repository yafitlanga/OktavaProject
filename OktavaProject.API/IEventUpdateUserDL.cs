using OktavaProject.DL.Models;

namespace OktavaProject.DL
{
    public interface IEventUpdateUserDL
    {
        Task <List<EventUpdateUser>> GetEventUpdateUsers();
        Task<bool> AddEventUpdateUser(EventUpdateUser eventUpdateUser);
        Task<bool> UpdateEventUpdateUser(EventUpdateUser eventUpdateUser, int id);
        Task<bool> RemoveEventUpdateUser(int id);
        Task<EventUpdateUser> GetEventUpdateUserById(int id);
    }
}