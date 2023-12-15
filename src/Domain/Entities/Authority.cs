using Rootwire.Hilltop.Domain.Common;
using Rootwire.Hilltop.Domain.Extensions;

namespace Rootwire.Hilltop.Domain.Entities;

public class Authority : BaseAuditableEntity
{
    public const string _prefix = "authority";

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
    
    private string _name;
    private string _description;
        
    /// <summary>
    /// Authority Name
    /// </summary>
    public string Name { get => _name;
        set { _name = value; }
    }
    
    /// <summary>
    /// More detailed description of the authority
    /// </summary>
    public string? Description { get => _description;
        set { _description = value; }
    }
}