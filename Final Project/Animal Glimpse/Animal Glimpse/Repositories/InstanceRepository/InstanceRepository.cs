using Animal_Glimpse.Data;
using Animal_Glimpse.Models;
using Animal_Glimpse.Repositories.GenericRepository;

namespace Animal_Glimpse.Repositories.InstanceRepository
{
    public class InstanceRepository: GenericRepository<Instance>, IInstanceRepository
    {
        public InstanceRepository(AnimalContext context) : base(context) { }
    }
}
