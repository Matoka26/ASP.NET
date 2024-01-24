using Animal_Glimpse.Models;
using Animal_Glimpse.Models.DTOs.PostDTO;
using Animal_Glimpse.Models.DTOs.UserDTOs;

namespace Animal_Glimpse.Services.PostService
{
    public interface IPostService
    {
        Task<List<PostShownDTO>> GetFeed();
        Task<List<PostCreateDTO>> GetPostsByUsername(string username);
        Task CreatePost(PostCreateDTO post);
        void UpdatePost(PostUpdateDTO post);
        void Delete(Guid id);
    }
}
