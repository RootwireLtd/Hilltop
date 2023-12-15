using Rootwire.Hilltop.Domain.Common;
using Rootwire.Hilltop.Domain.Extensions;

namespace Rootwire.Hilltop.Domain.Entities.Test;

public class TestCase : BaseAuditableEntity
{
    public const string _prefix = "testcase";
    
    private string _identifier;
    
    /// <summary>
    /// A String based, human readable identifier
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
    /// Summary of the Test Case
    /// </summary>
    public string Summary { get; set; }
    
    /// <summary>
    /// More detailed description of the test case
    /// </summary>
    public string Description { get; set; }

    public Aggregate Aggregate { get; set; }
    
    public Category Category { get; set; }

    public void SetIdentifier()
    {
        string normalisedSummary = Summary.GenerateEntityIdentifier();
        Identifier = $"{_prefix}_{normalisedSummary}";
    }
}