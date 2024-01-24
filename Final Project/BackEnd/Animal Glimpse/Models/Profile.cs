using Animal_Glimpse.Models.Base;
using System.ComponentModel;

namespace Animal_Glimpse.Models
{
    public class Profile: BaseEntity
    {
        [DefaultValue("Images/Profile/Default/Default Profile Pic.jpeg")]
        public string ProfilePic {  get; set; }

        [DefaultValue("Images/Profile/Default/Default Cover Pic.jpeg")]
        public string CoverPic { get; set; }
        public string? Bio { get; set; }

        // Relations
            //User: One-to-One
        public User User { get; set; }
        public Guid UserId { get; set; }

    }
}
