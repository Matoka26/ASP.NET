using Tema4.Models;
using Tema4.Models.DTOs;

namespace Tema4.Services.ClientService

{
    public interface IClientService
    {
        public Task<List<Client>> GetAllClients();
        public ClientDTO GetClientByName(string name);
    }
}
