using Microsoft.EntityFrameworkCore;
using Tema4.Models2.Base;
using Tema4.Data;
using Microsoft.Identity.Client;

namespace Tema4.Repositories.GenericRepository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly Tema4Context _tema4Context;
        protected readonly DbSet<TEntity> _table;

        public GenericRepository(Tema4Context tema4Context)
        {
            _tema4Context = tema4Context;
            _table = _tema4Context.Set<TEntity>();
        }

        // GET
        public List<TEntity> GetAll()
        {
            return  _table.AsNoTracking().ToList();
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _table.AsNoTracking().ToListAsync();
        }


        /*
        public IQueryable<TEntity> GetAllAsQueryable()
        {//intai faci queryu si apoi toList,nu invers
            return _table.AsNoTracking();
        }
        */

        //Create
        public void Create(TEntity entity)
        {
            _table.Add(entity);
        }
        public async Task CreateAsync(TEntity entity)
        {
            await _table.AddAsync(entity);
        }

        public void CreateRange(IEnumerable<TEntity> entities)
        {
            _table.AddRange(entities);
        }
        public async Task CreateRangeAsync(IEnumerable<TEntity> entities)
        {
            await _table.AddRangeAsync(entities);
        }

        // UPDATE
        public  void Update(TEntity entity)
        {
            _table.Update(entity);
        }

        public void UpdateRange(IEnumerable<TEntity> entities)
        {
            _table.UpdateRange(entities);
        }

        // DELETE
        public void Delete(TEntity entity)
        {
            _table.Remove(entity);
        }
        public void DeleteRange(IEnumerable<TEntity> entities)
        {
            _table.RemoveRange(entities);
        }

        //FIND
        public TEntity FindById(Guid id)
        {
            return _table.Find(id);
        }
        public async Task<TEntity> FindByIdAsync(Guid Id)
        {
            return await _table.FindAsync(Id);
        }
        // SAVE

        public bool Save()
        {
            return _tema4Context.SaveChanges() > 0;
        }
        public async Task<bool> SaveAsync()
        {
            return await _tema4Context.SaveChangesAsync() > 0;
        }
        /*
        public Task<bool> SaveAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }
        */
    }
}
