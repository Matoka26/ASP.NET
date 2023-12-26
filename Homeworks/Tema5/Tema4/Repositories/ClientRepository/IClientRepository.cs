

using Tema4.Models;
using Tema4.Repositories.GenericRepository;

namespace Tema4.Repositories.ClientRepository
{
    public interface IClientRepository: IGenericRepository<Client>
    {
        public List<Client> OrderByName(int name);
    }
}
