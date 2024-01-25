using backend.Models.Base;

namespace backend.Models
{
    public class AutorCarteRelatie: BaseEntity
    {
        public Guid AutorId { get; set; }
        public Autor? Autor { get; set; }

        public Guid CarteId { get; set; }
        public Carte? Carte { get; set; }
    }
}
