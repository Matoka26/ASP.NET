using Tema4.Models.Enums;
using Tema4.Models2.Base;

namespace Tema4.Models
{
    public class User: BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; } 
        public string Username {  get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }

    }
}
