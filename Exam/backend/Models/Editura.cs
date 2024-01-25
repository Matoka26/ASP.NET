using backend.Models.Base;

namespace backend.Models
{
    public class Editura:BaseEntity
    {
        public string Nume {  get; set; }
        public ICollection<Autor>? Autori {  get; set; }
    }
}
