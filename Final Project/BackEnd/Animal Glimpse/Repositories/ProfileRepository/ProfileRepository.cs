using Animal_Glimpse.Data;
using Animal_Glimpse.Models;
using Animal_Glimpse.Models;
using Animal_Glimpse.Repositories.GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace Animal_Glimpse.Repositories.ProfileRepository
{
    public class ProfileRepository: GenericRepository<Profile>, IProfileRepository
    {
        public ProfileRepository(AnimalContext context) : base(context) { }
        
        public  Profile? GetProfileByUserId(Guid userId)
        {
            return  _table.FirstOrDefault(profile => profile.UserId == userId);
        }
    }
}
