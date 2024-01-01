using Animal_Glimpse.Repositories.PostRepository;
using AutoMapper;

namespace Animal_Glimpse.Services.PostService
{
    public class PostService: IPostService
    {
        public IPostRepository _postRepository;
        public IMapper _mapper;

        public PostService(IPostRepository postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }
    }
}
