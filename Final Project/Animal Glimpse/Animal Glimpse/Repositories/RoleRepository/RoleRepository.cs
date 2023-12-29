using Animal_Glimpse.Data;
using Animal_Glimpse.Models;
using Animal_Glimpse.Repositories.GenericRepository;

namespace Animal_Glimpse.Repositories.RoleRepository
{
    public class RoleRepository: GenericRepository<Role>, IRoleRepository
    {
        public RoleRepository(AnimalContext context) : base(context) { }
    }
}
