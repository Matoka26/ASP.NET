using Animal_Glimpse.Data;
using Animal_Glimpse.Models;
using Microsoft.AspNetCore.Identity;

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
                var hasher = new PasswordHasher<User>();
                var users = new List<User>()
                {
                    new User()
                    {
                        Id = new Guid("a777c9f3-6811-4bb6-bb20-352bdd9f00a1"),
                        UserName = "skpha13",
                        NormalizedUserName = "skpha13".ToUpper(),
                        Email = "skpha13@gmail.com",
                        NormalizedEmail = "skpha13@gmail.com".ToUpper(),
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null,"MihaiESmeker69"),
                        SecurityStamp = Guid.NewGuid().ToString(),

                        BirthDate = new DateTime(2003, 07, 13),
                        FirstName = "Mincu",
                        LastName = "Adrian",
                        PhoneNumber = "0733987486",

                        Profile = new Profile
                        {
                            Bio = "N ai tu treaba",
                            ProfilePic = "Images/Profile/Users/skpha13P.jpeg",
                            CoverPic = "Images/Profile/Users/skpha13C.jpeg"
                        },
                        Posts = new List<Post>
                        {
                            new Post
                            {
                                Description = "check this out",
                                Picture = "Images/Posts/Pipe Dog.jpeg"
                            },
                            new Post
                            {
                                Description = "they be addicted",
                                Picture = "Images/Posts/Pipe Dog2.jpeg"
                            }
                        }
                    },

                    new User()
                    {
                        Id = new Guid("aeb1d17a-f966-4089-a5b8-f28ce98d4e28"),
                        UserName = "Matoka26",
                        NormalizedUserName = "Matoka26".ToUpper(),
                        Email = "mihail_danut24@yahoo.com",
                        NormalizedEmail = "mihail_danut24@yahoo.com".ToUpper(),
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "LaTineSiLaBani"),
                        SecurityStamp = Guid.NewGuid().ToString(),

                        FirstName = "Dogaru",
                        LastName = "Mihail",
                        PhoneNumber = "0739548109",
                        BirthDate = new DateTime(2003, 09, 24),

                        Profile = new Profile
                        {
                            Bio = "buna mami",
                            ProfilePic = "Images/Profile/Users/Matoka26P.jpeg",
                            CoverPic = "Images/Profile/Users/Matoka26C.jpeg"
                        },

                        Posts = new List<Post>
                        {
                            new Post
                            {
                                Description = "AI knows it sht",
                                Picture = "Images/Posts/Many Bees.jpeg"
                            },
                            new Post
                            {
                                Description = "big chonck",
                                Picture = "Images/Posts/Big Bee.jpeg"
                            }
                        }
                    },

                    new User()
                    {
                        Id = new Guid("3cc80f65-2fc3-407d-b9d5-7be0b1439a08"),
                        UserName = "Qarty26",
                        NormalizedUserName = "Qarty26".ToUpper(),
                        Email = "razvanm99@gmail.com",
                        NormalizedEmail = "razvanm99@gmail.com".ToUpper(),
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "CeiAlaCox420"),
                        SecurityStamp = Guid.NewGuid().ToString(),

                        PhoneNumber = "0727820349",
                        FirstName = "Mircea",
                        LastName = "Razvan",
                        BirthDate = new DateTime(2003, 04, 26),

                        Profile = new Profile
                        {
                            Bio = "TOP G,Imi place kartingu i guess",
                            CoverPic = "Images/Profile/Default/Default Cover Pic.jpeg",
                            ProfilePic = "Images/Profile/Default/Default Profile Pic.jpeg"
                        },

                        Posts = new List<Post>
                        {
                            new Post
                            {
                                Description = "Champ!!",
                                Picture = "Images/Posts/Cat Kart.jpeg"
                            }
                        }
                    }
                };

                _context.Users.AddRange(users);
                
                _context.SaveChanges();
            }
        }
    }
}
