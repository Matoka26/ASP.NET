using Animal_Glimpse.Models;
using Animal_Glimpse.Models.DTOs.PostDTO;
using Animal_Glimpse.Models.DTOs.UserDTOs;
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

        public async Task CreatePost(PostCreateDTO post)
        {
            var newPost = new Post()
            {
                Id = Guid.NewGuid(),
                Picture = post.Picture,
                Description = post.Description,
                UserId = post.UserId,
                CreatedTime = DateTime.Now
            };

            await _postRepository.CreateAsync(_mapper.Map<Post>(newPost));
            await _postRepository.SaveAsync();
        }

        public async Task<List<PostCreateDTO>> GetPostsByUsername(string username)
        {
            var user = await _userRepository.GetByUsername(username);

            if (user == null)
            {
                throw new Exception("Invalid User");
            }
            var posts = await _postRepository.GetAllPostsAsync(user.Id);

            return _mapper.Map<List<PostCreateDTO>>(posts);
        }

        public void Delete(Guid id)
        {
            var post = _postRepository.FindById(id);
            if(post == null)
            {
                throw new Exception("Post doesnt exist");
            }
            _postRepository.Delete(post);
            _postRepository.Save();
        }

        public void UpdatePost(PostUpdateDTO post)
        {
            var existingPost =  _postRepository.FindById(post.Id); 
            if(existingPost == null)
            {
                throw new Exception("No Post Found");
            }

            existingPost.LastModifiedTime = DateTime.Now;
            if(post.Description != null) existingPost.Description = post.Description;
            
            _postRepository.Update(_mapper.Map<Post>(existingPost));
            _postRepository.Save();
        }

        public async Task<List<PostShownDTO>> GetFeed()
        {
            var posts = await _postRepository.GetFeed();

            return _mapper.Map<List<PostShownDTO>>(posts);
        }
    }
}
