using Animal_Glimpse.Repositories.GenericRepository;
using Animal_Glimpse.Models;

namespace Animal_Glimpse.Repositories.UserRepository
{
    public interface IUserRepository: IGenericRepository<User>
    {
        // Just testing
        List<User> OrderByUsername(string username);
    }
}
