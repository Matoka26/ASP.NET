namespace Tema3.Models.Base
{
    public class IBaseEntity
    {
        Guid Id { get; set; }
        DateTime? DateTime { get; set; }
        DateTime? LastModified { get; set; }   

    }
}
