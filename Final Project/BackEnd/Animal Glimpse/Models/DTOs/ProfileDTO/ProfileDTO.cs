namespace Animal_Glimpse.Models.DTOs.ProfileDTO
{
    public class ProfileDTO
    {
        public Guid Id { get; set; }
        public string ProfilePic {  get; set; }
        public string CoverPic { get; set; }
        public string Bio { get; set; }
        public string Username {  get; set; }
    }
}
