using AutoMapper;
using Tema4.Models;
using Tema4.Models.DTOs;
using Tema4.Repositories.ClientRepository;

namespace Tema4.Services.ClientService
{
    public class ClientService : IClientService
    {
        public IClientRepository _clientRepository;
        public IMapper _mapper;
        public ClientService(IClientRepository clientRepository, IMapper mapper)
        {
            _clientRepository = clientRepository;
            _mapper = mapper;
        }

        public async Task<List<ClientDTO>> GetAllClients()
        {
            var userList = await _clientRepository.GetAllAsync();
            var userListDTO = _mapper.Map<List<ClientDTO>>(userList);
            return userListDTO;
        }

        public ClientDTO GetUserByName(string username)
        {
            var user = _clientRepository.FindByName(username);
            var userDTO = _mapper.Map<ClientDTO>(user);
            return userDTO;
        }


        ///autocompleted
        Task<List<Client>> IClientService.GetAllClients()
        {
            throw new NotImplementedException();
        }

        ClientDTO IClientService.GetClientByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
