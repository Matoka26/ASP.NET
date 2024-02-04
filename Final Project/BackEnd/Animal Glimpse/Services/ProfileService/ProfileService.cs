using Animal_Glimpse.Models;
using Animal_Glimpse.Models.DTOs;
using Animal_Glimpse.Models.DTOs.ProfileDTO;
using Animal_Glimpse.Models.Responses;
using Animal_Glimpse.Repositories.ProfileRepository;
using Animal_Glimpse.Repositories.UserRepository;
using AutoMapper;
using Microsoft.AspNetCore.Identity;

namespace Animal_Glimpse.Services.ProfileService
{
    public class ProfileService: IProfileService
    {
        public IProfileRepository _profileRepository;
        public IUserRepository _userRepository; 
        public IMapper _mapper;

        public ProfileService(IProfileRepository profileRepository, 
                                IMapper mapper,
                                IUserRepository userRepository)
        {
            _profileRepository = profileRepository;
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public async Task CreateProfile(ProfileCreateDTO profile)
        {
            var user = await _userRepository.GetUserById(profile.UserId);  
            if(user.Profile !=  null)
            {
                throw new Exception("User already has a profile");
            }

            var newProfile = _mapper.Map <Animal_Glimpse.Models.Profile>(profile);
            newProfile.Id = Guid.NewGuid();
            newProfile.UserId = user.Id;
            newProfile.User = user;
            user.Profile = newProfile;

            _userRepository.Update(user);
            
            _profileRepository.Create(newProfile);
            await _profileRepository.SaveAsync();
        }

        public async Task<ProfileDTO>? GetProfileByUsername(string username)
        {
            var userDTO = await _userRepository.GetByUsername(username);
            if (userDTO == null)
            {
                throw new Exception("Invalid User");
            }
            var prof = _profileRepository.GetProfileByUserId(userDTO.Id);
            var profMapped =  _mapper.Map<ProfileDTO>(prof);

            if(profMapped != null)
            {
                profMapped.Username = userDTO.UserName;
                return profMapped;
            }

            throw new Exception("User doesnt have a profile yet");
        }

        public async Task UpdateProfile(ProfileUpdateDTO profile)
        {
            var existingProfile = await _profileRepository.FindByIdAsync(profile.Id);

            if (existingProfile == null)
            {
                throw new Exception("Profile not found");
            }

            profile.LastModified = DateTime.Now; 
            if(profile.ProfilePic != null && profile.ProfilePic != "")
                existingProfile.ProfilePic = profile.ProfilePic;
            
            if(profile.CoverPic != null && profile.CoverPic != "")
                existingProfile.CoverPic = profile.CoverPic; 

            if(profile.Bio != null && profile.Bio != "")
                existingProfile.Bio = profile.Bio; 

            _profileRepository.Update(_mapper.Map<Animal_Glimpse.Models.Profile>(existingProfile));
            await _profileRepository.SaveAsync();
        }
    }
}
