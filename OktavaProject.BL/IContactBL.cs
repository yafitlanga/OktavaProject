using OktavaProject.DL.Models;
using OktavaProjectEntities.DTO;

namespace OktavaProject.BL
{
    public interface IContactBL
    {
        Task<List<ContactDTO>> GetContacts();
        Task<bool> AddContact(ContactDTO user);
        Task<bool> UpdateContact(ContactDTO user, int id);
        Task<bool> RemoveContact(int id);
        Task<ContactDTO> GetContactById(int id);
    }
}