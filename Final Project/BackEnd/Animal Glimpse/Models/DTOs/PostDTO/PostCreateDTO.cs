namespace Animal_Glimpse.Models.DTOs.PostDTO
{
    public class PostCreateDTO
    {

        public string? Description {  get; set; }
        public string Picture {  get; set; }
        public Guid UserId { get; set; }
    }
}
