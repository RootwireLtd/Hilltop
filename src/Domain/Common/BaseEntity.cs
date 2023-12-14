namespace Rootwire.Hilltop.Domain.Common;

public abstract class BaseEntity
{

    /// <summary>
    /// Database Primary Key
    /// </summary>
    public Guid Id { get; set; } = Guid.NewGuid();
}