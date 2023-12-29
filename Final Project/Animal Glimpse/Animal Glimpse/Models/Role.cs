using Animal_Glimpse.Models.Base;

namespace Animal_Glimpse.Models
{   
    /* Added a table of roles even tho we'll only use 2
     * User and Admin,but it would be more flexible in
     * case you need to add or update one of them */
    public class Role: BaseEntity
    {
        public string roleName {  get; set; }

        // Relation
            //User: Many-to-Many (Instance)
        public ICollection<Instance>? instances { get; set; }
    }
}
