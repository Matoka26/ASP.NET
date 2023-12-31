using Animal_Glimpse.Models;
using Animal_Glimpse.Models.DTOs;

namespace Animal_Glimpse.Services.UserService
{
    public interface IUserService
    {
        //UserDTO GetUserByUsername(string username);

        List<UserDTO> GetUsersSorted();
    }
}
