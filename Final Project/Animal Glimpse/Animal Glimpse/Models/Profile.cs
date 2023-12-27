using Animal_Glimpse.Models.Base;

namespace Animal_Glimpse.Models
{
    public class Profile: BaseEntity
    {
        public string profilePic {  get; set; }
        public string coverPic { get; set; }
        public string bio { get; set; }

        // Relations
            //User: One-to-One
        public User User { get; set; }
        public Guid UserId { get; set; }

    }
}
