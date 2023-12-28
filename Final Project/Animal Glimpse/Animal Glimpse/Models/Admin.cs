using Animal_Glimpse.Models.Base;

namespace Animal_Glimpse.Models
{
    public class Admin: BaseEntity
    {
        // Relations
        //User: One-to-One
        public User User { get; set; }
        public Guid UserId { get; set; }
    }
}
