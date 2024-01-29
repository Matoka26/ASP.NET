using Animal_Glimpse.Models;
using Animal_Glimpse.Data;
using Animal_Glimpse.Repositories.GenericRepository;

namespace Animal_Glimpse.Repositories.ReactionRepository
{
    public interface IReactionRepository
    {
        Task CreateAsync(Reaction entity);
        bool Save();
        Task<bool> SaveAsync();
    }
}
