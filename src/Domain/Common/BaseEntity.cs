namespace Rootwire.Hilltop.Domain.Common;

public abstract class BaseEntity
{
    /// <summary>
    /// Hyphen seperated identifier
    /// </summary>
    public string Identifier { get; set; }

    /// <summary>
    /// Database Primary Key
    /// </summary>
    public Guid Id { get; set; } = Guid.NewGuid();
}