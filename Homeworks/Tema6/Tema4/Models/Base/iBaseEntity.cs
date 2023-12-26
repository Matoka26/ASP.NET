namespace Tema4.Models2.Base
{
    public interface iBaseEntity
    {
        Guid id { get; set; }
        DateTime? DateCreated { get; set; }
        DateTime? DateModified { get; set; }

    }
}
