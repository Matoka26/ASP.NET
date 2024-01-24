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
                    new IdentityRole<Guid>()
                    {
                        Id = new Guid("3f806af4-541e-44d3-b6f7-1c596f3db3cc"),
                        Name = "Sponsor",
                        NormalizedName = "Sponsor".ToUpper()
                    },
                    new IdentityRole<Guid>()
                    {
                        Id = new Guid("dfc9ac4f-b7e8-4144-95ba-0952eede041e"),
                        Name = "Business",
                        NormalizedName = "Business".ToUpper()
                    },
                    new IdentityRole<Guid>
                    { 
                        Id = new Guid("40cf48c6-0a71-4db7-9488-7f9b5d6c2094"),
                        Name = "Guest",
                        NormalizedName = "Guest".ToUpper()
                    }
                };

                _context.Roles.AddRange(role1);
                _context.SaveChanges();
            }
        }
    }
}
