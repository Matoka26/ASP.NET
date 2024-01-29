using Animal_Glimpse.Data;
using Animal_Glimpse.Models;
using Animal_Glimpse.Repositories.GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace Animal_Glimpse.Repositories.ReactionRepository
{
    public class ReactionRepository: IReactionRepository
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
        public bool Save()
        {
            return _animalContext.SaveChanges() > 0;
        }
        public async Task<bool> SaveAsync()
        {
            return await _animalContext.SaveChangesAsync() > 0;
        }
    }
}
