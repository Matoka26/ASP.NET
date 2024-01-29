namespace Animal_Glimpse.Models.DTOs.CommentDTO
{
    public class CommentGetUsersDTO
    {
        public Guid CommentId {  get; set; }
        public string UserName { get; set; }
        public DateTime CreatedTime { get; set; }
        public string Content { get; set; }
    }
}
