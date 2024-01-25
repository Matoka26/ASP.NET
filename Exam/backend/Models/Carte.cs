using backend.Models.Base;

namespace backend.Models
{
    public class Carte:BaseEntity
    {
        public string Nume {  get; set; }
        public string? Descriere {  get; set; }

        public ICollection<AutorCarteRelatie>? AutoriCarteRelatie { get; set; }
        
    }
}
