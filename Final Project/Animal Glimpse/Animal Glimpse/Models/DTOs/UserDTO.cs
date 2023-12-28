namespace Animal_Glimpse.Models.DTOs
{
    public class CreateUserDTO
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string phoneNumber { get; set; }
        public DateTime birthDate {  get; set; }
        public Profile Profile { get; set; }
    }
}
