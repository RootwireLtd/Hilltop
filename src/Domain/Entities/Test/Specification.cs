﻿using Rootwire.Hilltop.Domain.Common;
using Rootwire.Hilltop.Domain.Extensions;

namespace Rootwire.Hilltop.Domain.Entities.Test;

public class Specification : BaseAuditableEntity
{
    public const string _prefix = "spec";
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
    /// The Name of the Specification
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// The Authority responsible for maintaining the specification
    /// </summary>
    public Authority Authority { get; set; }
    
    /// <summary>
    /// The Specification Reference Material
    /// </summary>
    public ReferenceResource Reference { get; set; }
}