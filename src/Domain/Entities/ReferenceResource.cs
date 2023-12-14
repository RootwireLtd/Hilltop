using Rootwire.Hilltop.Domain.Common;

namespace Rootwire.Hilltop.Domain.Entities;

public class ReferenceResource : BaseAuditableEntity
{
    /// <summary>
    /// The location where the resource can be found.
    /// </summary>
    public Uri Uri { get; set; }
    /// <summary>
    /// The resource version reference number, if present
    /// </summary>
    public string? Version { get; set; }
    /// <summary>
    /// The resource release date, if known
    /// </summary>
    public DateOnly? ReleaseDate { get; set; }
    
}