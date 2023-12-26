using Tema4.Models2.Base;

namespace Tema4.Models.One_to_Many
{
    public class Model1: BaseEntity
    {
        public int? numar {  get; set; }

        public ICollection<Model2>? Models2 { get; set; }
    }
}
