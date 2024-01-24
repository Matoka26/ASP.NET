using Animal_Glimpse.Models;
using Animal_Glimpse.Models.DTOs;
using Animal_Glimpse.Models.DTOs.PostDTO;
using Animal_Glimpse.Models.DTOs.ProfileDTO;
using Animal_Glimpse.Models.DTOs.UserDTOs;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Profile = Animal_Glimpse.Models.Profile;

namespace Animal_Glimpse.Helpers
{
    public class MapperProfile: AutoMapper.Profile
    {
        public MapperProfile()
        {
            var hasher = new PasswordHasher<User>();

            // USER
            CreateMap<User, UserActionDTO>();

            CreateMap<User, UserCreateDTO>();
            CreateMap<User, UserUpdateDTO>();

            CreateMap<User, UserDTO>();
            CreateMap<UserDTO, User>();

            CreateMap<UserUpdateDTO, User>();
            CreateMap<UserCreateDTO, User>();

            CreateMap<SignUpDTO, User>()
                .ForMember(u => u.Id, opt =>
                    opt.MapFrom(src => new Guid()))
                .ForMember(u => u.PasswordHash, opt =>
                    opt.MapFrom(src => hasher.HashPassword(null, src.Password)))
                .ForMember(u => u.LockoutEnabled, opt =>
                    opt.MapFrom(src => false))
                .ForMember(u => u.SecurityStamp, opt =>
                    opt.Ignore());

            // PROFILE
            CreateMap<Profile, ProfileDTO>();
            CreateMap<ProfileDTO, Profile>();

            CreateMap<Profile, ProfileUpdateDTO>();
            CreateMap<ProfileUpdateDTO, Profile>();

            CreateMap<Profile, ProfileCreateDTO>();
            CreateMap<ProfileCreateDTO, Profile>();
            
            // POST
            CreateMap<PostCreateDTO, Post>();
            CreateMap<Post, PostCreateDTO>();

            CreateMap<PostShownDTO, Post>();
            CreateMap<Post, PostShownDTO>();
        }
    }
}
