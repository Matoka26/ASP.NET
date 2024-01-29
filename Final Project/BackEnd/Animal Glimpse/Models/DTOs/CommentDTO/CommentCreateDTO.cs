namespace Animal_Glimpse.Models.DTOs.CommentDTO
{
    public class CommentCreateDTO
    {
        public string Content { get; set; }
        public Guid PostId { get; set; }
        public Guid UserId { get; set; }
        //public Comments? Comment {  get; set; }
        //public User? User { get; set; }
    }
}
