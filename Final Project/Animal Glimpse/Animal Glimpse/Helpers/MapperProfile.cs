using Animal_Glimpse.Models;
using Animal_Glimpse.Models.DTOs;
using AutoMapper;

namespace Animal_Glimpse.Helpers
{
    public class MapperProfile: AutoMapper.Profile
    {
        public MapperProfile()
        {
            CreateMap<List<User>, List<UserDTO>>();
            CreateMap<List<UserDTO>, List<User>>();
        }
    }
}
