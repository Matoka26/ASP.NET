using Animal_Glimpse.Models;
using Animal_Glimpse.Repositories.GenericRepository;

namespace Animal_Glimpse.Repositories.ProfileRepository
{
    public interface IProfileRepository: IGenericRepository<Profile>
    {
        Profile? GetProfileByUserId(Guid userId);
    }
}
