using Rootwire.Hilltop.Domain.Common;
using Rootwire.Hilltop.Domain.Extensions;

namespace Rootwire.Hilltop.Domain.Entities.Test;

public class Aggregate : BaseAuditableEntity
{
    public const string _prefix = "aggregate";
    
    private string _identifier;
    
    /// <summary>
    /// A String based identifier
    /// </summary>
    public string Identifier
    {
        get => _identifier;
        set => _identifier = value.GenerateEntityIdentifier();
    }
    
    public string ReferenceTag
    {
        get => $"{_prefix}:{_identifier}";
    }
    
    /// <summary>
    /// Summary of the Aggregate
    /// </summary>
    public string Summary { get; set; }

    /// <summary>
    /// More detailed description of the aggregate
    /// </summary>
    public string? Description { get; set; }
    
    /// <summary>
    /// Specification the Aggregate belongs to
    /// </summary>
    public Specification Specification { get; set; }

    /// <summary>
    /// The Parent Aggregate
    /// </summary>
    public Aggregate? Parent { get; set; }
    
}