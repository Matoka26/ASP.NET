using Animal_Glimpse.Models;
using Animal_Glimpse.Models.DTOs;
using AutoMapper;
using Microsoft.AspNetCore.Identity;

namespace Animal_Glimpse.Helpers
{
    public class MapperProfile: AutoMapper.Profile
    {
        public MapperProfile()
        {
            //CreateMap<List<User>, List<UserDTO>>();
            //CreateMap<List<UserDTO>, List<User>>();

            CreateMap<User, UserDTO>();
            CreateMap<UserDTO, User>();
        }
    }
}
