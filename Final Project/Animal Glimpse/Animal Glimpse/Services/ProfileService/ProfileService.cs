using Animal_Glimpse.Repositories.ProfileRepository;
using AutoMapper;

namespace Animal_Glimpse.Services.ProfileService
{
    public class ProfileService: IProfileService
    {
        public IProfileRepository _profileRepository;
        public IMapper _mapper;

        public ProfileService(IProfileRepository profileRepository, IMapper mapper)
        {
            _profileRepository = profileRepository;
            _mapper = mapper;
        }
    }
}
