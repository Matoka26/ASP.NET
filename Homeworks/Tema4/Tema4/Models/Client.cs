using Tema4.Models2.Base;

namespace Tema4.Models
{
    public class Client : BaseEntity
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string? Email { get; set; }

    }
}
