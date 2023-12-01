using Tema4.Repositories.GenericRepository;
using Tema4.Models;

namespace Tema4.Repositories.UserRepository
{
    public interface IUserRepository: IGenericRepository<User>
    {
        User FindByUsername(string username);
        List<User> FindAllActive();
    }
}
