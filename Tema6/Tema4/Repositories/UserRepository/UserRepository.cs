using Tema4.Data;
using Tema4.Helpers.Extensions;
using Tema4.Models;
using Tema4.Repositories.GenericRepository;

namespace Tema4.Repositories.UserRepository
   
{

    public class UserRepository: GenericRepository<User>,IUserRepository
    {
        public UserRepository(Tema4Context tema4Context) : base(tema4Context)
        {

        }

        public User FindByUsername(string username)
        {
            return _table.FirstOrDefault(u => u.Username.Equals(username));
        }

        public List<User> FindAllActive()
        {
            return _table.GetActiveUsers().ToList();
        }
    }
}
