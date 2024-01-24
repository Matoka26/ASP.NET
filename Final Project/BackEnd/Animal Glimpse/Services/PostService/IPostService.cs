using Animal_Glimpse.Models;
using Animal_Glimpse.Models.DTOs.PostDTO;

namespace Animal_Glimpse.Services.PostService
{
    public interface IPostService
    {
        Task<List<PostDTO>> GetPostsByUsername(string username);
    }
}
