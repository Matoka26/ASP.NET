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
        {
            if(!_context.Instances.Any())
            {
                var ins1 = new Instance
                {
                    UserId = new Guid("5A754965-B3F5-4557-1C6F-08DC0B123421"), //skpha
                    RoleId = new Guid("1C25C86E-7CAB-4F16-4A33-08DC0B11E37C") //user

                    User = //get useer by id
                    Role = //get role by id
                };

                var ins2 = new Instance
                {
                    UserId = new Guid("4E932E81-1402-46E0-1C70-08DC0B123421"), //Matoka
                    RoleId = new Guid("1C25C86E-7CAB-4F16-4A33-08DC0B11E37C") //user
                };

                var ins3 = new Instance
                {
                    UserId = new Guid("3518C035-9093-45B8-1C71-08DC0B123421"), //Qarty
                    RoleId = new Guid("1C25C86E-7CAB-4F16-4A33-08DC0B11E37C") //user
                };

                var ins4 = new Instance
                {
                    UserId = new Guid("4E932E81-1402-46E0-1C70-08DC0B123421"), //Matoka
                    RoleId = new Guid("F73AAE8C-0E3E-4EEC-4A32-08DC0B11E37C") //user
                };
                _context.Instances.Add(ins1);
                _context.Instances.Add(ins2);
                _context.Instances.Add(ins3);
                _context.Instances.Add(ins4);

                _context.SaveChanges();
            }
        }
    }
}
