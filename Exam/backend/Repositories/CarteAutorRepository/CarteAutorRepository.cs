using backend.Data;
using backend.Models;
using backend.Repositories.GenericRepository;

namespace backend.Repositories.CarteAutorRepository
{
    public class CarteAutorRepository: GenericRepository<AutorCarteRelatie>, ICarteAutorRepository
    {
        public CarteAutorRepository(DatabaseContext context) : base(context) { }
    }
}
