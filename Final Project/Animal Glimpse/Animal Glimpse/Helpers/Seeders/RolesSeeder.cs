using Animal_Glimpse.Data;
using Microsoft.AspNetCore.Identity;

namespace Animal_Glimpse.Helpers.Seeders
{
    public class RolesSeeder
    {
        public readonly AnimalContext _context;
    
        public RolesSeeder(AnimalContext context)
        {
            _context = context;
        }   
        public void SeedInitialRoles()
        {
            if(!_context.Roles.Any())
            {
                var role1 = new List<IdentityRole<Guid>>()
                {
                    new IdentityRole<Guid>()
                    {
                        Id = new Guid("87c63ad73e24447a8e60a1d814abaa78"),
                        Name = "Admin",
                        NormalizedName = "Admin".ToUpper()
                    },
                    new IdentityRole<Guid>()
                    {
                        Id = new Guid("1b2fe19c191441048294d308fd98e44d"),
                        Name = "User",
                        NormalizedName = "User".ToUpper()
                    },
                };

                _context.Roles.AddRange(role1);
                _context.SaveChanges();
            }
        }
    }
}
