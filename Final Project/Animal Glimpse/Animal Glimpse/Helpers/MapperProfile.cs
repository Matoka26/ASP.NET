using Animal_Glimpse.Models;
using Animal_Glimpse.Models.DTOs;
using Animal_Glimpse.Models.DTOs.UserDTOs;
using AutoMapper;
using Microsoft.AspNetCore.Identity;

namespace Animal_Glimpse.Helpers
{
    public class MapperProfile: AutoMapper.Profile
    {
        public MapperProfile()
        {
            var hasher = new PasswordHasher<User>();

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
        }
    }
}
