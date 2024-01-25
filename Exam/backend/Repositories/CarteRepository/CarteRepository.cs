using backend.Data;
using backend.Models;
using backend.Repositories.GenericRepository;

namespace backend.Repositories.CarteRepository
{
    public class CarteRepository: GenericRepository<Carte>, ICarteRepository
    {
        public CarteRepository(DatabaseContext context) : base(context) { }

    }
}
