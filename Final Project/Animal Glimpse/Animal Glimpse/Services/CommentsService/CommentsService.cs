using Animal_Glimpse.Repositories.CommentsRepository;
using AutoMapper;

namespace Animal_Glimpse.Services.CommentsService
{
    public class CommentsService : ICommentsService
    {
        public ICommentsRepository _commentsRepository;
        public IMapper _mapper;

        public CommentsService(ICommentsRepository commentsRepository, IMapper mapper)
        {
            _commentsRepository = commentsRepository;
            _mapper = mapper;
        }
    }
}
