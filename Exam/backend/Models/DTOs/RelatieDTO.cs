namespace backend.Models.DTOs
{
    public class RelatieDTO
    {
        public Guid? AutorId { get; set; }
        public Autor? Autor { get; set; }

        public Guid? CarteId { get; set; }
        public Carte? Carte { get; set; }
    }
}
