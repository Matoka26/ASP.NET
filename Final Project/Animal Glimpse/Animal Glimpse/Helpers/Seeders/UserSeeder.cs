using Animal_Glimpse.Data;
using Animal_Glimpse.Models;

namespace Animal_Glimpse.Helpers.Seeders
{
    public class UserSeeder
    {
        public readonly AnimalContext _context;

        public UserSeeder(AnimalContext context)
        {
            _context = context;
        }
        
        public void SeedInitialUser()
        {
            if(!_context.Users.Any())
            {
                var user1 = new User
                {
                    FirstName = "Mincu",
                    LastName = "Adrian",
                    Email = "skpha13@gmail.com",
                    Username = "Skpha13",
                    PhoneNumber = "0733987486",
                    Password = "MihaiESmeker69",
                    BirthDate = new DateTime(2003, 07, 13),
                    
                    Profile = new Profile
                    {
                        Bio = "N ai tu treaba",
                        ProfilePic = "Images/Profile/Users/skpha13P.jpeg",
                        CoverPic = "Images/Profile/Users/skpha13C.jpeg"
                    }
                };

                var user2 = new User
                {
                    FirstName = "Dogaru",
                    LastName = "Mihail",
                    Email = "mihail_danut24@yahoo.com",
                    Username = "Matoka26",
                    PhoneNumber = "0739548109",
                    Password = "LaTineSiLaBani",
                    BirthDate = new DateTime(2003, 09, 24),

                    Profile = new Profile
                    {
                        Bio = "buna mami",
                        ProfilePic = "Images/Profile/Users/Matoka26P.jpeg",
                        CoverPic = "Images/Profile/Users/Matoka26C.jpeg"
                    }
                };

                var user3 = new User
                {
                    FirstName = "Mircea",
                    LastName = "Razvan",
                    Email = "razvanm99@gmail.com",
                    Username = "Qarty26",
                    PhoneNumber = "0727820349",
                    Password = "CeiAlaCox420",
                    BirthDate = new DateTime(2003, 04, 26),

                    Profile = new Profile
                    {
                        Bio = "TOP G,Imi place kartingu i guess",
                        CoverPic = "Images/Profile/Default/Default Cover Pic.jpeg",
                        ProfilePic = "Images/Profile/Default/Default Profile Pic.jpeg"
                    }
                };

                _context.Users.Add(user1);
                _context.Users.Add(user2);
                _context.Users.Add(user3);

                _context.SaveChanges();
            }
        }
    }
}
