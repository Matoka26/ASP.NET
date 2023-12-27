using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Animal_Glimpse.Models
{
    public class Comments
    {
        /* The tuple (userId,postId) won't be the primary keye
         * It must be possible for a user to comment on a post
         * multiple times so there is used an artificial primary
         * key CommentId */

        [Key]
        // Generate a new value when you add a new row
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid CommentId { get; set; }
        public string content {  get; set; }
        public DateTime CreatedTime { get; set; }
        
        public DateTime? LastModifiedTime { get; set; }

        // Relation
        // User <-> Post
        public Guid UserId { get; set; }
        public Guid PostId { get; set; }
        public User User { get; set; }
        public Post Post { get; set; }
    }
}

/* Could have inherited BaseEntity, didn't feel like it 
 * Feels more clear to have this one explicit */
