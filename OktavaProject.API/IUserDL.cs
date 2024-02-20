using OktavaProject.DL.Models;

namespace OktavaProject.DL
{
    public interface IUserDL
    {
        Task<List<User>> GetUsers();
        Task<User> GetUserById(string userId);
        Task<int> AddUser(User user);
        Task<bool> UpdateUser(User user, int id); 
        Task<bool> RemoveUser(int id);
        Task<User> Login(string userId, string password);
    }
}