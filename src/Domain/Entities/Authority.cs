using Rootwire.Hilltop.Domain.Common;
using Rootwire.Hilltop.Domain.Extensions;

namespace Rootwire.Hilltop.Domain.Entities;

public class Authority : BaseAuditableEntity
{
    public const string _prefix = "authority";

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
    
    public Authority(string name, string description = null)
    {
        Name = name;
        Description = description;
        
        string normalisedName = Name.GenerateEntityIdentifier();
        Identifier = $"{_prefix}:{normalisedName}";
    }
}