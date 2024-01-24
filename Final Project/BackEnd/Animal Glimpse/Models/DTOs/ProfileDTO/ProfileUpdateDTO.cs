namespace Animal_Glimpse.Models.DTOs.ProfileDTO
{
    public class ProfileUpdateDTO
    {
        public Guid Id { get; set; }
        public string? ProfilePic { get; set; }
        public string? CoverPic { get; set; }
        public string? Bio { get; set; }
    }
}
