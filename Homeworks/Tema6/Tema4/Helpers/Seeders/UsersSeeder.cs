using Azure.Identity;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using Tema4.Data;
using Tema4.Models;

namespace Tema4.Helpers.Seeders
{
    public class UsersSeeder
    {
        public readonly Tema4Context _tema4ontext;
        public UsersSeeder(Tema4Context tema4context)
        {
            this._tema4ontext = tema4context;
        }

        public void SeedInitialUsers()
        {
            if (!_tema4ontext.Users.Any())
            {
                var user1 = new User
                {
                    Name = "Marcel",
                    Email = "marcel@yahoo.com",
                    IsDeleted = false,
                    Username = "MarcelBoss"

                };

                _tema4ontext.Users.Add(user1);

                _tema4ontext.SaveChanges();
            }
        }
    }
}
