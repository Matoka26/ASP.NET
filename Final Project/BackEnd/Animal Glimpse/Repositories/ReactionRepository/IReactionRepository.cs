using Animal_Glimpse.Models;
using Animal_Glimpse.Data;
using Animal_Glimpse.Repositories.GenericRepository;

namespace Animal_Glimpse.Repositories.ReactionRepository
{
    public interface IReactionRepository
    {
        Task CreateAsync(Reaction entity);
        void Delete(Reaction entity);
        Task<Reaction> FindByKey(Guid userId, Guid postId);
        bool Save();
        Task<bool> SaveAsync();

        Task<Dictionary<string, List<string>>> GetReactionsOfPost(Guid postId);
    }
}
