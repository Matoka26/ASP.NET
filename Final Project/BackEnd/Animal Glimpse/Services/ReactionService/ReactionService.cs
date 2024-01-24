using Animal_Glimpse.Repositories.ReactionRepository;
using AutoMapper;

namespace Animal_Glimpse.Services.ReactionService
{
    public class ReactionService: IReactionService
    {
        public IReactionRepository _reactionRepository;
        public IMapper _mapper;

        public ReactionService(IReactionRepository reactionRepository, IMapper mapper)
        {
            _reactionRepository = reactionRepository;
            _mapper = mapper;
        }
    }
}
