using AutoMapper;
using Tema4.Models;
using Tema4.Models.DTOs;
using Tema4.Repositories.UserRepository;

namespace Tema4.Services.UserService
{
    public class UserService : IUserService
    {
        public IUserRepository _userRepository;
        public IMapper _mapper;
        public UserService(IUserRepository userRepRepository, IMapper mapper) 
        {
            _mapper = mapper;
            _userRepository = userRepRepository;
        }
        public async Task<List<UserDTO>> GetAllUsers()
        {
            var userList =  await _userRepository.GetAllAsync();  
            var userListDTO = _mapper.Map<List<UserDTO>>(userList);
            return userListDTO;
        }

        public UserDTO GetUserByUsername(string username)
        {
            var user = _userRepository.FindByUsername(username);
            var userDTO = _mapper.Map<UserDTO>(user);
            return userDTO;

           
        }

        Task<List<User>> IUserService.GetAllUsers()
        {
            throw new NotImplementedException();
        }
    }
}
