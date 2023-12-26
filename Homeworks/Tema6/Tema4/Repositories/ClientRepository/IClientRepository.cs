

using Tema4.Models;
using Tema4.Models.DTOs;
using Tema4.Repositories.GenericRepository;

namespace Tema4.Repositories.ClientRepository
{
    public interface IClientRepository: IGenericRepository<Client>
    {
        List<Client> OrderByName(int name);
        Client FindByName(string username);
    }
}
