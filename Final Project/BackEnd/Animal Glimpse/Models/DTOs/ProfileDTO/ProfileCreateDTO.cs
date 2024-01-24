using System.ComponentModel;

namespace Animal_Glimpse.Models.DTOs.ProfileDTO
{
    public class ProfileCreateDTO
    {
        public Guid UserId { get; set; }

        [DefaultValue("Images/Profile/Default/Default Profile Pic.jpeg")]
        public string? ProfilePic { get; set; }

        [DefaultValue("Images/Profile/Default/Default Cover Pic.jpeg")]
        public string? CoverPic { get; set; }
        public string? Bio { get; set; }
    }
}
