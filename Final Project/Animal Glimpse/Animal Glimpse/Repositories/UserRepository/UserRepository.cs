using Animal_Glimpse.Data;
using Animal_Glimpse.Models;
using Animal_Glimpse.Repositories.GenericRepository;

namespace Animal_Glimpse.Repositories.UserRepository
{
    public class UserRepository: GenericRepository<User>, IUserRepository
    {
        public UserRepository(AnimalContext context) : base(context) { }

        // Just testing
        public List<User> OrderByUsername()
        {
            var userOrdered = from s in _table
                              orderby s.username
                              select s;
            
            return userOrdered.ToList();
        }
    }
}
