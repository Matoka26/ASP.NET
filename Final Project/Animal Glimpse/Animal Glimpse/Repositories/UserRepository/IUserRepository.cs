using Animal_Glimpse.Models;

namespace Animal_Glimpse.Repositories.UserRepository
{
    public interface IUserRepository 
    {
        List<User> GetAllSorted();



        // Get all data
        List<User> GetAll();
        Task<List<User>> GetAllAsync();

        // Create 
        void Create(User entity);
        Task CreateAsync(User entity);
        void CreateRange(IEnumerable<User> entities);
        Task CreateRangeAsync(IEnumerable<User> entities);

        // Update
        void Update(User entitiy);
        void UpdateRange(IEnumerable<User> entities);

        // Delete
        void Delete(User entitiy);
        void DeleteRange(IEnumerable<User> entities);

        // Find
        User FindById(Guid id);
        Task<User> FindByIdAsync(Guid id);

        // Save
        bool Save();
        Task<bool> SaveAsync();
    }
}
