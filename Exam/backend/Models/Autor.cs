using backend.Models.Base;

namespace backend.Models
{
    public class Autor: BaseEntity
    {
        public string Nume {  get; set; }

        public ICollection<AutorCarteRelatie>? AutorCarteRelatie { get; set; }

        public Guid EdituraId { get; set; }
        public Editura Editura { get; set; }
    }
}
