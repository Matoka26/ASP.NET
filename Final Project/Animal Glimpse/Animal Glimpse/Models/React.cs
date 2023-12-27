using Animal_Glimpse.Models.Base;

namespace Animal_Glimpse.Models
{
    public class React: BaseEntity
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Logo { get; set; }

        //Relations
            //Post, User: Many-to-Many-to-Many (Reaction)
        public ICollection<Reaction> Reactions { get; set; }
    }
}
