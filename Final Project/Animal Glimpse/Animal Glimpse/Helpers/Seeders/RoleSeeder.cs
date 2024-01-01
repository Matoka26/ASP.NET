using Animal_Glimpse.Data;
using Animal_Glimpse.Models;

namespace Animal_Glimpse.Helpers.Seeders
{
    public class RoleSeeder
    {
        public readonly AnimalContext _context;
    
        public RoleSeeder(AnimalContext context)
        {
            _context = context;
        }

        public void SeedInitialRole()
        {
            if(!_context.Roles.Any())
            {
                var admin = new Role
                {
                    roleName = "admin"
                };

                var user = new Role
                {
                    roleName = "user"
                }; 
            
                _context.Roles.Add(admin);
                _context.Roles.Add(user);

                _context.SaveChanges();
            }
        }
    }
}
