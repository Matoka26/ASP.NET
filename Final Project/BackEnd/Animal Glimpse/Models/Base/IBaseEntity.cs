namespace Animal_Glimpse.Models.Base
{
    public interface IBaseEntity
    {
        Guid Id { get; set; }
        DateTime CreatedTime { get; set; }
        DateTime? LastModifiedTime { get; set; }
    }
}
