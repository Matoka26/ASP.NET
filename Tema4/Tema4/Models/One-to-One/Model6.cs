using Tema4.Models2.Base;

namespace Tema4.Models.One_to_One
{
    public class Model6: BaseEntity
    {
        public string? Name {  get; set; }

        public Model5? Models5 { get; set; }

        public Guid Model5Id { get; set; }
    }
}
