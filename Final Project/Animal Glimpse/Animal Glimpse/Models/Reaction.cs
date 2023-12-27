namespace Animal_Glimpse.Models
{
    public class Reaction
    {
        /* Here the ID will the tuple of the 3
         * You can't have more than a reaction on a post */
        public DateTime CreateTime { get; set; }
        public DateTime? LastModifiedTime { get; set; }
       
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
