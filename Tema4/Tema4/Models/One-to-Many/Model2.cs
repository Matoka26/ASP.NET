using Tema4.Models2.Base;

namespace Tema4.Models.One_to_Many
{
    public class Model2: BaseEntity
    {
        public int numar {  get; set; }

        public Model1? Models1 { get; set; }

        public Guid Model1Id { get; set; }

    }
}
