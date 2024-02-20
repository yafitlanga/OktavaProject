using OktavaProject.DL.Models;
using OktavaProjectEntities.DTO;

namespace OktavaProject.BL
{
    public interface IUserBL
    {
        Task<List<UserDTO>> GetUsers();
        Task<UserDTO> GetUserById(string userId);
        Task<int> AddUser(UserDTO user);
        Task<bool> UpdateUser(UserDTO user, int id);
        Task<bool> RemoveUser(int id);
        Task<UserDTO> Login(string userId, string password);
    }
}