using Animal_Glimpse.Data;
using Animal_Glimpse.Models;
using Animal_Glimpse.Repositories.GenericRepository;

namespace Animal_Glimpse.Repositories.CommentsRepository
{
    public class CommentsRepository: GenericRepository<Comments>, ICommentsRepository
    {
        public CommentsRepository(AnimalContext context) : base(context) { }
    }
}
