using Animal_Glimpse.Models.Base;
namespace Animal_Glimpse.Models
{
    public class Reaction
    {
        //Relation
        //User <-> Post <-> React
        
        public Guid UserId { get; set; }
        public Guid PostId { get; set; }
        public Guid ReactId { get; set; }
        public User User { get; set; }
        public Post Post { get; set; }
        public React React { get; set; }
    }
}
