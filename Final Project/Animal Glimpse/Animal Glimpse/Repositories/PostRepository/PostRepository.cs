using Animal_Glimpse.Data;
using Animal_Glimpse.Models;
using Animal_Glimpse.Repositories.GenericRepository;

namespace Animal_Glimpse.Repositories.PostRepository
{
    public class PostRepository: GenericRepository<Post>, IPostRepository
    {
        public PostRepository(AnimalContext context) : base(context) { }
    }
}
