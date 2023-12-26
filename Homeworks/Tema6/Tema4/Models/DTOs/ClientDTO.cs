namespace Tema4.Models.DTOs
{
    public class ClientDTO
    {
        public Guid Id { get; set; }
        public string FullName { get; set; } = default;
        public string Email { get; set; }
        public string Username { get; set; }
    }
}
