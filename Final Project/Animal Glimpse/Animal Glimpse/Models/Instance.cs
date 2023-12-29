namespace Animal_Glimpse.Models
{
    public class Instance
    {
        public DateTime aquire_date {  get; set; }

        // Relation
            // User <-> Role
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }
        public User User { get; set; }
        public Role Role { get; set; }
    }
}
