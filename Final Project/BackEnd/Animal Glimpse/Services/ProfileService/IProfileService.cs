using Animal_Glimpse.Models;
using Animal_Glimpse.Models.DTOs.ProfileDTO;
using AutoMapper;

namespace Animal_Glimpse.Services.ProfileService
{
    public interface IProfileService
    {
        Task<ProfileDTO>? GetProfileByUsername(string username);
        Task UpdateProfile(ProfileUpdateDTO profile);
        Task CreateProfile(ProfileCreateDTO profile);
    }
}
