using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tema3.Models.Base
{
    public class BaseEntity: IBaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    
        public Guid Id { get; set; }
        public DateTime? DateTime { get; set; }
        public DateTime? LastModified { get; set; }

    }
}
