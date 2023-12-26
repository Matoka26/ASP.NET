using Tema4.Models;
using Tema4.Models.DTOs;
namespace Tema4.Services.UserService
{
    public interface IUserService
    {
        public Task<List<User>> GetAllUsers();
        public UserDTO GetUserByUsername(string username);
    }
}
