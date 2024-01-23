using Animal_Glimpse.Models;
using Animal_Glimpse.Models.DTOs;
using Animal_Glimpse.Models.DTOs.UserDTOs;
using Animal_Glimpse.Models.Responses;

namespace Animal_Glimpse.Services.CommentsService
{
    public interface IUserService
    {
       Task<UserDTO> GetUserById(Guid id);
       Task<UserDTO> CreateAsync(UserCreateDTO user);
       Task<UserDTO> Update(UserUpdateDTO user);
       Task Delete(Guid id);

       Task<Guid> Login(LoginDTO loginModel);
       Task Logout();
       Task<ErrorResponse> SignUp(SignUpDTO signUpDto);
    }
}
