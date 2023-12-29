using Animal_Glimpse.Data;
using Animal_Glimpse.Models;
using Animal_Glimpse.Repositories.GenericRepository;

namespace Animal_Glimpse.Repositories.ReactRepository
{
    public class ReactRepository: GenericRepository<React>, IReactRepository
    {
        public ReactRepository(AnimalContext context) : base(context) { }
    }
}
