using Animal_Glimpse.Models.DTOs;
using Animal_Glimpse.Repositories.UserRepository;
using AutoMapper;

namespace Animal_Glimpse.Services.UserService
{
    public class UserService: IUserService 
    {
        public IUserRepository _userRepository;
        public IMapper _mapper;
        
        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public List<UserDTO> GetUsersSorted()
        {
            var users = _mapper.Map<List<UserDTO>>(_userRepository.OrderByUsername());
            
            return users;
        }
    }
}
