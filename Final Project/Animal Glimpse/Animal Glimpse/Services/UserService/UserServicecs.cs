using Animal_Glimpse.Models;
using Animal_Glimpse.Repositories.CommentsRepository;
using Animal_Glimpse.Repositories.UserRepository;
using AutoMapper;

namespace Animal_Glimpse.Services.CommentsService
{
    public class UserService : IUserService
    {
        public IUserRepository _userRepository;
        public IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public List<User> GetAllSorted()
        {
            return _userRepository.GetAllSorted();
        } 
    }
}
