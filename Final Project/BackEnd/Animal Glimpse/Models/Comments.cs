using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Animal_Glimpse.Models.Base;

namespace Animal_Glimpse.Models
{
    public class Comments: BaseEntity
    {
        /* The tuple (userId,postId) won't be the primary keye
         * It must be possible for a user to comment on a post
         * multiple times so there is used an artificial primary
         * key CommentId */
        public string content {  get; set; }

        // Relation
        // User <-> Post
        public Guid UserId { get; set; }
        public Guid PostId { get; set; }
        public User User { get; set; }
        public Post Post { get; set; }
    }
}
