using Animal_Glimpse.Data;
using Animal_Glimpse.Models;
using Microsoft.EntityFrameworkCore;

namespace Animal_Glimpse.Repositories.UserRepository
{
    public class UserRepository: IUserRepository
    {
        protected readonly AnimalContext _animalContext;
        protected readonly DbSet<User> _table;

        public UserRepository(AnimalContext animalContext)
        {
            _animalContext = animalContext;
            _table = animalContext.Set<User>();
        }
        

        public List<User> GetAllSorted()
        {
            var usersSorted = from s in _table
                              orderby s.UserName
                              select s;

            return usersSorted.AsNoTracking().ToList();
        }


        public List<User> GetAll()
        {
            return _table.AsNoTracking().ToList();
        }

        // GET
        public async Task<List<User>> GetAllAsync()
        {
            return await _table.AsNoTracking().ToListAsync();
        }

        // CREATE
        public void Create(User user)
        {
            _table.Add(user);
        }

        public async Task CreateAsync(User user)
        {
            await _table.AddAsync(user);
        }

        public void CreateRange(IEnumerable<User> users)
        {
            _table.AddRange(users);
        }

        public async Task CreateRangeAsync(IEnumerable<User> users)
        {
            await _table.AddRangeAsync(users);
        }

        // UPDATE
        public void Update(User user)
        {
            _table.Update(user);
        }

        public void UpdateRange(IEnumerable<User> users)
        {
            _table.UpdateRange(users);
        }

        // DELETE
        public void Delete(User user)
        {
            _table.Remove(user);
        }

        public void DeleteRange(IEnumerable<User> users)
        {
            _table.RemoveRange(users);
        }

        // FIND
        public User FindById(Guid id)
        {
            return _table.Find(id);
        }

        public async Task<User> FindByIdAsync(Guid id)
        {
            return await _table.FindAsync(id);
        }

        // SAVE
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
