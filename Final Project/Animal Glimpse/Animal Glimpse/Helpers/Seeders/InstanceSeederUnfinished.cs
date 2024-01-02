using Animal_Glimpse.Data;
using Animal_Glimpse.Models;

namespace Animal_Glimpse.Helpers.Seeders
{
    public class InstanceSeeder
    {
        public readonly AnimalContext _context;

        public InstanceSeeder(AnimalContext context)
        {
            _context = context;
        }

        public void SeedInitialInstance()
        {/*
            if(!_context.Instances.Any())
            {
                var ins1 = new Instance
                {
                    UserId = new Guid("832C74E1-EF7C-4F47-F5E7-08DC0BC4745B"), //skpha
                    RoleId = new Guid("6ADEE5C5-669D-4940-6665-08DC0BC47459"), //user

                    User = _context.Users.Find(new Guid("832C74E1-EF7C-4F47-F5E7-08DC0BC4745B")),
                    Role = _context.Roles.Find(new Guid("6ADEE5C5-669D-4940-6665-08DC0BC47459"))
                };

                var ins2 = new Instance
                {
                    UserId = new Guid("043924B0-B518-4B63-F5E8-08DC0BC4745B"), //Matoka
                    RoleId = new Guid("6ADEE5C5-669D-4940-6665-08DC0BC47459"), //user

                    User = _context.Users.Find(new Guid("043924B0-B518-4B63-F5E8-08DC0BC4745B")),
                    Role = _context.Roles.Find(new Guid("6ADEE5C5-669D-4940-6665-08DC0BC47459"))
                };

                var ins3 = new Instance
                {
                    UserId = new Guid("402FA866-48D7-462E-F5E9-08DC0BC4745B"), //Qarty
                    RoleId = new Guid("1C25C86E-7CAB-4F16-4A33-08DC0B11E37C"), //user

                    User = _context.Users.Find(new Guid("402FA866-48D7-462E-F5E9-08DC0BC4745B")),
                    Role = _context.Roles.Find(new Guid("6ADEE5C5-669D-4940-6665-08DC0BC47459"))
                };

                var ins4 = new Instance
                {
                    UserId = new Guid("043924B0-B518-4B63-F5E8-08DC0BC4745B"), //Matoka
                    RoleId = new Guid("914FF44E-F6D2-4AD8-6664-08DC0BC47459"), //admin

                    User = _context.Users.Find(new Guid("043924B0-B518-4B63-F5E8-08DC0BC4745B")),
                    Role = _context.Roles.Find(new Guid("914FF44E-F6D2-4AD8-6664-08DC0BC47459"))
                };
                _context.Instances.Add(ins1);
                _context.Instances.Add(ins2);
                _context.Instances.Add(ins3);
                _context.Instances.Add(ins4);

                _context.SaveChanges();
            }*/
        }
    }
}
