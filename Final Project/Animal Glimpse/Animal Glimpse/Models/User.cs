using Animal_Glimpse.Models.Base;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Animal_Glimpse.Models
{
    public class User: IdentityUser<Guid>
    {
        public string FirstName {  get; set; }
        public string LastName {  get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate {  get;  set;  }  

        // Relations
            //Profile: One-to-One
        public Profile? Profile { get; set; }

            //Post: One-to-Many
        public ICollection<Post>? Posts { get; set; }
        
            //Post: Many-to-Many (Comment)
        public ICollection<Comments>? Commentss { get; set; }
            
            //Post, React: Many-to-Many-to-Many (Reaction)
        public ICollection<Reaction>? Reactions { get; set; }
    
    }
}
