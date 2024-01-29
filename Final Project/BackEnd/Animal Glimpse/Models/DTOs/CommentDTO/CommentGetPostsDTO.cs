namespace Animal_Glimpse.Models.DTOs.CommentDTO
{
    public class CommentGetPostsDTO
    {
        public Guid CommentId { get; set; }
        public Guid PostId { get; set; }
        public DateTime CreatedTime { get; set; }
        public string Content { get; set; }
    }
}
