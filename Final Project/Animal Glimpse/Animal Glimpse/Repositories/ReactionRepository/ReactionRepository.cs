using Animal_Glimpse.Data;
using Animal_Glimpse.Models;
using Animal_Glimpse.Repositories.GenericRepository;

namespace Animal_Glimpse.Repositories.ReactionRepository
{
    public class ReactionRepository: GenericRepository<Reaction>, IReactionRepository
    {
        public ReactionRepository(AnimalContext context) : base(context) { }
    }
}
