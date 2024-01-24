using Animal_Glimpse.Data;
using Animal_Glimpse.Models;
using Animal_Glimpse.Models.DTOs.PostDTO;
using Animal_Glimpse.Repositories.GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace Animal_Glimpse.Repositories.PostRepository
{
    public class PostRepository: GenericRepository<Post>, IPostRepository
    {
        public PostRepository(AnimalContext context) : base(context) { }

        public async Task<List<Post>> GetAllPostsAsync(Guid userId)
        {
            var query = from s in _table
                        where s.UserId == userId
                        orderby s.CreatedTime descending
                        select s;

            return await query.ToListAsync(); 
        }
    }
}
