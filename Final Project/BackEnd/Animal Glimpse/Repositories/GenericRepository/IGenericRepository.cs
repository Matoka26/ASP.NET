using Animal_Glimpse.Models.Base;

namespace Animal_Glimpse.Repositories.GenericRepository
{
    public interface IGenericRepository<TEntity> where TEntity:BaseEntity
    {
        // Get all data
        List<TEntity> GetAll();
        Task<List<TEntity>> GetAllAsync();

        // Create 
        void Create(TEntity entity);
        Task CreateAsync(TEntity entity);
        void CreateRange(IEnumerable<TEntity> entities);
        Task CreateRangeAsync(IEnumerable<TEntity> entities);
   
        // Update
        void Update(TEntity entitiy);
        void UpdateRange(IEnumerable<TEntity> entities);

        // Delete
        void Delete(TEntity entitiy);
        void DeleteRange(IEnumerable<TEntity> entities);
    
        // Find
        TEntity FindById(Guid id);
        Task<TEntity> FindByIdAsync(Guid id);

        // Save
        bool Save();
        Task<bool> SaveAsync();
    }
}
