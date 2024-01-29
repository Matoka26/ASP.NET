using Animal_Glimpse.Data;
using Animal_Glimpse.Models;
using Animal_Glimpse.Models.DTOs.CommentDTO;
using Animal_Glimpse.Repositories.GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace Animal_Glimpse.Repositories.ReactionRepository
{
    public class ReactionRepository : IReactionRepository
    {
        private readonly AnimalContext _animalContext;
        protected readonly DbSet<Reaction> _table;
        public ReactionRepository(AnimalContext context)
        {
            _animalContext = context;
            _table = _animalContext.Set<Reaction>();
        }

        public async Task CreateAsync(Reaction entity)
        {
            await _table.AddAsync(entity);
        }

        public void Delete(Reaction entity)
        {
            _table.Remove(entity);
        }
        public bool Save()
        {
            return _animalContext.SaveChanges() > 0;
        }
        public async Task<bool> SaveAsync()
        {
            return await _animalContext.SaveChangesAsync() > 0;
        }

        public async Task<Reaction> FindByKey(Guid userId, Guid postId)
        {
            return await _table.FindAsync(userId, postId);
        }

        public async Task<Dictionary<string, List<string>>> GetReactionsOfPost(Guid postId)
        {
            var query = _table.Where(s => s.PostId == postId)
                              .Include(s => s.User)
                              .Include(s => s.React);

            var result = await query.GroupBy(s => s.React.Name)
                                    .ToDictionaryAsync(
                                        group => group.Key,
                                        group => group.Select(r => r.User.UserName).ToList()
                                    );
            return result;
        }
    }
}
