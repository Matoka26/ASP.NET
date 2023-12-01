using AutoMapper;
using Tema4.Models;
using Tema4.Models.DTOs;
namespace Tema4.Helpers
{
    public class MapperProfile: Profile
    {
        public MapperProfile()
        {
            CreateMap<User, UserDTO>();
            CreateMap<UserDTO, User>();

            CreateMap<User, UserDTO>()
                    .ForMember(ud => ud.FullName,
                     opts => opts.MapFrom(u => u.Name + u.Username));

            CreateMap<Client, ClientDTO>();
            CreateMap<ClientDTO, Client>();
        }
    }
}
