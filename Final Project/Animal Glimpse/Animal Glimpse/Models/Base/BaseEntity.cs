using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Animal_Glimpse.Models.Base
{
    public class BaseEntity: IBaseEntity
    {
        [Key]
        // Generate a new value when you add a new row
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
