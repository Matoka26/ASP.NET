using backend.Data;
using backend.Models;
using backend.Repositories.GenericRepository;

namespace backend.Repositories.AutorRepository
{
    public class AutorRepository: GenericRepository<Autor>, IAutorRepository
    {
        public AutorRepository(DatabaseContext context) : base(context) { }

    }
}
