using Animal_Glimpse.Models.Base;

namespace Animal_Glimpse.Models
{
    public class User: BaseEntity
    {
        public string firstName {  get; set; }
        public string lastName {  get; set; }
        public string email {  get; set; }
        public string username {  get; set; }
        public string password {  get; set; }
        public string phoneNumber {  get; set; }
        public DateTime birthDate {  get;  set;  }  

        // Relations
        //Profile: One-to-One
        public Profile? Profile { get; set; }
            
            //Profile: One-to-One
        public Admin? Admin { get; set; }

            //Post: One-to-Many
        public ICollection<Post>? Posts { get; set; }
        
            //Post: Many-to-Many (Comment)
        public ICollection<Comments>? Commentss { get; set; }
            
            //Post, React: Many-to-Many-to-Many (Reaction)
        public ICollection<Reaction>? Reactions { get; set; }
    
    }
}
