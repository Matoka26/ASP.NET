using Animal_Glimpse.Models.Base;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Animal_Glimpse.Models
{
    public class User: BaseEntity
    {
        public string FirstName {  get; set; }
        public string LastName {  get; set; }
        public string Email {  get; set; }
        public string Username {  get; set; }
        public string Password {  get; set; }
        public string PhoneNumber {  get; set; }
        public DateTime BirthDate {  get;  set;  }  

        // Relations
            //Profile: One-to-One
        public Profile? Profile { get; set; }

            //Role: Many-to-Many (Instance)
        public ICollection<Instance>? Instances { get; set; }

            //Post: One-to-Many
        public ICollection<Post>? Posts { get; set; }
        
            //Post: Many-to-Many (Comment)
        public ICollection<Comments>? Commentss { get; set; }
            
            //Post, React: Many-to-Many-to-Many (Reaction)
        public ICollection<Reaction>? Reactions { get; set; }
    
    }
}
