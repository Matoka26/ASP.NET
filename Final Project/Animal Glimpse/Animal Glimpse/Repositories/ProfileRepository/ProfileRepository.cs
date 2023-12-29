using Animal_Glimpse.Data;
using Animal_Glimpse.Models;
using Animal_Glimpse.Repositories.GenericRepository;

namespace Animal_Glimpse.Repositories.ProfileRepository
{
    public class ProfileRepository: GenericRepository<Profile>, IProfileRepository
    {
        public ProfileRepository(AnimalContext context) : base(context) { }
    }
}
