using Animal_Glimpse.Models;
using Animal_Glimpse.Models.DTOs.CommentDTO;
using Animal_Glimpse.Repositories.GenericRepository;

namespace Animal_Glimpse.Repositories.CommentsRepository
{
    public interface ICommentsRepository: IGenericRepository<Comments>
    {
        Task<List<CommentGetUsersDTO>> GetCommsOfPost(Guid id);
        Task<List<CommentGetPostsDTO>> GetCommsOfUser(Guid id);
    }
}
