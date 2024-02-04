using Animal_Glimpse.Models;
using Animal_Glimpse.Models.DTOs.PostDTO;
using Animal_Glimpse.Repositories.GenericRepository;

namespace Animal_Glimpse.Repositories.PostRepository
{
    public interface IPostRepository: IGenericRepository<Post>
    {
        Task<List<Post>> GetAllPostsAsync(Guid userId);
        Task<List<PostShownDTO>> GetFeed();
    }
}
