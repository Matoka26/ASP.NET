using Animal_Glimpse.Models;
using Animal_Glimpse.Models.DTOs.PostDTO;
using Animal_Glimpse.Repositories.PostRepository;
using Animal_Glimpse.Repositories.UserRepository;
using AutoMapper;

namespace Animal_Glimpse.Services.PostService
{
    public class PostService: IPostService
    {
        public IUserRepository _userRepository;
        public IPostRepository _postRepository;
        public IMapper _mapper;

        public PostService(IPostRepository postRepository,
                            IUserRepository userRepository,
                            IMapper mapper)
        {
            _userRepository = userRepository;
            _postRepository = postRepository;
            _mapper = mapper;
        }

        public async Task<List<PostDTO>> GetPostsByUsername(string username)
        {
            var user = await _userRepository.GetByUsername(username);

            if (user == null)
            {
                throw new Exception("Invalid User");
            }
            var posts = await _postRepository.GetAllPostsAsync(user.Id);

            return _mapper.Map<List<PostDTO>>(posts);
        }
    }
}
