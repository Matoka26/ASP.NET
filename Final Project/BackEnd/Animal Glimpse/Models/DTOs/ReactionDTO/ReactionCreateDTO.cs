namespace Animal_Glimpse.Models.DTOs.ReactionDTO
{
    public class ReactionCreateDTO
    {
        public Guid UserId { get; set; }
        public Guid PostId { get; set; }
        public Guid ReactId { get; set; }
    }
}
