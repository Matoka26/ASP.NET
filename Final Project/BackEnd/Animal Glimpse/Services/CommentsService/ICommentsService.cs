using Animal_Glimpse.Models;
using Animal_Glimpse.Models.DTOs.CommentDTO;

namespace Animal_Glimpse.Services.CommentsService
{
    public interface ICommentsService
    {
        Task AddComment(CommentCreateDTO comm);
        Task<List<CommentGetUsersDTO>> GetCommsOfPost(Guid postId);
        Task<List<CommentGetPostsDTO>> GetCommsOfUser(Guid userId);
        Task UpdateComment(CommentUpdateDTO comm);
        Task DeleteComment(Guid id);
    }
}
