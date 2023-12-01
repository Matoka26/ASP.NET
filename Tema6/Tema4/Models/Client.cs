using Tema4.Models2.Base;
using Tema4.Models.One_to_Many;

namespace Tema4.Models
{
    public class Client : BaseEntity
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string? Email { get; set; }

        public ICollection<Model2>? Models2 { get; set; }
    }
}
