using Animal_Glimpse.Data;
using Animal_Glimpse.Models;
using Animal_Glimpse.Models.DTOs.CommentDTO;
using Animal_Glimpse.Repositories.GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace Animal_Glimpse.Repositories.CommentsRepository
{
    public class CommentsRepository : GenericRepository<Comments>, ICommentsRepository
    {
        public CommentsRepository(AnimalContext context) : base(context) { }

        public async Task<List<CommentGetUsersDTO>> GetCommsOfPost(Guid id)
        {
            var commentsWithUserName = _table
                .Where(comment => comment.PostId == id)
                .Include(comment => comment.User)
                .Select(comment => new CommentGetUsersDTO()
                {
                    Content = comment.Content,
                    UserName = comment.User.UserName,
                    CreatedTime = comment.CreatedTime,
                    CommentId = comment.Id
                });

            return await commentsWithUserName.ToListAsync();
        }

        public async Task<List<CommentGetPostsDTO>> GetCommsOfUser(Guid id)
        {
            var commentsWithPostId = _table
                .Where(comment => comment.UserId == id)
                .Select(comment => new CommentGetPostsDTO()
                {
                    Content = comment.Content,
                    PostId = comment.PostId,
                    CreatedTime = comment.CreatedTime,
                    CommentId = comment.Id
                });

            return await commentsWithPostId.ToListAsync();
        }
    }
}
