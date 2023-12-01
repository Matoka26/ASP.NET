using Tema4.Models2.Base;

namespace Tema4.Models.One_to_One
{
    public class Model5: BaseEntity
    {
        public string? Name { get; set; }

        public Model6? Models6 { get; set; }

    }
}
