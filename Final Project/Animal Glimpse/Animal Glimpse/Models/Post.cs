using Animal_Glimpse.Models.Base;

namespace Animal_Glimpse.Models
{
    public class Post: BaseEntity
    {
        public string? Description {  get; set; }
        public string Picture {  get; set; }

        // Relations
            // User: One-to-Many
        public User User { get; set; }
        public Guid UserId { get; set; }

            // User: Many-to-Many (Comment)
        public ICollection<Comments> Commentss { get; set; }
        
            //User, React: Many-to-Many-to-Many (Reaction)
        public ICollection<Reaction> Reactions { get; set; }
    }
}
